
using UnityEngine;

public partial class PlayerController : BaseEntityController
{
    public static PlayerController Instance { get; private set; }

    public PlayerInputHandler InputHandler { get; private set; }
    public PlayerEquipmentComponent EquipmentHandler { get; private set; }
    public PlayerCombatComponent CombatHandler { get; private set; }

    private (byte CurrentCount, byte MaxCount, bool HighJump) _jumpData = (0, 2, false);

    [Header("Player_Physics")]
    public float WallHangTime = 1f;
    public float WallRunTime = .4f;
    public float LedgeClimbTime = .4f;
    public float ApexAirTime = .08f;

    public bool PauseInput
    {
        get => InputHandler.PauseInput;
        set => InputHandler.PauseInput = value;
        
    }
    public override void Start()
    {
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;

        base.Start();

        InputHandler = GetComponent<PlayerInputHandler>();
        EquipmentHandler = GetComponent<PlayerEquipmentComponent>();
        CombatHandler = GetComponent<PlayerCombatComponent>();

        RegisterAllStates();
        StateMachine.SetState(EntityState.IDLING);

        CollisionHandler.CareAboutPreciseCollisions(true, 4, 8);

        EquipmentHandler.SetWeapon(WorldVariables.Get<int>(WorldVariables.PLAYER_EQUIPED_WEAPON));
        CameraController.Instance.SetPlayerFollowCamera();
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
            transform.position = WorldVariables.Get<Vector3>(WorldVariables.PLAYER_SAVED_POSITION);
        
        EquipmentHandler.SetWeapon(WorldVariables.Get<int>(WorldVariables.PLAYER_EQUIPED_WEAPON));
    }

    protected override void Update()
    {
        if (!PauseInput)
        {
            MovementMagnitude = InputHandler.GetHorizontalMovement();
        }
        base.Update();
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
