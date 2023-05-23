
using UnityEngine;

[RequireComponent(typeof(PlayerInputHandler))]
public partial class PlayerController : BaseEntityController
{
    private PlayerInputHandler _inputHandler;

    private (byte CurrentCount, byte MaxCount, bool HighJump) _jumpData = (0, 2, false);

    public bool PauseInput
    {
        get => _inputHandler.PauseInput;
        set => _inputHandler.PauseInput = value;
    }

    public override void Start()
    {
        if (World.Player != null)
            Destroy(gameObject);
        CameraController.Instance.SetPlayerFollowCamera();

        base.Start();

        _inputHandler = GetComponent<PlayerInputHandler>();

        RegisterAllStates();
        StateMachine.SetState(EntityStateEnum.IDLING);

        CollisionHandler.CareAboutPreciseCollisions(true, 4, 8);
    }

    protected override void Update()
    {
        if(!PauseInput)
            MovementMagnitude = _inputHandler.GetHorizontalMovement();
        base.Update();
    }

    private void RegisterAllStates()
    {
        StateMachine.RegisterState(EntityStateEnum.IDLING, State_Idling);
        StateMachine.RegisterState(EntityStateEnum.RUNNING, State_Running);
        StateMachine.RegisterState(EntityStateEnum.SLIDING, State_Sliding);
        StateMachine.RegisterState(EntityStateEnum.HARD_TURNING, State_Turning);
        StateMachine.RegisterState(EntityStateEnum.CROUCHING, State_Crouching);
        StateMachine.RegisterState(EntityStateEnum.JUMP_TAKINGOFF, State_JumpTakingOff);
        StateMachine.RegisterState(EntityStateEnum.JUMP_LANDING, State_JumpLanding);
        StateMachine.RegisterState(EntityStateEnum.DODGING, State_Dodge);
        
        StateMachine.RegisterState(EntityStateEnum.FALLING, State_Falling);
        StateMachine.RegisterState(EntityStateEnum.GLIDING, State_Gliding);
        StateMachine.RegisterState(EntityStateEnum.JUMPING, State_Jumping);
        StateMachine.RegisterState(EntityStateEnum.JUMP_APEX, State_JumpApex);
    }
}
