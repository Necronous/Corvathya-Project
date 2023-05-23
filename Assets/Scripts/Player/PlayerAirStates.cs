using System;
using UnityEngine;

public partial class PlayerController
{
    private bool CheckCommonAirCancels()
    {
        if (OnGround)
        { StateMachine.SetState(EntityStateEnum.JUMP_LANDING); return true; }


        return false;
    }
    private bool State_Falling()
    {
        if (CheckCommonAirCancels())
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
    }

    private bool State_Gliding()
    {
        return true;
    }
    private bool State_Jumping()
    {
        if (_inputHandler.GetKeyState(PlayerInputHandler.ACTION_JUMP) == PlayerInputHandler.KEY_UP)
            _jumpData.HighJump = false;

        Velocity.y -= _jumpData.HighJump ? GravityForce * .5f : GravityForce;

        if (OnCeiling)
        {
            //If we hit a ceiling skip jump apex.
            Velocity.y = 0;
            StateMachine.SetState(EntityStateEnum.FALLING);
            return false;
        }
        if(Velocity.y <= 0)
        {
            StateMachine.SetState(EntityStateEnum.JUMP_APEX);
            return false;
        }

        State_AirMove();

        return true;
    }
    private bool State_JumpApex()
    {
        Velocity.y = 0;
        if (StateMachine.CurrentStateTime >= 0.05f)
            StateMachine.SetState(EntityStateEnum.FALLING);

        State_AirMove();

        return true;
    }
}
