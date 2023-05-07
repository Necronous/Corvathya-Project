using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public static class Player_AirStates
{

    private static bool CheckLedgeGrab(PlayerController player)
    {
        float xOffset = (player.BoundingBox.size.x / 2 + 0.2f) * player.FacingDirection;

        Vector3 castStart = new(
            player.transform.position.x + xOffset,
            player.transform.position.y + player.BoundingBox.size.y + .1f
            );

        RaycastHit2D hit = Physics2D.Linecast(castStart, castStart + (Vector3.down * .2f));
        if(hit.distance > 0)
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
        if(player.CrouchHeld)
        {
            player.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        if(player.JumpPressed)
        {
            if(CheckLedgeClimb(player))
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
        if(src.CurrentStateTime >= 1f)
        {
            Vector3 offset = new Vector3(src.BoundingBox.size.x, src.BoundingBox.size.y, 0);
            offset.x *= src.FacingDirection;
            src.transform.position = src.transform.position + offset;
            src.SetState((int)EntityStateEnum.IDLE);
            return false;
        }

        return true;
    }

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
        if(player.GlideHeld)
        {
            player.SetState((int)EntityStateEnum.GLIDING);
            return false;
        }

        src.Velocity.y -= player.JumpHeld ?
            src.GravityForce * .6f :
            src.GravityForce;

        if(src.MovementMagnitude != 0 || src.Velocity.x != 0)
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
            if (CheckLedgeGrab(player))
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

        if(player.CurrentJumpCount >= player.MaxJumpCount)
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
        if(!player.GlideHeld)
        {
            src.SetState((int)EntityStateEnum.FALLING);
            return false;
        }

        //Dont want the player to glide up, So if velocity is above 0 cause is to come faster than normal.
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
}
