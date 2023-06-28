using Unity.VisualScripting;
using UnityEngine;

public class Debug_Sword : IWeapon
{
    
    public string Name => "Debug Sword";
    public float ComboWindow => .2f;

    public bool GroundLightAttack(int combo)
    {
        return false;
    }

    public bool AirLightAttack(int combo)
    {
        return false;
    }

    public bool GroundHeavyAttack(int combo)
    {
        return false;
    }

    public bool AirHeavyAttack(int combo)
    {
        return false;
    }

}
