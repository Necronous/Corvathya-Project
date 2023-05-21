using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance { get; private set; }

    #region FadeProperties
    private Texture2D _fadeTexture;
    private Action _fadeEndCallback;
    private Color _fadeColor;
    private float _fadeTime;
    private bool _fadeIn;
    private AnimationCurve _fadeCurve = new(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(.5f, 0));
    #endregion

    public CameraModeEnum CameraMode;// { get; private set; }
    public bool IsFading;

    private void Awake()
    {
        //Only allow one camera for now.
        if (Instance != null)
            return;
        Instance = this;
    }

    void Start()
    {
        _fadeTexture = new Texture2D(1, 1);
        SetMode(CameraModeEnum.STATIC);
    }

    public void SetStaticCamera() => SetMode(CameraModeEnum.STATIC);
    public void SetPlayerFollowCamera() => SetMode(CameraModeEnum.FOLLOW_PLAYER);
    public void SetCinematicCamera() => SetMode(CameraModeEnum.CINEMATIC);
    public void SetMode(CameraModeEnum mode)
    {
        if (CameraMode == mode)
            return;
        CameraMode = mode;
    }

    private void FixedUpdate()
    {
        switch (CameraMode)
        {
            case CameraModeEnum.STATIC: UpdateStaticCamera(); break;
            case CameraModeEnum.FOLLOW_PLAYER: UpdateFollowCamera(); break;
            case CameraModeEnum.CINEMATIC: break;
        }
        if (IsFading)
            UpdateFading();

    }

    private void OnGUI()
    {
        if (IsFading)
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _fadeTexture);

    }

    public void SetPosition(Vector3 position)
        => transform.position = position;

    private void UpdateStaticCamera()
    {

    }

    private void UpdateFollowCamera()
    {
        SetPosition(World.Player.transform.position);
    }
    
    #region Fading

    /// <summary>
    /// Begin a camera fade.
    /// </summary>
    /// <param name="color">Fade color.</param>
    /// <param name="time">How long to fade.</param>
    /// <param name="callback">Method to call after fade ends.</param>
    /// <param name="fadein">Fades in if true otherwise fades out.</param>
    public void StartFade(Color color, float time = 1f, Action callback = null, bool fadein = false)
    {
        _fadeColor = color;
        _fadeTime = time;
        _fadeEndCallback = callback;
        _fadeIn = fadein;
        IsFading = true;
    }

    private void UpdateFading()
    {
        if (_fadeTime <= 0)
        {
            _fadeTime = -1;
            _fadeEndCallback?.Invoke();
            IsFading = false;
            return;
        }
        _fadeColor.a = _fadeCurve.Evaluate(_fadeTime);
        if (_fadeIn)
            _fadeColor.a = 1f - _fadeColor.a;

        _fadeTexture.SetPixel(0, 0, _fadeColor);
        _fadeTexture.Apply();

        _fadeTime -= Time.deltaTime;
    }

    #endregion
}
