
using System;
using UnityEngine;

public interface IWeapon : EntityStateMachine.IEntityState
{
    public string WeaponName { get; }

    public void PrimeForGroundLightAttack(int combo);
    public void PrimeForAirLightAttack(int combo);
           
    public void PrimeForGroundHeavyAttack(int combo);
    public void PrimeForAirHeavyAttack(int combo);
}

