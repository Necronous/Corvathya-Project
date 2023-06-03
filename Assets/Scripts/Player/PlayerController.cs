
using UnityEngine;


[RequireComponent(typeof(PlayerInputHandler))]
[RequireComponent(typeof(PlayerEquipmentComponent))]
public partial class PlayerController : BaseEntityController
{
    public static PlayerController Instance { get; private set; }

    private PlayerInputHandler _inputHandler;
    private PlayerEquipmentComponent _EquipmentHandler;

    private (byte CurrentCount, byte MaxCount, bool HighJump) _jumpData = (0, 2, false);

    [Header("Player_Physics")]
    public float WallHangTime = 1f;
    public float WallRunTime = .4f;
    public float LedgeClimbTime = .4f;
    public float ApexAirTime = .08f;

    public bool PauseInput
    {
        get => _inputHandler.PauseInput;
        set => _inputHandler.PauseInput = value;
    }

    public override void Start()
    {
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;

        CameraController.Instance.SetPlayerFollowCamera();

        base.Start();

        _inputHandler = GetComponent<PlayerInputHandler>();
        _EquipmentHandler = GetComponent<PlayerEquipmentComponent>();

        RegisterAllStates();
        StateMachine.SetState(EntityState.IDLING);

        CollisionHandler.CareAboutPreciseCollisions(true, 4, 8);
    }

    public void Load()
    {
        if (WorldVariables.Get<bool>(WorldVariables.NEW_GAME))
        {
            transform.position = new Vector3(-2.95f, -0.27f, -0.01f);
            WorldVariables.Set(WorldVariables.NEW_GAME, false);
            WorldVariables.Set(WorldVariables.PLAYER_SAVED_POSITION, transform.position);
            SaveManager.Instance.Save();
        }
        else
        {
            transform.position = WorldVariables.Get<Vector3>(WorldVariables.PLAYER_SAVED_POSITION);
        }
        //_EquipmentHandler.SetWeapon(World.Instance.GetWorldVariable<int>("player.equipedweapon"));
    }

    protected override void Update()
    {
        if (!PauseInput)
            MovementMagnitude = _inputHandler.GetHorizontalMovement();
        base.Update();
    }

    protected override void OnDeathCallback(MonoBehaviour source)
    {
        base.OnDeathCallback(source);
    }
    protected override void OnDamageCallback(MonoBehaviour source, int damage)
    {
        base.OnDamageCallback(source, damage);
    }

    private void RegisterAllStates()
    {
        StateMachine.RegisterState(EntityState.IDLING, State_Idling);
        StateMachine.RegisterState(EntityState.RUNNING, State_Running);
        StateMachine.RegisterState(EntityState.SLIDING, State_Sliding);
        StateMachine.RegisterState(EntityState.HARD_TURNING, State_Turning);
        StateMachine.RegisterState(EntityState.CROUCHING, State_Crouching);
        StateMachine.RegisterState(EntityState.JUMP_TAKINGOFF, State_JumpTakingOff);
        StateMachine.RegisterState(EntityState.JUMP_LANDING, State_JumpLanding);
        StateMachine.RegisterState(EntityState.DODGING, State_Dodge);
        
        StateMachine.RegisterState(EntityState.FALLING, State_Falling);
        StateMachine.RegisterState(EntityState.GLIDING, State_Gliding);
        StateMachine.RegisterState(EntityState.JUMPING, State_Jumping);
        StateMachine.RegisterState(EntityState.JUMP_APEX, State_JumpApex);

        StateMachine.RegisterState(EntityState.LEDGE_GRABBING, State_LedgeGrab);
        StateMachine.RegisterState(EntityState.LEDGE_CLIMBING, State_LedgeClimb);

        StateMachine.RegisterState(EntityState.WALL_HANGING, State_WallHang);
        StateMachine.RegisterState(EntityState.WALL_JUMPING, State_WallJump);
        StateMachine.RegisterState(EntityState.WALL_SLIDING, State_WallSlide);
        StateMachine.RegisterState(EntityState.WALL_RUNNING, State_WallRun);
    }
}
