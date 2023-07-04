
using System;
using UnityEngine;

public interface IWeapon
{
    public string Name { get; }
    public float ComboWindow { get; }

    public bool GroundLightAttack(int combo);
    public bool AirLightAttack(int combo);
    public bool GroundHeavyAttack(int combo);
    public bool AirHeavyAttack(int combo);

    public GameObject[] GetHitObjects(Rect rect, Bitmask32 layermask)
    { 
        Collider2D[] colliders = PlayerController.Instance.CollisionHandler.OverlapArea(rect, layermask);
        if (colliders.Length == 0)
            return null;
        GameObject[] gameObjects = new GameObject[colliders.Length];
        for(int i = 0; i < colliders.Length; i++)
            gameObjects[i] = colliders[i].gameObject;
        return gameObjects;
    }


    protected void EndAttack()
    {
        PlayerController.Instance.CombatHandler.ComboWindow.Active = true;
        PlayerController.Instance.StateMachine.SetState(EntityState.IDLING);
    }
}

