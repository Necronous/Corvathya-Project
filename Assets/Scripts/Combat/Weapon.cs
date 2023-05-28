using System;

public abstract class Weapon
{
    public abstract int WeaponDamage { get; }
    public abstract WeaponType WeaponType { get; }
    
    public virtual void Equip()
    {
        World.Player.StateMachine.RegisterState(EntityState.LIGHT_ATTACK, AttackMode1, true);
        World.Player.StateMachine.RegisterState(EntityState.HEAVY_ATTACK, AttackMode2, true);
    }
    public virtual void Unequip()
    {
        World.Player.StateMachine.DeRegisterState(EntityState.LIGHT_ATTACK);
        World.Player.StateMachine.DeRegisterState(EntityState.HEAVY_ATTACK);
    }

    public abstract bool AttackMode1();
    public abstract bool AttackMode2();
}
