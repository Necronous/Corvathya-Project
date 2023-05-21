

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : BaseEntityController
{
    [Header("Player_Physics")]
    //How long we can hold the wall before we start sliding down.
    public float WallGrabTime = .5f;
    public float WallRunTime = .5f;
    public (byte CurrentCount, byte MaxCount) JumpData = new(0, 2);

    [Header("Player_Input")]
    public bool JumpHeld;
    public bool JumpPressed;
    public bool CrouchHeld;
    public bool GlideHeld;

    public bool PauseInput;

    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, PlayerStates.Idle);
        RegisterState((int)EntityStateEnum.MOVING, PlayerStates.Moving);
        RegisterState((int)EntityStateEnum.CROUCHING, PlayerStates.Crouching);
        RegisterState((int)EntityStateEnum.JUMP_TAKEOFF, PlayerStates.Jump_Takeoff);
        RegisterState((int)EntityStateEnum.FALLING, PlayerStates.Falling);
        RegisterState((int)EntityStateEnum.AIR_LAND, PlayerStates.Air_Land);
        RegisterState((int)EntityStateEnum.GLIDING, PlayerStates.Glide);
        
        RegisterState((int)EntityStateEnum.LEDGE_HANG, PlayerStates.LedgeHang);
        RegisterState((int)EntityStateEnum.LEDGE_CLIMB, PlayerStates.LedgeClimb);

        RegisterState((int)EntityStateEnum.WALL_HANG, PlayerStates.WallHang);
        RegisterState((int)EntityStateEnum.WALL_SLIDE, PlayerStates.WallSlide);
        RegisterState((int)EntityStateEnum.WALL_RUN, PlayerStates.WallRun);
        RegisterState((int)EntityStateEnum.WALL_KICK_OFF, PlayerStates.WallKickOff);
        SetState((int)EntityStateEnum.IDLE);
    }
    void FixedUpdate()
    {
        UpdateEntity();
    }

    #region INPUT
    private void OnMove(InputValue val)
    {
        if(!PauseInput)
            MovementMagnitude = val.Get<float>();
    }
    private void OnJump(InputValue val)
    {
        if (PauseInput)
            return;

        if ((JumpHeld || JumpPressed) && !val.isPressed)
            JumpHeld = JumpPressed = false;
        else
            JumpPressed = true;
    }
    private void OnCrouch(InputValue val)
    {
        if (PauseInput)
            return;

        if (CrouchHeld && !val.isPressed)
            CrouchHeld = false;
        else
            CrouchHeld = true;
    }
    private void OnGlide(InputValue val)
    {
        if (PauseInput)
            return;

        if (!val.isPressed)
            GlideHeld = false;
        else
            GlideHeld = true;
    }

    private void OnActivate(InputValue val)
    {
        if (PauseInput)
            return;

        if(!val.isPressed)
        {
            
        }
    }
    #endregion


}
