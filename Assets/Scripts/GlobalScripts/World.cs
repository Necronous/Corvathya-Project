using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// The world class singleton, Always exists cannot be destroyed. Stores world variables, saving loading, creating the player and loading maps.
/// </summary>
public class World : MonoBehaviour
{
    public static World Instance { get; private set; }
    public static PlayerController Player { get; private set; }

    private Dictionary<string, object> _worldVariables = new();

    private void Awake()
    {
        if (Instance != null)
            return;
        Instance = this;
        DontDestroyOnLoad(this);
    }

    #region WorldVariables
    /// <summary>
    /// Checks if a world variable exists.
    /// </summary>
    /// <param name="key">Key of the value to check</param>
    /// <returns></returns>
    public bool IsWorldVariable(string key) => _worldVariables.ContainsKey(key);

    /// <summary>
    /// returns the world variable stored with the key.
    /// </summary>
    /// <typeparam name="T">Type to convert variable to</typeparam>
    /// <param name="key">The world variable</param>
    /// <returns></returns>
    public T GetWorldVariable<T>(string key) => (T)_worldVariables[key];
    /// <summary>
    /// Tries to retrieve a world variable with the given key.
    /// </summary>
    /// <typeparam name="T">Type to convert variable to</typeparam>
    /// <param name="key">Variable key.</param>
    /// <param name="result">The retrieved variable</param>
    /// <returns>Returns true on success and false if variable not found or type casting failure.</returns>
    public bool TryGetWorldVariable<T>(string key, out T result)
    {
        result = default(T);
        Type t = typeof(T);
        if (!IsWorldVariable(key))
            return false;
        object value = _worldVariables[key];
        if (value.GetType() != t)
            return false;
        result = (T)value;
        return true;
    }
    #endregion
    #region MapLoading

    public bool MapExists(string mapName)
        => SceneUtility.GetBuildIndexByScenePath(mapName) != -1;

    public void LoadMap(string mapName)
    {
        if(MapExists(mapName))
            SceneManager.LoadScene(mapName);
    }

    public void LoadMapWithEntrance(string mapname, string entry)
    {
        if (!MapExists(mapname))
            return;
        SceneManager.LoadScene(mapname);
        MapEntrance e = Map.Instance.GetEntrance(entry);
        if(e == null)
            Player.transform.position = Vector3.zero;
        Player.transform.position = e.transform.position;
    }

    #endregion
    #region Player

    public void CreatePlayer()
    {

    }

    public void DestroyPlayer()
    {

    }

    #endregion
    #region SavingLoading

    public void SaveGame()
    {

    }

    public void LoadGame()
    {

    }

    #endregion
}
