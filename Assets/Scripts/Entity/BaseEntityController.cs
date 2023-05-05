using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

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

    public float JumpForce = 15f;
    public float GravityForce = .9f;

    public float MovementMagnitude;
    public bool isAttacking;
    public bool isMovable = true;

    public bool OnGround => _collisionList[(int)DirectionEnum.DOWN];
    private bool[] _collisionList;
    private Collider2D[] _colliderList;

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

        _stateMachine.UpdateMachine(this);
        _rigidBody.velocity = Velocity;
    }

    public bool CanMoveCollider(DirectionEnum dir)
    {
        Collider2D collision = _colliderList[(int)dir];
        if (collision.GetComponent<BaseEntityController>() == null) return false;
        return collision.GetComponent<BaseEntityController>().isMovable;

    }

    public bool IsCollision(DirectionEnum dir)
        => _collisionList[(int)dir];
    public Collider2D GetCollision(DirectionEnum dir)
        => IsCollision(dir) ? _colliderList[(int)dir] : null;



}
