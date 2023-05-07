using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Main { get; private set; }

    private StateMachine _stateMachine = new();

    private Transform _target;

    private Action _fadeEndCallback;

    #region StateMachinePassThrough
    public int CurrentState => _stateMachine.CurrentState;
    public int LastState => _stateMachine.LastState;
    public float CurrentStateTime => _stateMachine.CurrentStateTime;
    public float LastStateTime => _stateMachine.LastStateTime;
    public bool SetState(int state) => _stateMachine.SetState(state);

    public bool HasState(int state) => _stateMachine.HasState(state);

    public bool DeRegisterState(int state) => _stateMachine.DeRegisterState(state);

    public bool RegisterState(int state, Func<bool> fun) => _stateMachine.RegisterState(state, fun);

    #endregion


    private void Awake()
    {
        //Only allow one camera for now.
        if (Main != null)
            Destroy(gameObject);
        Main = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        RegisterState((int)CameraModeEnum.FOLLOW_OBJECT, Follow_Object);
        //RegisterState((int)CameraModeEnum.FADE_IN, Fade_In);
        //RegisterState((int)CameraModeEnum.FADE_OUT, Fade_Out);
        
        SetState((int)CameraModeEnum.FOLLOW_OBJECT);
    }

    private void Update()
    {
        _stateMachine.UpdateMachine();
    }

    public void SetTarget(Transform transform)
    {
        _target = transform; 
    }

    /// <summary>
    /// Starts a fade in
    /// </summary>
    /// <param name="fadetime">How long the fade will take.</param>
    /// <param name="callback">Function to call once fade has ended.</param>
    public void StartFadeIn(float fadetime = 1, Action callback = null)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Starts a fade out
    /// </summary>
    /// <param name="fadetime">How long the fade will take.</param>
    /// <param name="callback">Function to call once fade has ended.</param>
    public void StartFadeOut(float fadetime = 1, Action callback = null)
    {
        throw new NotImplementedException();
    }

    #region FollowObject

    private bool Follow_Object()
    {
        transform.position = _target.position;
        return true;
    }

    #endregion
    #region Fading

    private bool Fade_Out()
    {
        return true;
    }
    private bool Fade_In()
    {
        return true;
    }

    #endregion
}
