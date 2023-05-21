using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class WorldVariablesDefine
{
    /*
     * Write all world variables here to be loaded into worldvariables on new game.
     * Do not use strings as we want the savefile to be the same size.
     * */
    public static Dictionary<string, object> GetDefaultWorldVariables()
    {
        return new()
        {
            { "player.lastentrance", 0 },
            { "player.lastcheckpoint", 0 },

            { "currentmapindex", 1 },
            { "newgame", true },
        };
    }
}

