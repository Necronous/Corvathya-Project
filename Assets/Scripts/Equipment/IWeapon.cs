
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

    public GameObject GetHitObject(Vector3 point, params string[] layernames)
        => PlayerController.Instance.CombatHandler.GetHitObject(point, layernames);
    public GameObject GetHitObject(Rect rect, params string[] layernames)
        => PlayerController.Instance.CombatHandler.GetHitObject(rect, layernames);
    
    //Breakable wall, etc...
    public bool IsWeaponTriggered(GameObject obj)
        =>throw new NotImplementedException();
    public BaseEntityController IsEntity(GameObject obj) 
        => obj.GetComponent<BaseEntityController>();

    protected void EndAttack()
    {
        PlayerController.Instance.CombatHandler.ComboWindow.Active = true;
        PlayerController.Instance.StateMachine.SetState(EntityState.IDLING);
    }
}

