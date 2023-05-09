using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.EventSystems.EventTrigger;

/// <summary>
/// The world class singleton, Always exists cannot be destroyed.
/// Stores world variables, saving loading, creating the player and loading maps.
/// Is created in the main menu scene and exists forever from there.
/// Map.cs will not work without this.
/// </summary>
public class World : MonoBehaviour
{
    public static World Instance { get; private set; }
    public static PlayerController Player { get; private set; }

    [SerializeField]
    public GameObject PlayerPrefab;


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
    public bool HasWorldVariable(string key) => _worldVariables.ContainsKey(key);

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
        if (!HasWorldVariable(key))
            return false;
        object value = _worldVariables[key];
        if (value is T v)
        {
            result = v;
            return true;
        }
        return false;
    }
    #endregion
    #region MapLoading

    public bool MapExists(string mapName)
        => SceneUtility.GetBuildIndexByScenePath(mapName) != -1;

    public void LoadMap(string mapName)
    {
        if (!MapExists(mapName))
            return;
        SceneManager.LoadScene(mapName);
        MapEntrance e = Map.Instance.GetDefaultEntrance();
        if (e == null)
        {
            Debug.LogError("Map has no entrances!");
            Player.transform.position = Vector3.zero;
            return;
        }
    }

    public void LoadMapWithEntrance(string mapname, string entry)
    {
        if (!MapExists(mapname))
            return;
        SceneManager.LoadScene(mapname);
        MapEntrance e = Map.Instance.GetEntrance(entry);
        if (e == null)
            e = Map.Instance.GetDefaultEntrance();
        if(e == null)
        {
            Debug.LogError("Map has no entrances!");
            Player.transform.position = Vector3.zero;
            return;
        }
        Player.transform.position = e.transform.position;
    }

    public void QuitToMainMenu()
    {
        //Save world variables?
        if(Player != null)
        {
            //Save player?
            DestroyPlayer();
        }
        SceneManager.LoadScene("MainMenu");
    }

    #endregion
    #region Player

    public void CreatePlayer()
    {
        if (Player != null)
            return;
        Player = Instantiate(PlayerPrefab).GetComponent<PlayerController>();
        Player.transform.parent = transform;
    }

    public void DestroyPlayer()
    {
        if (Player == null)
            return;
        Destroy(Player);
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
