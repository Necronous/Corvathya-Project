
public static partial class WorldVariables
{
    private static ICharm[] Charms = new ICharm[]
    {

    };

    public static int GetMaxCharms => Charms.Length;

    public static ICharm GetCharmFromIndex(int index)
    {
        if (index < 0 || index >= GetMaxCharms)
            return null;
        return Charms[index];
    }
    public static int GetIndexForCharm(ICharm charm)
    {
        for (int i = 0; i < GetMaxCharms; i++)
        {
            if (Charms[i] == charm)
                return i;
        }
        return -1;
    }
}
