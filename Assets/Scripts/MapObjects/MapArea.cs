using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapArea : MonoBehaviour
{
    [SerializeField] 
    public List<AreaModifier> Modifiers = new List<AreaModifier>();

    public bool HasModifier(AreaModifier mod) => Modifiers.Contains(mod);
    public void AddModifier(AreaModifier mod)
    {
        if (HasModifier(mod))
            return;
        Modifiers.Add(mod);
    }
    public void RemoveModifier(AreaModifier mod)
    {
        if (!HasModifier(mod))
            return;
        Modifiers.Remove(mod);
    }

}
