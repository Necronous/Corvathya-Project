

//#define DEBUG_ENTITY_CONTROLLER

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public abstract class BaseEntityController : MonoBehaviour
{


    protected StateMachine<BaseEntityController> _stateMachine;
    protected Rigidbody2D _rigidBody;

    public BoxCollider2D BoundingBox { get; private set; }


    public Vector2 Velocity;
    public float MaxSpeed = 10f;
    public float Acceleration = .5f;
    public float Deceleration = .5f;

    public float ViewDistance = 8f;

    public float JumpForce = 15f;
    public float GravityForce = .9f;

    public float MovementMagnitude;
    
    public bool isAttacking;
    public bool isPushable = true;

    public bool NearLedgeLeft;// { get; private set; } Get set makes it invisible in the editor.
    public bool NearLedgeRight;// { get; private set; }

    public bool OnGround => _collisionList[(int)DirectionEnum.DOWN];
    private bool[] _collisionList;
    private Collider2D[] _colliderList;

    private List<MapArea> _areaModifiers = new();

    public float FacingDirection
    {
        get => Mathf.Clamp(transform.localScale.x, -1, 1);
        set
        {
            if (value > 0)
                value = 1;
            else if (value < 0)
                value = -1;
            else
                value = transform.localScale.x * -1;
            transform.localScale = new(value, transform.localScale.y);
        }
    }
    
    
    #region StateMachinePassThrough
    public int CurrentState => _stateMachine.CurrentState;
    public int LastState => _stateMachine.LastState;
    public float CurrentStateTime => _stateMachine.CurrentStateTime;
    public float LastStateTime => _stateMachine.LastStateTime;
    public bool SetState(int state) => _stateMachine.SetState(state);

    public bool HasState(int state) => _stateMachine.HasState(state);

    public bool DeRegisterState(int state) => _stateMachine.DeRegisterState(state);

    public bool RegisterState(int state, Func<BaseEntityController, bool> fun) => _stateMachine.RegisterState(state, fun);

    #endregion

    protected void InitializeEntity()
    {
        if(GetType() != typeof(PlayerController)) 
            Map.Instance?.AddNPC(this);

        _stateMachine = new();
        _rigidBody = GetComponent<Rigidbody2D>();
        BoundingBox = GetComponent<BoxCollider2D>();
        _collisionList = new bool[4];
        _colliderList = new Collider2D[4];

    }

    protected void UpdateEntity()
    {
        //Update collisions
        ContactPoint2D[] contacts = new ContactPoint2D[8];
        int contactCount = BoundingBox.GetContacts(contacts);
        for (int i = 0; i < 4; i++)
        {
            _collisionList[i] = false;
            _colliderList[i] = null;
        }

        for (int i = 0; i < contactCount; i++)
        {
            Vector3 normal = contacts[i].normal;
            Collider2D collider = contacts[i].collider;
            if (Mathf.Abs(normal.x) > Mathf.Abs(normal.y))
            {
                if (normal.x > 0)
                {
                    _collisionList[(int)DirectionEnum.LEFT] = true;
                    _colliderList[(int)DirectionEnum.LEFT] = collider;
                }
                else
                {
                    _collisionList[(int)DirectionEnum.RIGHT] = true;
                    _colliderList[(int)DirectionEnum.RIGHT] = collider;
                }
            }
            else
            {
                if (normal.y > 0)
                {
                    _collisionList[(int)DirectionEnum.DOWN] = true;
                    _colliderList[(int)DirectionEnum.DOWN] = collider;
                }
                else
                {
                    _collisionList[(int)DirectionEnum.UP] = true;
                    _colliderList[(int)DirectionEnum.UP] = collider;
                }
            }
        }

        //Check for ledges
        
        float xDistanceFromOrigin = BoundingBox.size.x / 2 + .2f;
        float distanceToCheck = 0.2f;   
        //alter the distance based on velocity? 

        Vector2 leftCheck = new Vector2(transform.position.x - xDistanceFromOrigin, transform.position.y);
        Vector2 rightCheck = new Vector2(transform.position.x + xDistanceFromOrigin, transform.position.y);

        NearLedgeLeft = Physics2D.Linecast(leftCheck, leftCheck - ( Vector2.up * distanceToCheck));
        NearLedgeRight = Physics2D.Linecast(rightCheck, rightCheck - ( Vector2.up * distanceToCheck));

#if DEBUG_ENTITY_CONTROLLER
        Debug.DrawLine(leftCheck, leftCheck - (Vector2.up * distanceToCheck));
        Debug.DrawLine(rightCheck, rightCheck - (Vector2.up * distanceToCheck));
#endif
        _stateMachine.UpdateMachine(this);
        _rigidBody.velocity = Velocity;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        MapArea area = collision.GetComponent<MapArea>();
        if (area != null)
            _areaModifiers.Add(area);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MapArea area = collision.GetComponent<MapArea>();
        if (area != null)
            _areaModifiers.Remove(area);
    }

    /// <summary>
    /// Check if an object is in view of the entity
    /// based view distance.
    /// </summary>
    /// <param name="obj">Object to look for</param>
    /// <returns>True if in view, else false.</returns>
    public bool InView(GameObject obj) => InView(obj, out float dist);
    
    /// <summary>
    /// Check if an object is in view of the entity
    /// based on view distance.
    /// </summary>
    /// <param name="obj">Object to look for.</param>
    /// <param name="distance">Distance of target if in view.</param>
    /// <returns>True if in view, else false.</returns>
    public bool InView(GameObject obj, out float distance)
    {
        distance = Vector3.Distance(obj.transform.position, transform.position);
        if (distance > ViewDistance 
            || (distance < 0 && FacingDirection == 1)
            || (distance > 0 && FacingDirection == -1))
            return false;
        return true;
    }

    public bool CanBePushed(DirectionEnum dir)
    {
        
        Collider2D collision = _colliderList[(int)dir];
        BaseEntityController target = collision.GetComponent<BaseEntityController>();
        return target != null ? target.isPushable : false;
    }

    public bool IsCollision(DirectionEnum dir)
        => _collisionList[(int)dir];
    public Collider2D GetCollision(DirectionEnum dir)
        => IsCollision(dir) ? _colliderList[(int)dir] : null;


    public bool HasAreaModifier(AreaModifierEnum mod)
    {
        foreach(MapArea area in _areaModifiers)
            if(area.HasModifier(mod))
                return true;
        return false;
    }
}
