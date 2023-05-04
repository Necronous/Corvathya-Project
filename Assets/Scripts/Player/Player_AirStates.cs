using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public static class Player_AirStates
{

    public static bool Falling(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        if (src.OnGround)
        {
            src.Velocity.y = 0;
            src.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        src.Velocity.y -= player.JumpHeld ?
            src.GravityForce * .6f :
            src.GravityForce;

        if(src.MovementMagnitude != 0)
        {

            //Might move this into a seperate Air_moving state.
            float targetspeed = (src.MovementMagnitude * src.MaxSpeed) * .6f; //Slow down horizontal movement when in air?

            //Bug here immediatly lowers velocity if run jumping
            //Since ground moving is faster tha air moving.
            if (Mathf.Abs(targetspeed) < Mathf.Abs(src.Velocity.x))
            {
                src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Deceleration);
                return true;
            }
            src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Acceleration);

            if ((player.Velocity.x < 0 && player.IsCollision(DirectionEnum.LEFT))
            || player.Velocity.x > 0 && player.IsCollision(DirectionEnum.RIGHT))
                player.Velocity.x = 0;
        }
        if (player.Velocity.y > 0 && player.IsCollision(DirectionEnum.UP))
            player.Velocity.y = 0;

        return true;
    }
    public static bool Jump_Takeoff(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        //Seems pointless atm but could a timer here to wait for a JumpLaunch animation to end before jumping.

        src.Velocity.y = src.JumpForce;
        src.SetState((int)EntityStateEnum.FALLING);
        return true;
    }
}
