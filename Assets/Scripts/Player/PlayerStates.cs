using System;
using UnityEngine;

public static class PlayerStates
{
    #region Misc

    private static bool CheckCommonGroundCancels(PlayerController player)
    {
        if (player.JumpPressed)
        {
            player.SetState((int)EntityStateEnum.JUMP_TAKEOFF);
            return true;
        }
        if (!player.OnGround)
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return true;
        }
        if (player.CrouchHeld)
        {
            player.SetState((int)EntityStateEnum.CROUCHING);
            return true;
        }
        return false;
    }

    #endregion

    #region GroundStates

    public static bool Idle(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        if (CheckCommonGroundCancels(player))
            return false;

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

        if (CheckCommonGroundCancels(player))
            return false;

        if (player.Velocity.x == 0 && player.MovementMagnitude == 0)
        {
            player.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        float targetspeed = player.MovementMagnitude * player.MaxSpeed;

        if (Mathf.Abs(targetspeed) < Mathf.Abs(player.Velocity.x))
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Deceleration);
        else
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Acceleration);

        if ((player.Velocity.x < 0 && player.IsCollision(DirectionEnum.LEFT) && !player.CanBePushed(DirectionEnum.LEFT))
            || player.Velocity.x > 0 && player.IsCollision(DirectionEnum.RIGHT) && !player.CanBePushed(DirectionEnum.RIGHT))
            player.Velocity.x = 0;

        if (player.MovementMagnitude != 0)
            player.FacingDirection = (player.MovementMagnitude);

        return true;
    }

    public static bool Crouching(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        if (!player.CrouchHeld)
        {
            player.SetState((int)EntityStateEnum.IDLE);
            return false;
        }
        if (!player.OnGround)
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return true;
        }

        if (player.Velocity.x != 0)
        {
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, 0, player.Deceleration / .8f);
            return true;
        }

        if ((player.Velocity.x < 0 && player.IsCollision(DirectionEnum.LEFT) && !player.CanBePushed(DirectionEnum.LEFT))
            || player.Velocity.x > 0 && player.IsCollision(DirectionEnum.RIGHT) && !player.CanBePushed(DirectionEnum.RIGHT))
            player.Velocity.x = 0;

        return true;
    }

    #endregion

    #region AirStates

    public static bool Falling(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        if (src.OnGround && src.Velocity.y <= 0)
        {
            src.Velocity.y = 0;
            src.SetState((int)EntityStateEnum.AIR_LAND);
            return false;
        }
        if (player.JumpPressed)
        {
            player.SetState((int)EntityStateEnum.JUMP_TAKEOFF);
            return false;
        }
        if (player.GlideHeld)
        {
            player.SetState((int)EntityStateEnum.GLIDING);
            return false;
        }

        src.Velocity.y -= player.JumpHeld ?
            src.GravityForce * .6f :
            src.GravityForce;

        if (src.MovementMagnitude != 0 || src.Velocity.x != 0)
        {
            Falling_Move(player);
        }
        if (player.Velocity.y > 0 && player.IsCollision(DirectionEnum.UP))
            player.Velocity.y = 0;

        return true;
    }

    private static bool Falling_Move(PlayerController player, float speedMultiplier = 1)
    {
        float targetspeed = (player.MovementMagnitude * player.MaxSpeed) * speedMultiplier;

        if (Mathf.Abs(targetspeed) < Mathf.Abs(player.Velocity.x))
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Deceleration * .7f); //Slower decel when in air.
        else
            player.Velocity.x = Mathf.MoveTowards(player.Velocity.x, targetspeed, player.Acceleration);

        if ((player.Velocity.x < 0 && player.IsCollision(DirectionEnum.LEFT))
        || player.Velocity.x > 0 && player.IsCollision(DirectionEnum.RIGHT))
        {
            player.Velocity.x = 0;
            //Check ledge first.
            if (CheckLedgeGrab(player))
                return false;
            player.SetState((int)EntityStateEnum.WALL_HANG);
            return false;
        }

        if (player.MovementMagnitude != 0)
            player.FacingDirection = (player.MovementMagnitude);
        return true;
    }

    public static bool Jump_Takeoff(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        player.JumpPressed = false;
        player.JumpHeld = true;

        if (player.CurrentJumpCount >= player.MaxJumpCount)
        {
            player.SetState((int)player.LastState);
            return false;
        }
        player.CurrentJumpCount++;

        src.Velocity.y = src.JumpForce;
        src.SetState((int)EntityStateEnum.FALLING);
        return true;
    }
    public static bool Air_Land(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        player.CurrentJumpCount = 0;

        //Play landing animation?
        player.SetState((int)EntityStateEnum.IDLE);

        return true;
    }

    public static bool Glide(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        if (src.OnGround)
        {
            src.Velocity.y = 0;
            src.SetState((int)EntityStateEnum.AIR_LAND);
            return false;
        }
        if (!player.GlideHeld)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        //Dont want the player to glide up, So if velocity is above 0 make it come down faster than normal.
        if (src.Velocity.y > 0)
            src.Velocity.y = src.Velocity.y * .6f;

        src.Velocity.y -= src.GravityForce * .2f;

        if (src.MovementMagnitude != 0 || src.Velocity.x != 0)
        {
            //increased speed when gliding to give more glide distance.
            //Too much speed gain would feel unatural
            Falling_Move(player, 1.4f);
        }
        if (player.Velocity.y > 0 && player.IsCollision(DirectionEnum.UP))
            player.Velocity.y = 0;


        return true;
    }

    #endregion

    #region LedgeAndWallGrabbing

    private static bool CheckLedgeGrab(PlayerController player)
    {
        float xOffset = (player.BoundingBox.size.x / 2 + 0.2f) * player.FacingDirection;

        Vector3 castStart = new(
            player.transform.position.x + xOffset,
            player.transform.position.y + player.BoundingBox.size.y + .1f
            );

        RaycastHit2D hit = Physics2D.Linecast(castStart, castStart + (Vector3.down * .2f));
        if (hit.distance > 0)
        {
            //Align the player
            player.transform.position = new Vector3(
                castStart.x - player.BoundingBox.size.x / 2,
                castStart.y - player.BoundingBox.size.y,
                0
                );
            player.Velocity = Vector3.zero;
            player.SetState((int)EntityStateEnum.LEDGE_HANG);

            return true;
        }


        return false;
    }
    private static bool CheckLedgeClimb(PlayerController player)
    {
        //We only want the ledge to be climbable if there is enough space above the ledge
        //for both the players height and width

        Vector3 castStart;
        Vector3 castEnd;

        if (player.FacingDirection > 0)
        {
            castStart = new Vector3(
                player.transform.position.x + player.BoundingBox.size.x / 2 + 0.1f,
                player.transform.position.y + player.BoundingBox.size.y + 0.1f, 0
                );
            castEnd = castStart +
                new Vector3(player.BoundingBox.size.x, player.BoundingBox.size.y);
        }
        else
        {
            castStart = new Vector3(
                player.transform.position.x - player.BoundingBox.size.x / 2 + 0.1f,
                player.transform.position.y + player.BoundingBox.size.y + 0.1f, 0
                );
            castEnd = castStart +
                new Vector3(-player.BoundingBox.size.x, player.BoundingBox.size.y);
        }

        Collider2D collision = Physics2D.OverlapArea(castStart, castEnd);

        return collision == null;
    }
    public static bool LedgeHang(BaseEntityController src)
    {
        PlayerController player = src.GetComponent<PlayerController>();
        if (player.CrouchHeld)
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        if (player.JumpPressed)
        {
            if (CheckLedgeClimb(player))
            {
                player.JumpPressed = false;
                player.SetState((int)EntityStateEnum.LEDGE_CLIMB);
                return false;
            }
        }

        return true;
    }
    public static bool LedgeClimb(BaseEntityController src)
    {
        //play climb animation.
        if (src.CurrentStateTime >= 1f)
        {
            Vector3 offset = new Vector3(src.BoundingBox.size.x, src.BoundingBox.size.y, 0);
            offset.x *= src.FacingDirection;
            src.transform.position = src.transform.position + offset;
            src.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        return true;
    }

    public static bool WallHang(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        player.Velocity = Vector3.zero;

        DirectionEnum dir = DirectionEnum.RIGHT;
        if (player.FacingDirection < 0) dir = DirectionEnum.LEFT;
        if (!player.IsCollision(dir))
        {
            player.SetState((int)player.LastState);
            return false;
        }

        if (player.CrouchHeld)
        {
            player.SetState((int)EntityStateEnum.WALL_SLIDE);
            return false;
        }
        if(player.JumpPressed)
        {
            player.SetState((int)EntityStateEnum.WALL_KICK_OFF);
            return false;
        }
        if(player.MovementMagnitude != 0)
        {
            player.SetState((int)EntityStateEnum.WALL_RUN);
            return false;
        }
        if(player.CurrentStateTime >= player.WallGrabTime)
        {
            player.SetState((int)EntityStateEnum.WALL_SLIDE);
            return false;
        }
        return true;
    }

    public static bool WallSlide(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;
        
        if (player.JumpPressed)
        {
            player.SetState((int)EntityStateEnum.WALL_KICK_OFF);
            return false;
        }

        float speed = player.CrouchHeld ? 5f : 2f;
        player.Velocity.y = -speed;

        if(player.OnGround)
        {
            player.SetState((int)EntityStateEnum.IDLE);
            player.CurrentJumpCount = 0;
            return false;
        }
        DirectionEnum dir = DirectionEnum.RIGHT;
        if(player.FacingDirection < 0) dir = DirectionEnum.LEFT;
        if (!player.IsCollision(dir))
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        return true;
    }

    public static bool WallRun(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        if (player.JumpPressed)
        {
            player.SetState((int)EntityStateEnum.WALL_KICK_OFF);
            return false;
        }
        DirectionEnum dir = DirectionEnum.RIGHT;
        if (player.FacingDirection < 0) dir = DirectionEnum.LEFT;
        if (!player.IsCollision(dir))
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return false;
        }
        if(player.MovementMagnitude == 0 || 
           player.CurrentStateTime >= player.WallRunTime
           )
        {
            player.SetState((int)EntityStateEnum.WALL_SLIDE);
            return false;
        }

        player.Velocity.y = 5f;

        return true;
    }

    public static bool WallKickOff(BaseEntityController src)
    {
        PlayerController player = src as PlayerController;

        player.Velocity.x = -(player.FacingDirection * 10f);
        player.Velocity.y = 15f;
        player.SetState((int)EntityStateEnum.FALLING);

        player.JumpHeld = player.JumpPressed = false;

        return true;
    }

    #endregion
}
