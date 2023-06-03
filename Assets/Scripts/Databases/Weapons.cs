
public static partial class WorldVariables
{
    private static IWeapon[] Weapons = new IWeapon[]
    {

    };

    public static int GetMaxWeapons => Weapons.Length;

    public static IWeapon GetWeaponFromIndex(int index)
    {
        if (index < 0 || index >= GetMaxWeapons)
            return null;
        return Weapons[index];
    }
    public static int GetIndexForWeapon(IWeapon wep)
    {
        for(int i = 0; i < GetMaxWeapons; i++)
        {
            if (Weapons[i] == wep)
                return i;
        }
        return -1;
    }
}
