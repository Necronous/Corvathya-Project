


using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// A base class for Entities.
/// </summary>
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

    public bool OnGround => _baseCollisionInfo[(int)DirectionEnum.DOWN].collision;
    
    private List<MapArea> _areaModifiers = new();

    /// <summary>
    /// Get or sets the entities facing direction.
    /// 1 = right, 2 = left, 0 = Flip
    /// </summary>
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

    #region Collision.
    private (bool collision, Collider2D collider)[] _baseCollisionInfo;

    private void UpdateCollisions()
    {
        ContactPoint2D[] contacts = new ContactPoint2D[16];
        int contactCount = BoundingBox.GetContacts(contacts);
        for (int i = 0; i < 4; i++)
        {
            _baseCollisionInfo[i] = (false, null);
        }

        //Get basic info first.
        for (int i = 0; i < contactCount; i++)
        {
            Vector3 normal = contacts[i].normal;
            Collider2D collider = contacts[i].collider;
            if (Mathf.Abs(normal.x) > Mathf.Abs(normal.y))
            {
                if (normal.x > 0)
                    _baseCollisionInfo[(int)DirectionEnum.LEFT] = (true, collider);
                else
                    _baseCollisionInfo[(int)DirectionEnum.RIGHT] = (true, collider);
            }
            else
            {
                if (normal.y > 0)
                    _baseCollisionInfo[(int)DirectionEnum.DOWN] = (true, collider);
                else
                    _baseCollisionInfo[(int)DirectionEnum.UP] = (true, collider);
            }
        }

    }
    /// <summary>
    /// get more precise collision from specified side.
    /// Start and end are for checking collision on a certain part must be between 0f - 1f where 1f is height of player and 0 is bottom.
    /// IE start = 0, end = 0.5f will only check and return collision start from the player bottom to halfway up.
    /// </summary>
    /// <param name="dir">Direction to check</param>
    /// <param name="resolution">Resolution</param>
    /// <param name="start">Where to start</param>
    /// <param name="end">Where to end</param>
    /// <returns></returns>
    public bool[] GetPreciseCollisionsHorizontal(DirectionEnum dir, int resolution, float start = 0, float end = 0)
        => GetPreciseCollisionsHorizontal(dir == DirectionEnum.LEFT ? -1 : 1, resolution);
    /// <summary>
    /// get more precise collision from specified side.
    /// Start and end are for checking collision on a certain part must be between 0f - 1f where 1f is height of player and 0 is bottom.
    /// IE start = 0, end = 0.5f will only check and return collision start from the player bottom to halfway up.
    /// </summary>
    /// <param name="dir">Direction to check</param>
    /// <param name="resolution">Resolution</param>
    /// <param name="start">Where to start</param>
    /// <param name="end">Where to end</param>
    /// <returns></returns>
    public bool[] GetPreciseCollisionsHorizontal(float dir, int resolution, float start = 0, float end = 1f)
    {
        bool[] cols = new bool[resolution];
        GetPreciseCollisionsHorizontal(dir,cols , start, end);
        return cols;
    }
    /// <summary>
    /// get more precise collision from specified side.
    /// Start and end are for checking collision on a certain part must be between 0f - 1f where 1f is height of player and 0 is bottom.
    /// IE start = 0, end = 0.5f will only check and return collision start from the player bottom to halfway up.
    /// </summary>
    /// <param name="dir">Direction to check</param>
    /// <param name="resolution">Resolution</param>
    /// <param name="start">Where to start</param>
    /// <param name="end">Where to end</param>
    /// <param name="array">Array of bools to retrieve results.</param>
    public void GetPreciseCollisionsHorizontal(float dir, bool[] array, float start = 0, float end = 1f)
    {
        start = Mathf.Clamp(Mathf.Min(start, end), 0f, 1f);
        end = Mathf.Clamp(Mathf.Max(start, end), 0f, 1f);

        if (start == end)
        {
            array = null;
            return;
        }
        float resolution = array.Length;
        float startY = BoundingBox.size.y * start;
        float endY = BoundingBox.size.y * end;

        float xOffset = transform.position.x + ((BoundingBox.size.x / 2) * dir);
        float boxHeight = (endY - startY) / resolution;
        
        //cast 4 boxes of height (boundingbox.size.y / resolution) along the player y axis,
        //if all 4 boxes have collisions it is a wall
        //the topmost box will have an extra linecast check for ledge grabbing to make sure it isent half full

        for (int i = 0; i < resolution; i++)
        {
            Vector2 boxStart = new(
                xOffset,
                transform.position.y + startY + (i * boxHeight)
                );
            Vector2 boxEnd = boxStart + new Vector2(.1f * dir, boxHeight);
            array[i] = Physics2D.OverlapArea(boxStart, boxEnd, 1 << 7); //Only check SOLID layer for now.
            if (array[i] == true)
                Debug.DrawLine(boxStart, boxEnd, Color.green);
            else
                Debug.DrawLine(boxStart, boxEnd, Color.red);
        }

        return;
    }

    /// <summary>
    /// Check if there is a collision in the specified direction.
    /// </summary>
    /// <param name="dir">Direction to check.</param>
    /// <returns>True if there is a collision, else false.</returns>
    public bool IsCollision(DirectionEnum dir)
        => _baseCollisionInfo[(int)dir].collision;

    /// <summary>
    /// Check if there is a collision in the specified direction.
    /// </summary>
    /// <param name="dir">Direction to check.</param>
    /// <returns>True if there is a collision, else false.</returns>
    public bool IsCollision(float dir)
        => IsCollision(dir > 0 ? DirectionEnum.RIGHT : DirectionEnum.LEFT);
    /// <summary>
    /// Returns the object the entity has collided with in the specified direction.
    /// </summary>
    /// <param name="dir">Direction to check.</param>
    /// <returns>The object the entitiy collided with or null if no collision.</returns>
    public Collider2D GetCollision(DirectionEnum dir)
        => IsCollision(dir) ? _baseCollisionInfo[(int)dir].collider : null;
    /// <summary>
    /// Returns the object the entity has collided with in the specified direction.
    /// </summary>
    /// <param name="dir">Direction to check.</param>
    /// <returns>The object the entitiy collided with or null if no collision.</returns>
    public Collider2D GetCollision(float dir)
        => GetCollision(dir > 0 ? DirectionEnum.RIGHT : DirectionEnum.LEFT);


    #endregion

    protected void InitializeEntity()
    {
        if (GetType() != typeof(PlayerController))
        {
            //if it is not the player.
            Map.Instance?.AddEntity(this);
        }
        _stateMachine = new();
        _rigidBody = GetComponent<Rigidbody2D>();
        BoundingBox = GetComponent<BoxCollider2D>();
        _baseCollisionInfo = new (bool collision, Collider2D collider)[4];

    }

    protected void UpdateEntity()
    {
        UpdateCollisions();

        //Check for ledges
        float xDistanceFromOrigin = BoundingBox.size.x / 2 + .2f;
        float distanceToCheck = 0.2f;   
        //alter the xoffset based on velocity? 

        Vector2 leftCheck = new Vector2(transform.position.x - xDistanceFromOrigin, transform.position.y);
        Vector2 rightCheck = new Vector2(transform.position.x + xDistanceFromOrigin, transform.position.y);

        NearLedgeLeft = Physics2D.Linecast(leftCheck, leftCheck - ( Vector2.up * distanceToCheck));
        NearLedgeRight = Physics2D.Linecast(rightCheck, rightCheck - ( Vector2.up * distanceToCheck));

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

    /// <summary>
    /// Gets if the entity can push a colliding entity.
    /// </summary>
    /// <param name="dir">Direction of collision to check.</param>
    /// <returns>False if colliding object is not and entity or is not pushable, True otherwise.</returns>
    public bool CanBePushed(DirectionEnum dir)
    {
        
        Collider2D collision = _baseCollisionInfo[(int)dir].collider;
        BaseEntityController target = collision.GetComponent<BaseEntityController>();
        return target != null ? target.isPushable : false;
    }

    
    /// <summary>
    /// Check if the entity is current effected by an area modifier.
    /// </summary>
    /// <param name="mod">The modifier to check for.</param>
    /// <returns>True if the entity is effected by the modifier, false otherwise.</returns>
    public bool HasAreaModifier(AreaModifierEnum mod)
    {
        foreach(MapArea area in _areaModifiers)
            if(area.HasModifier(mod))
                return true;
        return false;
    }
}
