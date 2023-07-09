
using PlayerStates;
using UnityEngine;

public partial class PlayerController : BaseEntityController
{
    public static PlayerController Instance { get; private set; }

    public PlayerInputHandler InputHandler { get; private set; }
    public PlayerEquipmentComponent EquipmentHandler { get; private set; }
    public PlayerCombatComponent CombatHandler { get; private set; }

    public (byte CurrentCount, byte MaxCount, bool HighJump) JumpData = (0, 2, false);

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
        StateMachine.RegisterState(EntityState.IDLING, new State_Idle());
        StateMachine.RegisterState(EntityState.RUNNING, new State_Running());
        StateMachine.RegisterState(EntityState.SLIDING, new State_Sliding());
        StateMachine.RegisterState(EntityState.CROUCHING, new State_Crouching());
        StateMachine.RegisterState(EntityState.JUMP_TAKINGOFF, new State_JumpTakingOff());
        StateMachine.RegisterState(EntityState.JUMP_LANDING, new State_JumpLanding());
        
        StateMachine.RegisterState(EntityState.FALLING, new State_Falling());
        StateMachine.RegisterState(EntityState.JUMPING, new State_Jumping());
        StateMachine.RegisterState(EntityState.JUMP_APEX, new State_Jump_Apex());

        StateMachine.RegisterState(EntityState.LEDGE_GRABBING, new State_LedgeGrab());
        StateMachine.RegisterState(EntityState.LEDGE_CLIMBING, new State_LedgeClimb());
    }

    public bool CanAirJump()
    {
        if (JumpData.CurrentCount >= JumpData.MaxCount)
            return false;

        JumpData.CurrentCount++;
        Velocity.y = JumpForce;
        JumpData.HighJump = true;
        StateMachine.SetState(EntityState.JUMPING);
        return true;
    }
    public bool CheckForWallStateChange()
    {
        (bool collision, Collider2D collider)[] coldata = null;

        if (FacingDirection > 0 && OnRightWall && MovementMagnitude > 0)
            coldata = CollisionHandler.GetRightCollisions();
        else if (FacingDirection < 0 && OnLeftWall && MovementMagnitude < 0)
            coldata = CollisionHandler.GetLeftCollisions();
        else
            return false;

        /*
        //If on wall.
        if ( coldata[0].collision && coldata[1].collision
            && coldata[2].collision && coldata[3].collision 
            && coldata[4].collision && coldata[5].collision 
            && coldata[6].collision && coldata[7].collision )
        {
            Velocity = Vector2.zero;
            StateMachine.SetState(EntityStateEnum.WALL_HANGING);
            return true;
        }
        */

        //OnLedge
        if ( coldata[6].collision && !coldata[7].collision
            && StateMachine.GetLastStateID() != EntityState.LEDGE_GRABBING
            && Velocity.y <= 0)
        {
            Vector3 castStart = new(
                transform.position.x + ((CollisionHandler.HalfWidth + 0.2f) * FacingDirection),
                transform.position.y + CollisionHandler.Height + .1f
                );

            RaycastHit2D hit = CollisionHandler.Linecast(castStart, castStart + (Vector3.down * CollisionHandler.HalfHeight));

            transform.position = new Vector3(
                transform.position.x,
                hit.point.y - CollisionHandler.Height,
                0
                );
            Velocity = Vector2.zero;
            StateMachine.SetState(EntityState.LEDGE_GRABBING);
            return true;
        }
        return false;
    }
    public bool CanClimbLedge()
    {
        //Only climb if the player can fit on the platform
        bool canclimb = !CollisionHandler.Cast(
            transform.position.Swizzle_xy() + new Vector2((CollisionHandler.Width + .05f) * FacingDirection,
            CollisionHandler.Height + .05f));

        if (canclimb)
        {
            StateMachine.SetState(EntityState.LEDGE_CLIMBING);
            return true;
        }
        return false;
    }
}
