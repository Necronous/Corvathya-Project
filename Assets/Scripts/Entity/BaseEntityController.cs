


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
public abstract class BaseEntityController : MonoBehaviour
{
    protected Rigidbody2D RigidBody;

    public StateMachine<EntityStateEnum> StateMachine { get; protected set; }
    public Animator Animator { get; protected set; }
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
        if (GetType() != typeof(PlayerController))
            World.Instance.AddEntity(this);
        
        StateMachine = new();
        RigidBody = GetComponent<Rigidbody2D>();
        Animator = transform.Find("Sprite").GetComponent<Animator>();
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
        if (MovementMagnitude != 0)
            FacingDirection = MovementMagnitude;
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
}
