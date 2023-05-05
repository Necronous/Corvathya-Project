using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

/// <summary>
/// Quick enemy test.
/// </summary>
public class DecayingSignlessMeleeController : BaseEntityController
{

    public bool FacingRight = false;
    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, Common_States.Idle);
        RegisterState((int)EntityStateEnum.MOVING, Common_States.Move);
        RegisterState((int)EntityStateEnum.FALLING, Common_States.Falling);
        RegisterState((int)EntityStateEnum.MELEE_ATTACK, BasicAttack);
        RegisterState((int)EntityStateEnum.ATTACK_COOLDOWN, AttackCooldown);
        RegisterState((int)EntityStateEnum.CHARGE_ATTACK, ChargeAttack);
        SetState((int)EntityStateEnum.IDLE);
    }

    void FixedUpdate()
    {
        //Enter Attack Cycle if it notices the player
        if (CanSeePlayer() && (CurrentState == (int)EntityStateEnum.IDLE || CurrentState == (int)EntityStateEnum.MOVING))
        {
            SetState((int)EntityStateEnum.MELEE_ATTACK);
        }
        if (CurrentState == (int)EntityStateEnum.ATTACK_COOLDOWN && CurrentStateTime > 1.5)
        {
            if (CanSeePlayer())
            {
                SetState((int)EntityStateEnum.CHARGE_ATTACK);
            }
            else
            {
                SetState((int)EntityStateEnum.IDLE);
            }
        }
        //Wait 5 seconds walk in direction, wait 5 seconds walk back.
        if (CurrentState == (int)EntityStateEnum.IDLE && CurrentStateTime > 5)
        {
            Flip();
            FacingRight = !FacingRight;
            if (FacingRight) MovementMagnitude = 1;
            else MovementMagnitude = -1;
        }
        if (CurrentState == (int)EntityStateEnum.MOVING && CurrentStateTime > 2)
        {
            MovementMagnitude = 0;
        }
        if (CurrentState == (int)EntityStateEnum.FALLING)
        {
            //uh oh
        }
        UpdateEntity();
    }

    bool BasicAttack(BaseEntityController src)
    {
        src.isAttacking = true;
        if (CurrentStateTime < 0.5f)
        {
            float motion = -1.5f;
            if (FacingRight) motion *= -1;
            MovementMagnitude = motion;
        }
        else if (CurrentStateTime < 0.7f)
        {
            float motion = 0.1f;
            if (FacingRight) motion *= -1;
            MovementMagnitude = motion;
        }
        else if (CurrentStateTime > 0.7f)
        {
            MovementMagnitude = 0;
            SetState((int)EntityStateEnum.ATTACK_COOLDOWN);
            return false;
        }
        Common_States.Move(src);
        return true;
    }

    bool ChargeAttack(BaseEntityController src)
    {
        src.isAttacking = true;
        if (CurrentStateTime < 1.5)
        {
            float motion = -3f;
            if (FacingRight) motion *= -1;
            MovementMagnitude = motion;
        }
        else if (CurrentStateTime > 1.5)
        {
            MovementMagnitude = 0;
            SetState((int)EntityStateEnum.ATTACK_COOLDOWN);
            return false;
        }
        Common_States.Move(src);
        return true;
    }

    bool AttackCooldown(BaseEntityController src)
    {
        return true;
    }

    bool CanSeePlayer()
    {
        Vector3 lookDirection = new Vector3(-1, 0, 0);
        if (FacingRight) lookDirection *= -1;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, lookDirection, 7);
        return hit.collider != null && hit.collider.name == "Player";
    }


    private void OnGUI()
    {
        //For debugging
        GUILayout.BeginArea(new Rect(200, 0, 200, 200));
        GUILayout.Label("Enemy state:");
        GUILayout.Label("CurrentState: " + (EntityStateEnum)CurrentState);
        GUILayout.Label($"CurrentStateTime: {CurrentStateTime}ms");
        GUILayout.Label("LastState: " + (EntityStateEnum)LastState);
        GUILayout.Label($"LastStateTime: {LastStateTime}ms");
        GUILayout.EndArea();
    }

    private void Flip()
    {
        Vector3 scale = gameObject.transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
    }
}
