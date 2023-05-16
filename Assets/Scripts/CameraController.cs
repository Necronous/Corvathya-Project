using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance { get; private set; }

    private StateMachine _stateMachine = new();

    private Texture2D _fadeTexture;
    private Action _fadeEndCallback;
    private Color _fadeColor;
    private float _fadeTime;
    private bool _fadeIn;
    private AnimationCurve _fadeCurve = new(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(.5f, 0));


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
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;
    }

    void Start()
    {
        _fadeTexture = new Texture2D(1, 1);
        RegisterState((int)CameraModeEnum.STATIC, Static);
        RegisterState((int)CameraModeEnum.FOLLOW_PLAYER, Follow_Player);
        RegisterState((int)CameraModeEnum.FADING, Do_Fade);
        SetState((int)CameraModeEnum.FOLLOW_PLAYER);
    }

    private void FixedUpdate()
    {
        _stateMachine.UpdateMachine();
    }

    private void OnGUI()
    {
        if (CurrentState == (int)CameraModeEnum.FADING)
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _fadeTexture);

    }

    /// <summary>
    /// Static state does nothing, Just sits there. Watching.
    /// </summary>
    private bool Static()
    {
        return true;
    }

    #region FollowPlayer

    private bool Follow_Player()
    {
        transform.position = World.Player.transform.position;
        return true;
    }

    #endregion
    #region Fading

    /// <summary>
    /// Begin a camera fade.
    /// </summary>
    /// <param name="color">Fade color.</param>
    /// <param name="time">How long to fade.</param>
    /// <param name="callback">Method to call after fade ends.</param>
    /// <param name="fadein">Fades in if true otherwise fades out.</param>
    public void StartFade(Color color, float time, Action callback, bool fadein)
    {
        _fadeColor = color;
        _fadeTime = time;
        _fadeEndCallback = callback;
        _fadeIn = fadein;

        SetState((int)CameraModeEnum.FADING);
    }

    private bool Do_Fade()
    {
        if(CurrentStateTime >= _fadeTime)
        {
            if (_fadeTime == -1)
                return true;
            _fadeTime = -1;
            _fadeEndCallback?.Invoke();
            return true;
        }
        _fadeColor.a = _fadeCurve.Evaluate(CurrentStateTime);
        if (!_fadeIn)
            _fadeColor.a = 1f - _fadeColor.a;

        _fadeTexture.SetPixel(0, 0, _fadeColor);
        _fadeTexture.Apply();

        Follow_Player();
        return true;
    }

    #endregion
}
