using System;
using TMPro;
using UnityEditor.Build;
using UnityEngine;

public partial class PlayerController
{
    private bool State_CheckWallState()
    {
        (bool collision, Collider2D collider)[] coldata = null;

        if (FacingDirection > 0 && OnRightWall && MovementMagnitude > 0)
            coldata = CollisionHandler.GetRightCollisions();
        else if (FacingDirection < 0 && OnLeftWall && MovementMagnitude < 0)
            coldata = CollisionHandler.GetLeftCollisions();
        else
            return false;

        /*
        //If on wall.
        if ( coldata[0].collision && coldata[1].collision
            && coldata[2].collision && coldata[3].collision 
            && coldata[4].collision && coldata[5].collision 
            && coldata[6].collision && coldata[7].collision )
        {
            Velocity = Vector2.zero;
            StateMachine.SetState(EntityStateEnum.WALL_HANGING);
            return true;
        }
        */

        //OnLedge
        if ( coldata[6].collision && !coldata[7].collision
            && StateMachine.LastState != EntityState.LEDGE_GRABBING
            && Velocity.y <= 0)
        {
            Vector3 castStart = new(
                transform.position.x + ((CollisionHandler.HalfWidth + 0.2f) * FacingDirection),
                transform.position.y + CollisionHandler.Height + .1f
                );

            RaycastHit2D hit = CollisionHandler.Linecast(castStart, castStart + (Vector3.down * CollisionHandler.HalfHeight));

            transform.position = new Vector3(
                transform.position.x,
                hit.point.y - CollisionHandler.Height,
                0
                );
            Velocity = Vector2.zero;
            StateMachine.SetState(EntityState.LEDGE_GRABBING);
            return true;
        }

        return false;
    }
    private bool State_CheckLedgeClimb()
    {
        //Only climb if the player can fit on the platform
        bool canclimb = !CollisionHandler.Cast(
            transform.position.Swizzle_xy() + new Vector2((CollisionHandler.Width + .05f) * FacingDirection,
            CollisionHandler.Height + .05f));

        if (canclimb)
        {
            StateMachine.SetState(EntityState.LEDGE_CLIMBING);
            return true;
        }
        return false;
    }

    private bool State_LedgeGrab()
    {
        if(InputHandler.GetVerticalMovement() < 0)
        { StateMachine.SetState(EntityState.FALLING); return false; }

        if (InputHandler.KeyDown(PlayerInputHandler.ACTION_JUMP)
            && State_CheckLedgeClimb())
            return false;

        Animator.Play("EdgeGrab");

        return true;
    }

    private bool State_LedgeClimb()
    {
        if(StateMachine.CurrentStateTime >= LedgeClimbTime)
        {
            transform.position =
                transform.position.Swizzle_xy() + new Vector2((CollisionHandler.Width + .05f) * FacingDirection,
                CollisionHandler.Height + .05f);

            StateMachine.SetState(EntityState.IDLING); 
            return false;
        }

        return true;
    }

    private bool State_WallHang()
    {
        return true;
    }

    private bool State_WallSlide()
    {
        return true;
    }

    private bool State_WallRun()
    {
        return true;
    }

    private bool State_WallJump()
    {
        return true;
    }
}

