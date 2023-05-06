using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapArea : MonoBehaviour
{
    [SerializeField] 
    public List<AreaModifierEnum> Modifiers = new List<AreaModifierEnum>();

    public bool HasModifier(AreaModifierEnum mod) => Modifiers.Contains(mod);
    public void AddModifier(AreaModifierEnum mod)
    {
        if (HasModifier(mod))
            return;
        Modifiers.Add(mod);
    }
    public void RemoveModifier(AreaModifierEnum mod)
    {
        if (!HasModifier(mod))
            return;
        Modifiers.Remove(mod);
    }

}
