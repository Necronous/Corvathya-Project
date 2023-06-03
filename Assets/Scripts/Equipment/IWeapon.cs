
using System;
using UnityEngine;

public interface IWeapon
{
    public string Name { get; }

    public void Equip();
    public void UnEquip();
    public bool LightAttack();
    public bool HeavyAttack();
}

