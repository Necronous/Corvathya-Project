
public static partial class WorldVariables
{
    private static ISidearm[] Sidearms = new ISidearm[]
    {

    };

    public static int GetMaxSidearms => Sidearms.Length;

    public static ISidearm GetSidearmFromIndex(int index)
    {
        if (index < 0 || index >= GetMaxSidearms)
            return null;
        return Sidearms[index];
    }
    public static int GetIndexForSidearm(ISidearm sa)
    {
        for (int i = 0; i < GetMaxSidearms; i++)
        {
            if (Sidearms[i] == sa)
                return i;
        }
        return -1;
    }
}