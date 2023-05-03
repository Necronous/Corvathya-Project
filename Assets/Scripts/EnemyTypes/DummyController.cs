using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

/// <summary>
/// Quick enemy test.
/// </summary>
public class DummyController : BaseEntityController
{

    public bool MoveRight = false;
    void Start()
    {
        base.InitializeEntity();
        RegisterState((int)EntityStateEnum.IDLE, Common_States.Idle);
        RegisterState((int)EntityStateEnum.MOVING, Common_States.Move);
        RegisterState((int)EntityStateEnum.FALLING, Common_States.Falling);
        SetState((int)EntityStateEnum.IDLE);
    }

    void FixedUpdate()
    {
        //Wait 5 seconds walk in direction, wait 5 seconds walk back.
        if(CurrentState == (int)EntityStateEnum.IDLE && CurrentStateTime > 5)
        {
            if (MoveRight)
                MovementMagnitude = 1;
            else
                MovementMagnitude = -1;
            MoveRight = !MoveRight;
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

    /*
    private void OnGUI()
    {
        //For debugging
        GUILayout.BeginArea(new Rect(200,0, 200, 200));
        GUILayout.Label("Dummy state:");
        GUILayout.Label("CurrentState: " + (EntityStateEnum)CurrentState);
        GUILayout.Label($"CurrentStateTime: {CurrentStateTime}ms");
        GUILayout.Label("LastState: " + (EntityStateEnum)LastState);
        GUILayout.Label($"LastStateTime: {LastStateTime}ms");
        GUILayout.EndArea();
    }
    */
}
