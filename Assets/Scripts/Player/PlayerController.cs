using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerController : BaseEntityController
{

    public bool JumpHeld;

    /* Reminder to fix Moving in air immediatly lowers velocity if run jumping. 
     */


    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, Player_GroundStates.Idle);
        RegisterState((int)EntityStateEnum.MOVING, Player_GroundStates.Moving);
        RegisterState((int)EntityStateEnum.JUMP_TAKEOFF, Player_AirStates.Jump_Takeoff);
        RegisterState((int)EntityStateEnum.FALLING, Player_AirStates.Falling);
        SetState((int)EntityStateEnum.IDLE);
    }

    private void OnMove(InputValue val)
    {
        MovementMagnitude = val.Get<float>();
    }
    private void OnJump(InputValue val)
    {
        if (JumpHeld && !val.isPressed)
            JumpHeld = false;
        else
            JumpHeld = true;
    }

    void FixedUpdate()
    {
        UpdateEntity();
    }

    /*
    private void OnGUI()
    {
        //For debugging
        GUILayout.Label("Player state:");
        GUILayout.Label("CurrentState: " + (PlayerStateEnum)CurrentState);
        GUILayout.Label($"CurrentStateTime: {CurrentStateTime}ms");
        GUILayout.Label("LastState: " + (PlayerStateEnum)LastState);
        GUILayout.Label($"LastStateTime: {LastStateTime}ms");
    }
    */
}
