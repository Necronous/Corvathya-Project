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

    public Transform _rightLedgeCheck { get; private set; }
    public Transform _leftLedgeCheck { get; private set; }




    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, Player_GroundStates.Idle);
        RegisterState((int)EntityStateEnum.MOVING, Player_GroundStates.Moving);
        RegisterState((int)EntityStateEnum.JUMP_TAKEOFF, Player_AirStates.Jump_Takeoff);
        RegisterState((int)EntityStateEnum.FALLING, Player_AirStates.Falling);
        SetState((int)EntityStateEnum.IDLE);

        _rightLedgeCheck = transform.Find("Right_Ledge_Check");
        _leftLedgeCheck = transform.Find("Left_Ledge_Check");

        //Temp
        CameraController.Main.SetTarget(transform);
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

    /*private void OnGUI()
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
    }*/

}
