using System;
using UnityEngine;

public partial class PlayerController
{
    private bool State_CommonAirCancels()
    {
        if (OnGround)
        { StateMachine.SetState(EntityState.JUMP_LANDING); return true; }


        return false;
    }

    private bool CanAirJump()
    {
        if (_jumpData.CurrentCount >= _jumpData.MaxCount)
            return false;

        _jumpData.CurrentCount++;
        Velocity.y = JumpForce;
        _jumpData.HighJump = true;
        StateMachine.SetState(EntityState.JUMPING);
        return true;
    }

    private bool State_Falling()
    {
        if (State_CommonAirCancels() || State_CheckWallState())
            return false;

        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
            if (CanAirJump())
                return false;

        Velocity.y -= GravityForce;
        if(Velocity.y < MaxFallSpeed)
            Velocity.y = MaxFallSpeed;

        State_AirMove();

        return true;
    }

    private void State_AirMove()
    {
        float targetspeed = MovementMagnitude * MaxSpeed;

        if(targetspeed < Velocity.x)
            Velocity.x = Mathf.MoveTowards(Velocity.x, targetspeed, Deceleration);
        else
            Velocity.x = Mathf.MoveTowards(Velocity.x, targetspeed, Acceleration);
        
        if ((FacingDirection > 0 && OnRightWall) || (FacingDirection < 0 && OnLeftWall))
            Velocity.x = 0;

        if (MovementMagnitude > 0)
            FacingDirection = 1;
        if (MovementMagnitude < 0)
            FacingDirection = -1;
    }

    private bool State_Gliding()
    {
        return true;
    }
    private bool State_Jumping()
    {
        if (State_CheckWallState())
            return false;

        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_UP)
            _jumpData.HighJump = false;

        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
            if (CanAirJump())
                return false;

        Velocity.y -= _jumpData.HighJump ? GravityForce * .5f : GravityForce;

        if (OnCeiling)
        {
            //If we hit a ceiling skip jump apex.
            Velocity.y = 0;
            StateMachine.SetState(EntityState.FALLING);
            return false;
        }
        if(Velocity.y <= 0)
        {
            StateMachine.SetState(EntityState.JUMP_APEX);
            return false;
        }

        State_AirMove();

        return true;
    }
    private bool State_JumpApex()
    {
        if (State_CheckWallState())
            return false;

        Velocity.y = 0;
        if (StateMachine.CurrentStateTime >= ApexAirTime)
            StateMachine.SetState(EntityState.FALLING);

        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_PRESSED)
            if (CanAirJump())
                return false;

        State_AirMove();

        return true;
    }
}
