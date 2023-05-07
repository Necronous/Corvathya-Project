
#define DEBUG_PLAYER_CONTROLLER

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;


/*
 * TODO,
 * Add ledgecheck cooldown to prevent ledge grabbing right after letting go.
 * Add a struct to control input states better.
 * Add enemy check to CheckLedgeClimb, Enemies should not stop player from climbing
 * Change control for ledge climbing to UP from LEFT/RIGHT
 */



public class PlayerController : BaseEntityController
{

    public byte CurrentJumpCount;
    public byte MaxJumpCount = 2;
    public bool JumpHeld;
    public bool JumpPressed;
    public bool CrouchHeld;
    public bool GlideHeld;


    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, Player_GroundStates.Idle);
        RegisterState((int)EntityStateEnum.MOVING, Player_GroundStates.Moving);
        RegisterState((int)EntityStateEnum.CROUCHING, Player_GroundStates.Crouching);
        RegisterState((int)EntityStateEnum.JUMP_TAKEOFF, Player_AirStates.Jump_Takeoff);
        RegisterState((int)EntityStateEnum.FALLING, Player_AirStates.Falling);
        RegisterState((int)EntityStateEnum.AIR_LAND, Player_AirStates.Air_Land);
        RegisterState((int)EntityStateEnum.GLIDING, Player_AirStates.Glide);
        RegisterState((int)EntityStateEnum.LEDGE_HANG, Player_AirStates.LedgeHang);
        RegisterState((int)EntityStateEnum.LEDGE_CLIMB, Player_AirStates.LedgeClimb);
        SetState((int)EntityStateEnum.IDLE);

        //Temp
        CameraController.Main.SetTarget(transform);
    }

    private void OnMove(InputValue val)
    {
        MovementMagnitude = val.Get<float>();
    }
    private void OnJump(InputValue val)
    {
        if ((JumpHeld || JumpPressed) && !val.isPressed)
            JumpHeld = false;
        else
            JumpPressed = JumpHeld = true;
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

    void FixedUpdate()
    {
        UpdateEntity();
    }

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
