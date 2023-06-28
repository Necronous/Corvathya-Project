


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
[RequireComponent(typeof(EntityCollision))]
[RequireComponent(typeof(EntityAnimation))]
public abstract class BaseEntityController : MonoBehaviour
{
    protected Rigidbody2D RigidBody;

    public StateMachine<EntityState> StateMachine { get; protected set; }
    public EntityAnimation Animator { get; protected set; }
    public EntityCollision CollisionHandler { get; protected set; }

    [Header("Base_Physics")]
    public Vector2 Velocity;
    public float MaxSpeed = 10f;
    public float Acceleration = .5f;
    public float Deceleration = .5f;
    public float JumpForce = 15f;
    public float GravityForce = .9f;
    public float MaxFallSpeed = -20f;

    [Header("Base_Input")]
    public float MovementMagnitude;

    [Header("Base_Detection")]
    public float ViewDistance = 8f;

    [Header("Base_Health")]
    public int MaxHealth = 10;
    public int CurrentHealth = 10;
    public bool IsDead;
    public bool IsInvincible;

    //Events
    public Event<BaseEntityController, int> OnReceiveDamage = new();
    public Event<BaseEntityController> OnDeath = new();

    public bool OnCeiling => CollisionHandler.UpCollision;
    public bool OnGround => CollisionHandler.DownCollision;
    public bool OnLeftWall => CollisionHandler.LeftCollision;
    public bool OnRightWall => CollisionHandler.RightCollision;

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

    public virtual void Start()
    {
        MapManager.Instance.AddEntity(this);
        
        StateMachine = new();
        RigidBody = GetComponent<Rigidbody2D>();
        Animator = GetComponent<EntityAnimation>();
        CollisionHandler = GetComponent<EntityCollision>();
    }
    /* 
     * Because the statemachine does input and physics
     * it does not belong in either Update or FixedUpdate.
     * If its done in update the physics get screwed up
     * and if its done in fixedupdate the input get screwed.
     * 
     * As a temporary fix ive set the physics update rate and the target framerate to 60fps
     * to help sync them both up. This seems to work fine but its not ideal.
     * 
     * Todo: Find a better solution.
     */
    protected virtual void Update()
    {
        StateMachine.UpdateMachine();
    }
    protected virtual void FixedUpdate()
    {
        RigidBody.velocity = Velocity;
    }

    public void SetPosition(Vector2 position)
    {
        RigidBody.MovePosition(position);
    }

    #region Health
    public void Kill(BaseEntityController src = null)
    {
        if (IsInvincible || IsDead)
            return;
        CurrentHealth = 0;
        IsDead = true;
        OnDeath.Invoke(src);
    }

    public void Damage(BaseEntityController src, int damage)
    {
        if (IsInvincible || IsDead)
            return;
        CurrentHealth -= damage;
        OnReceiveDamage.Invoke(src, damage);

        if (CurrentHealth <= 0)
        { Kill(src); return; }
    }

    public void ResetHealth()
    {
        IsDead = IsInvincible = false;
        CurrentHealth = MaxHealth;
    }
    #endregion
}
