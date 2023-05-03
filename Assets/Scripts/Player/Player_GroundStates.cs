using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player_GroundStates
{
    //A state must have only one parameter of BaseEntityController
    //which is the entity that the machine belongs to.

    //Return type MUST be a bool.
    //Return false if you want the machine to process the next state or this state again immediatly
    //Return true if you want the machine to pass control back after the state is processed.
    //Returning false is recommended if the state changes
    //Be careful when returning false as it could cause an infinite loop in the statemachine. (Will throw an error after 100 loops)
    public static bool Idle(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        if (!src.OnGround)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }
        if (player.JumpHeld)
        {
            src.SetState((int)EntityStateEnum.JUMP_TAKEOFF);
            return false;
        }

        if (player.MovementMagnitude != 0 || player.Velocity.x != 0)
        {
            player.SetState((int)EntityStateEnum.MOVING);
            return false;
        }

        //play idle animation.
        return true;
    }

    public static bool Moving(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        if(!src.OnGround)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }
        if (player.JumpHeld)
        {
            src.SetState((int)EntityStateEnum.JUMP_TAKEOFF);
            return false;
        }

        if (player.Velocity.x == 0 && player.MovementMagnitude == 0)
        {
            player.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        float targetspeed = player.MovementMagnitude * player.MaxSpeed;

        if (Mathf.Abs(targetspeed) < Mathf.Abs(player.Velocity.x))
        {
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Deceleration);
            return true;
        }
        player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Acceleration);

        return true;
    }
}
