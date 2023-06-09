﻿
using System;
using System.Collections.Generic;
using UnityEngine;

public static partial class WorldVariables
{
    public const short VERSION_MAJOR = 0, VERSION_MINOR = 1;

    /*
     * Write all world variables here to be loaded into worldvariables on new game.
     * Do not use strings as we want the savefile to remain a constant size.
     * Add variable key as a constant.
     * */

    //0 - 100 reserved for player
    public const int PLAYER_LAST_ENTRANCE = 0;
    public const int PLAYER_LAST_CHECKPOINT = 1;
    public const int PLAYER_SAVED_POSITION = 2;
    public const int PLAYER_EQUIPED_WEAPON = 3;
    public const int PLAYER_EQUIPED_SIDEARM = 4;
    public const int PLAYER_MAX_HEALTH = 5;
    public const int PLAYER_CURRENT_HEALTH = 6;

    //100 - 200 reserved for global
    public const int CURRENT_MAP_INDEX = 100;
    public const int NEW_GAME = 101;

    //200+ for maps

    private static Dictionary<int, object> DefaultWorldVariables = new()
    {
        { PLAYER_LAST_ENTRANCE, 0 },
        { PLAYER_LAST_CHECKPOINT, 0 },
        { PLAYER_SAVED_POSITION, Vector3.zero },
        { PLAYER_MAX_HEALTH, 10},
        { PLAYER_CURRENT_HEALTH, 10},

        { PLAYER_EQUIPED_WEAPON, 0 },

        { CURRENT_MAP_INDEX, 1 },
        { NEW_GAME, true },
    };

    public static Dictionary<int, object> Variables { get; private set; } = DefaultWorldVariables;

    public static void Reset() => Variables = DefaultWorldVariables;
    public static void Clear() => Variables.Clear();
    public static bool Exists(int key) => Variables.ContainsKey(key);
    
    public static void Set(int key, object val) => Variables[key] = val;
    public static void Set(Dictionary<int, object> dic) => Variables = dic;
    
    public static void Remove(int key) => Variables.Remove(key);
    
    public static T Get<T>(int key) => (T)Variables[key];
    public static object Get(int key) => Variables[key];

    public static Type GetType(int key) => Get(key).GetType();

    public static void Add(int key, object val) => Variables.Add(key, val);
    public static void Add(Dictionary<int, object> dic)
    {
        foreach(KeyValuePair<int, object> kvp in dic)
        {
            if (Exists(kvp.Key))
                Set(kvp.Key, kvp.Value);
            else
                Add(kvp.Key, kvp.Value);
        }
    }
}

