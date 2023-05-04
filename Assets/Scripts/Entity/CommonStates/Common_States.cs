using System;
using UnityEngine;

/// <summary>
/// Common states that can be reused
/// </summary>
public static class Common_States
{
    public static bool Idle(BaseEntityController src)
    {
        if (!src.OnGround)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        if (src.MovementMagnitude != 0 || src.Velocity.x != 0)
        {
            src.SetState((int)EntityStateEnum.MOVING);
            return false;
        }

        //play idle animation.
        return true;
    }

    public static bool Move(BaseEntityController src)
    {
        if (!src.OnGround)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }
        if (src.Velocity.x == 0 && src.MovementMagnitude == 0)
        {
            src.SetState((int)EntityStateEnum.IDLE);
            return false;
        }
        float targetspeed = src.MovementMagnitude * src.MaxSpeed;

        if (Mathf.Abs(targetspeed) < Mathf.Abs(src.Velocity.x))
        {
            src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Deceleration);
            return true;
        }
        src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Acceleration);

        if ((src.Velocity.x < 0 && src.IsCollision(DirectionEnum.LEFT))
            || src.Velocity.x > 0 && src.IsCollision(DirectionEnum.RIGHT))
            src.Velocity.x = 0;

        return true;
    }

    public static bool Falling(BaseEntityController src)
    {
        if (src.OnGround)
        {
            src.Velocity.y = 0;
            src.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        src.Velocity.y -= src.GravityForce;

        if (src.MovementMagnitude != 0)
        {
            float targetspeed = (src.MovementMagnitude * src.MaxSpeed) * .6f; //Slow down horizontal movement when in air?

            if (Mathf.Abs(targetspeed) < Mathf.Abs(src.Velocity.x))
            {
                src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Deceleration);
                return true;
            }
            src.Velocity.x = Mathf.MoveTowards(src.Velocity.x, targetspeed, src.Acceleration);

        }


        return true;
    }
}
