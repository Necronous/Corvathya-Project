using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class BaseEntityController : MonoBehaviour
{
    protected EntityStateMachine _stateMachine;
    protected Rigidbody2D _rigidBody;
    protected Transform _groundCheckCenter;

    public Vector2 Velocity;
    public float MaxSpeed = 10f;
    public float Acceleration = .5f;
    public float Deceleration = .5f;
    
    public float JumpForce = 15f;
    public float GravityForce = .9f;

    public bool OnGround;
    public float MovementMagnitude;

    public int CurrentState => _stateMachine.CurrentState;
    public int LastState => _stateMachine.LastState;
    public float CurrentStateTime => _stateMachine.CurrentStateTime;
    public float LastStateTime => _stateMachine.LastStateTime;
    
    protected void InitializeEntity()
    {
        _stateMachine = new();
        _rigidBody = GetComponent<Rigidbody2D>();
        _groundCheckCenter = transform.Find("GroundCheckCenter");
    }
    protected void UpdateEntity()
    {
        _stateMachine.UpdateMachine(this);
        _rigidBody.velocity = Velocity;
        OnGround = Physics2D.Linecast(_groundCheckCenter.position, _groundCheckCenter.position + new Vector3(0,-.2f,0));
    }

    public bool SetState(int state) => _stateMachine.SetState(state);

    public bool HasState(int state) => _stateMachine.HasState(state);

    public bool DeRegisterState(int state) => _stateMachine.DeRegisterState(state);

    public bool RegisterState(int state, Func<BaseEntityController, bool> fun) => _stateMachine.RegisterState(state, fun);

}
