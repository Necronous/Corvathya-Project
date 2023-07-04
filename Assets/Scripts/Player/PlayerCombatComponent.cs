
using UnityEngine;

public class PlayerCombatComponent : MonoBehaviour
{
    private PlayerController _player;
    private PlayerEquipmentComponent _equipment;
    private PlayerInputHandler _inputHandler;

    public (int Current, int Max) Combo = (0, 1);
    public (float Current, float Max, bool Active) CoolDown = (0, 1f, false);
    public (float Current, bool Active) ComboWindow = (0, false);

    /*
    public bool IsAttacking =>
        _player.StateMachine.CurrentState == EntityState.AIR_LIGHT_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.GROUND_LIGHT_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.AIR_HEAVY_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.GROUND_HEAVY_ATTACK;
    public bool IsAirAttack =>
        _player.StateMachine.CurrentState == EntityState.AIR_LIGHT_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.AIR_HEAVY_ATTACK;
    public bool IsGroundAttack =>
        _player.StateMachine.CurrentState == EntityState.GROUND_LIGHT_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.GROUND_HEAVY_ATTACK;
    public bool IsLightAttack =>
        _player.StateMachine.CurrentState == EntityState.AIR_LIGHT_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.GROUND_LIGHT_ATTACK;
    public bool IsHeavyAttack =>
        _player.StateMachine.CurrentState == EntityState.AIR_HEAVY_ATTACK ||
        _player.StateMachine.CurrentState == EntityState.GROUND_HEAVY_ATTACK;
    */

    void Start()
    {
        _player = GetComponent<PlayerController>();
        _equipment = GetComponent<PlayerEquipmentComponent>();
        _inputHandler = GetComponent<PlayerInputHandler>();

        /*
        _player.StateMachine.RegisterState(EntityState.GROUND_LIGHT_ATTACK, Melee_DoGroundLightAttack);
        _player.StateMachine.RegisterState(EntityState.GROUND_HEAVY_ATTACK, Melee_DoGroundHeavyAttack);
        _player.StateMachine.RegisterState(EntityState.AIR_LIGHT_ATTACK, Melee_DoAirLightAttack);
        _player.StateMachine.RegisterState(EntityState.AIR_HEAVY_ATTACK, Melee_DoAirHeavyAttack);
        */
    }

    void Update()
    {
        if (CoolDown.Active)
        {
            CoolDown.Current -= Time.deltaTime;
            if (CoolDown.Current <= 0)
                ResetCombat();
        }

        if (ComboWindow.Active)
        {
            ComboWindow.Current -= Time.deltaTime;
            if (ComboWindow.Current <= 0)
            {
                ComboWindow = (0, false);
                Combo.Current = 0;
            }
        }
    }

    private void ResetCombat()
    {
        Combo.Current = 0;
        CoolDown.Current = 0;
        ComboWindow = (0, false);
    }

    #region MeleeWeapon
    public bool Melee_TryGroundAttack()
        => Melee_TryAttack(false);
    public bool Melee_TryAirAttack()
        => Melee_TryAttack(true);

    private bool Melee_TryAttack(bool inair)
    {
        if (CoolDown.Active)
            return false;

        EntityState lightstate = inair ? EntityState.AIR_LIGHT_ATTACK : EntityState.GROUND_LIGHT_ATTACK;
        EntityState heavystate = inair ? EntityState.AIR_HEAVY_ATTACK : EntityState.GROUND_HEAVY_ATTACK;

        bool isLightAttack = _inputHandler.KeyDown(PlayerInputHandler.ACTION_LIGHTATTACK);

        if (ComboWindow.Active)
        {
            Combo.Current++;
            ComboWindow.Current = _equipment.EquipedWeapon.ComboWindow;
            ComboWindow.Active = false; //Reactivate after attack.

            if (Combo.Current > Combo.Max)
            {
                CoolDown.Current = CoolDown.Max;
                CoolDown.Active = true;
            }
        }
        if (isLightAttack)
            _player.StateMachine.SetState(lightstate);
        else
            _player.StateMachine.SetState(heavystate);

        return true;
    }

    private bool Melee_DoGroundLightAttack()
        => _equipment.EquipedWeapon.GroundLightAttack(Combo.Current);
    private bool Melee_DoGroundHeavyAttack()
        => _equipment.EquipedWeapon.GroundHeavyAttack(Combo.Current);
    private bool Melee_DoAirLightAttack()
        => _equipment.EquipedWeapon.AirLightAttack(Combo.Current);
    private bool Melee_DoAirHeavyAttack()
        => _equipment.EquipedWeapon.AirHeavyAttack(Combo.Current);

    #endregion
    
    #region Sidearms
    #endregion

    #region Spells
    #endregion

    
}
