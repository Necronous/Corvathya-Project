

using System;
using UnityEngine;

public partial class PlayerController
{
    private bool State_CommonGroundCancels()
    {
        if(!OnGround)
        { StateMachine.SetState(EntityState.FALLING); return true; }
        
        if (InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED
            || InputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_DOWN)
        { StateMachine.SetState(EntityState.JUMP_TAKINGOFF); return true; }
        
        return false;
    }
    private bool State_Idling()
    {
        if (State_CommonGroundCancels())
            return false;

        if (MovementMagnitude != 0)
        { StateMachine.SetState(EntityState.RUNNING); return false; }
        if (Velocity.x != 0)
        { StateMachine.SetState(EntityState.SLIDING); return false; }
        if (InputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityState.CROUCHING); return false; }

        Animator.Play("Idle");
        return true;
    }
    private bool State_Running()
    {
        if (State_CommonGroundCancels())
            return false;

        if (MovementMagnitude == 0)
        { StateMachine.SetState(EntityState.IDLING); return false; }
        if (InputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityState.CROUCHING); return false; }

        float targetSpeed = MovementMagnitude * MaxSpeed;
        Velocity.x = Mathf.MoveTowards(Velocity.x, targetSpeed, Acceleration);

        if ((FacingDirection > 0 && OnRightWall) || (FacingDirection < 0 && OnLeftWall))
            Velocity.x = 0;

        Animator.Play("Running");

        if (MovementMagnitude > 0)
            FacingDirection = 1;
        if (MovementMagnitude < 0)
            FacingDirection = -1;

        return true;
    }
    private bool State_Sliding()
    {
        if (State_CommonGroundCancels())
            return false;

        if(MovementMagnitude !=  0)
        { StateMachine.SetState(EntityState.RUNNING); return false; }
        if (Velocity.x == 0)
        { StateMachine.SetState(EntityState.IDLING); return false; }
        if (InputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityState.CROUCHING); return false; }

        Velocity.x = Mathf.MoveTowards(Velocity.x, 0, Deceleration);

        //skidding animation
        return true;
    }
    private bool State_Turning()
    {
        //Play an animation then switch back to last state?
        return true;
    }
    private bool State_Crouching()
    {
        if (InputHandler.GetVerticalMovement() >= 0)
        { StateMachine.SetState(EntityState.IDLING); return false; }

        //Decelerate faster
        Velocity.x = Mathf.MoveTowards(Velocity.x, 0, Deceleration * 1.3f);

        Animator.Play("Crouch");
        return true;
    }
    private bool State_JumpTakingOff()
    {
        _jumpData.CurrentCount = 1;
        _jumpData.HighJump = true;

        //Flicker animation

        Velocity.y = JumpForce;
        StateMachine.SetState(EntityState.JUMPING);

        return true;
    }
    private bool State_JumpLanding()
    {
        _jumpData.CurrentCount = 0;
        _jumpData.HighJump = false;

        //Flicker animation

        StateMachine.SetState(EntityState.IDLING);

        return true;
    }
    private bool State_Dodge()
    {
        return true;
    }

}
