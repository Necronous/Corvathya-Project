
//#define DEBUG_PLAYER_CONTROLLER

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;


/*
 * Necronous' TODO,
 * Add ledgecheck cooldown to prevent ledge grabbing right after letting go.
 * Do another pass on state switch checks.
 */



public class PlayerController : BaseEntityController
{

    public byte CurrentJumpCount;
    public byte MaxJumpCount = 2;
    public bool JumpHeld;
    public bool JumpPressed;
    public bool CrouchHeld;
    public bool GlideHeld;

    //How long we can hold the wall before we start sliding down.
    public float WallGrabTime = .5f;
    public float WallRunTime = .5f;

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

        //Temp
        CameraController.Main.SetTarget(transform);
    }
    void FixedUpdate()
    {
        UpdateEntity();
    }

    #region INPUT
    private void OnMove(InputValue val)
    {
        MovementMagnitude = val.Get<float>();
    }
    private void OnJump(InputValue val)
    {
        if ((JumpHeld || JumpPressed) && !val.isPressed)
            JumpHeld = JumpPressed = false;
        else
            JumpPressed = true;
    }
    private void OnCrouch(InputValue val)
    {
        if (CrouchHeld && !val.isPressed)
            CrouchHeld = false;
        else
            CrouchHeld = true;
    }
    private void OnGlide(InputValue val)
    {
        if (!val.isPressed)
            GlideHeld = false;
        else
            GlideHeld = true;
    }
    #endregion


#if DEBUG_PLAYER_CONTROLLER
    private void OnGUI()
    {
        //For debugging
        GUILayout.Label("Player state:");
        GUILayout.Label("CurrentState: " + (EntityStateEnum)CurrentState);
        GUILayout.Label($"CurrentStateTime: {CurrentStateTime}s");
        GUILayout.Label("LastState: " + (EntityStateEnum)LastState);
        GUILayout.Label($"LastStateTime: {LastStateTime}s");
        GUILayout.Label($"--");
        GUILayout.Label($"CollisionUp: {IsCollision(DirectionEnum.UP)}");
        GUILayout.Label($"CollisionRight: {IsCollision(DirectionEnum.RIGHT)}");
        GUILayout.Label($"CollisionDown: {IsCollision(DirectionEnum.DOWN)}");
        GUILayout.Label($"CollisionLeft: {IsCollision(DirectionEnum.LEFT)}");
    }

#endif
}
