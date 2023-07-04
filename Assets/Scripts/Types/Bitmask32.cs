using System;
using UnityEngine;

/// <summary>
/// 32bit bitmask.
/// </summary>
public struct Bitmask32
{
    private int _mask;

    public Bitmask32(int mask = 0)
        => _mask = mask;

    public bool IsSet(int bit)
        => (_mask & (1 << bit)) == (1 << bit);

    public void Set(int bit, bool val)
    {
        if (val)
            Set(bit);
        else
            Unset(bit);
    }

    public void Set(int bit)
        =>_mask |= (1 << bit);
    public void Unset(int bit)
        => _mask &= ~(1 << bit);

    public static Bitmask32 FromLayers(params string[] layers)
        => LayerMask.GetMask(layers);
    

    public static implicit operator int(Bitmask32 b) => b._mask;
    public static implicit operator Bitmask32(int i) => new(i);
}

