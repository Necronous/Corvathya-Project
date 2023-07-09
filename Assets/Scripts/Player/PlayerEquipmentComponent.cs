using System;
using UnityEngine;

public class PlayerEquipmentComponent : MonoBehaviour
{

    public IWeapon EquipedWeapon { get; private set; }
    public ISidearm EquipedSidearm { get; private set; }

    public Event<IWeapon> OnWeaponChange = new();
    public Event<ISidearm> OnSidearmChange = new();

    private void Start()
    {
    }


    #region Setting
    /// <summary>
    /// Sets the equiped weapon without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="id">ID of weapon to equip</param>
    public void SetWeapon(int id)
    {
        IWeapon weapon = WorldVariables.GetWeaponFromIndex(id);
        SetWeapon(weapon);
    }
    /// <summary>
    /// Sets the equiped weapon without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="weapon">Weapon to equip</param>
    public void SetWeapon(IWeapon weapon)
    {
        if (weapon == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] weapon is null!");
            return;
        }
        EquipedWeapon = weapon;

        //Setting all of these to the same state seems pointless but it allows us to check
        //What type of attack it is from statemachine.currentstate.
        PlayerController.Instance.StateMachine.RegisterState(EntityState.AIR_HEAVY_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.AIR_LIGHT_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.GROUND_HEAVY_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.GROUND_LIGHT_ATTACK, weapon, true);

        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_WEAPON, WorldVariables.GetIndexForWeapon(weapon));
    }
    /// <summary>
    /// Sets the equiped sidearm without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="id">ID of weapon to equip</param>
    public void SetSidearm(int id)
    {
        ISidearm sarm = WorldVariables.GetSidearmFromIndex(id);
        SetWeapon(sarm);
    }
    /// <summary>
    /// Sets the equiped sidearm without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="sarm">Sidearm to equip</param>
    public void SetWeapon(ISidearm sarm)
    {
        if (sarm == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] sidearm is null!");
            return;
        }
        EquipedSidearm = sarm;
        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_SIDEARM, WorldVariables.GetIndexForSidearm(sarm));
    }

    #endregion
    #region Equipping
    /// <summary>
    /// Equips the weapon.
    /// </summary>
    /// <param name="id">id of weapon to equip</param>
    public void EquipWeapon(int id)
    {
        IWeapon weapon = WorldVariables.GetWeaponFromIndex(id);
        if (weapon == null)
            weapon = WorldVariables.GetWeaponFromIndex(0);
        EquipWeapon(weapon);
    }
    /// <summary>
    /// Equips the weapon.
    /// </summary>
    /// <param name="weapon">Weapon to equip</param>
    public void EquipWeapon(IWeapon weapon)
    {
        if (EquipedWeapon == weapon)
            return;
        if (weapon == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] weapon is null!");
            return;
        }

        EquipedWeapon = weapon;

        //Setting all of these to the same state seems pointless but it allows us to check
        //What type of attack it is from statemachine.currentstate.
        PlayerController.Instance.StateMachine.RegisterState(EntityState.AIR_HEAVY_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.AIR_LIGHT_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.GROUND_HEAVY_ATTACK, weapon, true);
        PlayerController.Instance.StateMachine.RegisterState(EntityState.GROUND_LIGHT_ATTACK, weapon, true);


        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_WEAPON, WorldVariables.GetIndexForWeapon(weapon));
        OnWeaponChange.Invoke(weapon);
    }

    /// <summary>
    /// Equips the Sidearm.
    /// </summary>
    /// <param name="id">id of Sidearm to equip</param>
    public void EquipSidearm(int id)
    {
        ISidearm sarm = WorldVariables.GetSidearmFromIndex(id);
        EquipSidearm(sarm);
    }
    /// <summary>
    /// Equips the Sidearm.
    /// </summary>
    /// <param name="sarm">Sidearm to equip</param>
    public void EquipSidearm(ISidearm sarm)
    {
        if (EquipedWeapon == sarm)
            return;
        if (sarm == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] sidearm is null!");
            return;
        }

        EquipedSidearm = sarm;
        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_SIDEARM, WorldVariables.GetIndexForSidearm(sarm));
        OnSidearmChange.Invoke(sarm);
    }
    #endregion
}