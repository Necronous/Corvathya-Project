using System;
using UnityEngine;

public class EntityHealthComponent : MonoBehaviour
{
    public int MaxHealth { get; private set; } = 10;
    public int CurrentHealth { get; private set; }

    public bool IsDead { get; private set; }
    public bool Invincible;

    public Event<MonoBehaviour> OnDeath;
    public Event<MonoBehaviour, int> OnDamage;


    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void Reset()
    {
        IsDead = Invincible = false;
        CurrentHealth = MaxHealth;
    }

    /// <summary>
    /// Deals damage to this entity.
    /// </summary>
    /// <param name="source">The source damage was dealt from</param>
    /// <param name="damage">Damage to deal</param>
    public void DealDamage(MonoBehaviour source, int damage)
    {
        if (IsDead || Invincible)
            return;
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
            Kill(source);
        else
            OnDamage.Invoke(source, damage);
    }

    /// <summary>
    /// Kills this entity.
    /// </summary>
    /// <param name="source">Source that killed this entity</param>
    public void Kill(MonoBehaviour source)
    {
        if (IsDead || Invincible)
            return;
        CurrentHealth = 0;
        IsDead = true;
        OnDeath.Invoke(source);
    }
}
