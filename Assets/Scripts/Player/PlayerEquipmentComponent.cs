using System;
using UnityEngine;

public class PlayerEquipmentComponent : MonoBehaviour
{

    private PlayerController Player;

    public IWeapon EquipedWeapon { get; private set; }

    public Event<IWeapon> OnWeaponChange = new();

    private void Start()
    {
        Player = GetComponent<PlayerController>();
    }

    /// <summary>
    /// Sets the equiped weapon without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="id">ID of weapon to equip</param>
    public void SetWeapon(int id)
    {
        IWeapon weapon = WorldVariables.GetWeaponFromIndex(id);
        if (weapon == null)
            weapon = WorldVariables.GetWeaponFromIndex(0);
        SetWeapon(weapon);
    }
    /// <summary>
    /// Sets the equiped weapon without firing any events
    /// and calling equip() and unequip(). Used for save loading.
    /// </summary>
    /// <param name="weapon">Weapon to equip</param>
    public void SetWeapon(IWeapon weapon)
    {
        EquipedWeapon = weapon;
        if (weapon == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] weapon is null!");
            return;
        }
        Player.StateMachine.RegisterState(EntityState.LIGHT_ATTACK, weapon.LightAttack, true);
        Player.StateMachine.RegisterState(EntityState.HEAVY_ATTACK, weapon.HeavyAttack, true);
        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_WEAPON, WorldVariables.GetIndexForWeapon(weapon));
    }

    /// <summary>
    /// Equips the weapon.
    /// </summary>
    /// <param name="wep">Weapon to equip</param>
    public void EquipWeapon(IWeapon wep)
    {
        if (EquipedWeapon == wep)
            return;
        if (wep == null)
        {
            Debug.LogError("[PlayerEquipmentComponent.cs] weapon is null!");
            return;
        }

        Player.StateMachine.RegisterState(EntityState.LIGHT_ATTACK, wep.LightAttack, true);
        Player.StateMachine.RegisterState(EntityState.HEAVY_ATTACK, wep.HeavyAttack, true);

        EquipedWeapon.UnEquip();
        EquipedWeapon = wep;
        EquipedWeapon.Equip();
        WorldVariables.Set(WorldVariables.PLAYER_EQUIPED_WEAPON, WorldVariables.GetIndexForWeapon(wep));
        OnWeaponChange.Invoke(wep);
    }
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
}

