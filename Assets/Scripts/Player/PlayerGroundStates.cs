

using System;
using TMPro;
using UnityEngine;

public partial class PlayerController
{
    private bool CheckCommonGroundCancels()
    {
        if(!OnGround)
        { StateMachine.SetState(EntityStateEnum.FALLING); return true; }
        
        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED
            || _inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_DOWN)
        { StateMachine.SetState(EntityStateEnum.JUMP_TAKINGOFF); return true; }
        
        return false;
    }
    private bool State_Idling()
    {
        if (CheckCommonGroundCancels())
            return false;

        if (MovementMagnitude != 0)
        { StateMachine.SetState(EntityStateEnum.RUNNING); return false; }
        if (Velocity.x != 0)
        { StateMachine.SetState(EntityStateEnum.SLIDING); return false; }
        if (_inputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityStateEnum.CROUCHING); return false; }

        Animator.Play("Idle");
        return true;
    }
    private bool State_Running()
    {
        if (CheckCommonGroundCancels())
            return false;

        if (MovementMagnitude == 0)
        { StateMachine.SetState(EntityStateEnum.IDLING); return false; }
        if (_inputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityStateEnum.CROUCHING); return false; }

        float targetSpeed = MovementMagnitude * MaxSpeed;
        Velocity.x = Mathf.MoveTowards(Velocity.x, targetSpeed, Acceleration);

        if ((FacingDirection > 0 && OnRightWall) || (FacingDirection < 0 && OnLeftWall))
            Velocity.x = 0;

        Animator.Play("Running");

        return true;
    }
    private bool State_Sliding()
    {
        if (CheckCommonGroundCancels())
            return false;

        if(MovementMagnitude !=  0)
        { StateMachine.SetState(EntityStateEnum.RUNNING); return false; }
        if (Velocity.x == 0)
        { StateMachine.SetState(EntityStateEnum.IDLING); return false; }
        if (_inputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityStateEnum.CROUCHING); return false; }

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
        if (_inputHandler.GetVerticalMovement() >= 0)
        { StateMachine.SetState(EntityStateEnum.IDLING); return false; }

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
        StateMachine.SetState(EntityStateEnum.JUMPING);

        return true;
    }
    private bool State_JumpLanding()
    {
        _jumpData.CurrentCount = 0;
        _jumpData.HighJump = false;

        //Flicker animation

        StateMachine.SetState(EntityStateEnum.IDLING);

        return true;
    }
    private bool State_Dodge()
    {
        return true;
    }

}
