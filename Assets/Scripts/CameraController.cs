using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Main { get; private set; }

    private StateMachine _stateMachine = new();
    private Camera _camera;

    private Transform _target;

    private Action _fadeEndCallback;
    private Color _fadeColor;
    private float _fadeEndTime;
    private bool _isFading;

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
        _camera = GetComponent<Camera>();

        RegisterState((int)CameraModeEnum.FOLLOW_OBJECT, Follow_Object);
        //RegisterState((int)CameraModeEnum.FADE_IN, Fade_In);
        //RegisterState((int)CameraModeEnum.FADE_OUT, Fade_Out);

        StartFollowingTarget();
    }

    private void FixedUpdate()
    {
        _stateMachine.UpdateMachine();
    }


    #region FollowObject
    public void SetTarget(Transform transform)
    {
        _target = transform; 
    }

    public void StartFollowingTarget()
    {
        SetState((int)CameraModeEnum.FOLLOW_OBJECT);
    }

    private bool Follow_Object()
    {
        if (_target == null)
            return true;
        transform.position = _target.position;
        return true;
    }

    #endregion
    #region Fading

    /// <summary>
    /// Starts a fade in
    /// </summary>
    /// <param name="fadetime">How long the fade will take.</param>
    /// <param name="callback">Function to call once fade has ended.</param>
    public void StartFadeIn(float fadetime, Color fadecolor, Action callback = null)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Starts a fade out
    /// </summary>
    /// <param name="fadetime">How long the fade will take.</param>
    /// <param name="callback">Function to call once fade has ended.</param>
    public void StartFadeOut(float fadetime, Color fadecolor, Action callback = null)
    {
        throw new NotImplementedException();
    }

    private bool Fade_Out()
    {
        throw new NotImplementedException();
    }
    private bool Fade_In()
    {
        throw new NotImplementedException();
    }

    #endregion
}
