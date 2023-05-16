using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// The world singleton, Always exists cannot be destroyed.
/// Stores world variables, saving loading, creating the player and loading maps.
/// Is created in the main menu scene and exists forever from there.
/// </summary>
public class World : MonoBehaviour
{
    //Move this somewhere else later...
    public const short VERSION_MAJOR = 0, VERSION_MINOR = 1;

    public static World Instance { get; private set; }
    public static PlayerController Player { get; private set; }

    [SerializeField]
    public GameObject PlayerPrefab;

    public MapTransitionHandler MapTransitionHandler { get; private set; }

    public bool WorldPaused;

    private Dictionary<string, object> _worldVariables = new();

    #region MapProperties
    private List<MapEntrance> _mapEntrances = new();
    private List<BaseEntityController> _npcList = new();
    private int _currentMapIndex;
    private string _currentMapName;
    
    public int MapEntityCount => _npcList.Count;
    public int MapEntranceCount => _mapEntrances.Count;
    #endregion

    private void Awake()
    {
        if (Instance != null)
            return;
        Instance = this;
        DontDestroyOnLoad(this);

    }
    private void PrintWorldVariables()
    {
        Debug.Log("World variables...");
        foreach(KeyValuePair<string, object> kvp in _worldVariables)
            Debug.Log(kvp.Key + " : " + kvp.Value.ToString());
    }

    private void Start()
    {
        MapTransitionHandler = new();
        _worldVariables = WorldVariablesDefine.GetDefaultWorldVariables();
        //temp
        Transform transform = GameObject.Find("PlayerSpawn").transform;
        CreatePlayer();
        CameraController.Instance.SetState((int)CameraModeEnum.FOLLOW_PLAYER);
        Player.transform.position = transform.position;
        _currentMapIndex = -1;
        //
    }

    private void Update()
    {
#if DEBUG
        if (Input.GetKeyUp(KeyCode.Keypad0))
            PrintWorldVariables();
#endif
        if(MapTransitionHandler.IsTransitioning)
            MapTransitionHandler.Update();
    }

    #region WorldVariables

    public Dictionary<string, object> GetWorldVariables()
        => _worldVariables;
    public void SetWorldVariables(Dictionary<string, object> vars)
        => _worldVariables = vars;
        
    /// <summary>
    /// Checks if a world variable exists.
    /// </summary>
    /// <param name="key">Key of the value to check</param>
    /// <returns></returns>
    public bool HasWorldVariable(string key) => _worldVariables.ContainsKey(key);

    /// <summary>
    /// Sets a world variable with the current map name prefixed before the key.
    /// IE "Mortuary.BossXDead".
    /// </summary>
    /// <param name="key">Name of variable, will be automatically prefixed with map name.</param>
    /// <param name="value">Value of the variable.</param>
    public void SetMapVariable(string key, object value)
        => SetWorldVariable(_currentMapName + "." + key, value);
    /// <summary>
    /// Sets a world variable with the given key.
    /// </summary>
    /// <param name="key">Variable name.</param>
    /// <param name="value">Variable value.</param>
    public void SetWorldVariable(string key, object value)
    {
        if(HasWorldVariable(key))
            _worldVariables[key] = value;
    }

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

    public string GetCurrentMapName()
        => _currentMapName;
    public int GetCurrentMapIndex()
        => _currentMapIndex;

    public bool MapExists(string mapName)
        => GetMapIndexByName(mapName) != -1;
    public int GetMapIndexByName(string mapName)
        => SceneUtility.GetBuildIndexByScenePath(mapName);
    public string GetMapNameByIndex(int index)
    {
        string path = SceneUtility.GetScenePathByBuildIndex(index);
        return Path.GetFileNameWithoutExtension(path);
    }

    public void LoadMap(string mapname)
    {

        if (!MapExists(mapname))
            return;
        SceneManager.LoadScene(mapname);
        _currentMapIndex = GetMapIndexByName(mapname);
        _currentMapName = GetMapNameByIndex(_currentMapIndex);
    }

    public void QuitToMainMenu()
    {
        //Assume saving has been done.
        DestroyPlayer();
        SceneManager.LoadScene("MainMenu");
        _currentMapIndex = -1;
        _currentMapName = "MainMenu";
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
    #region Map

    public void AddEntity(BaseEntityController npc)
    {
        if (_npcList.Contains(npc) || npc is PlayerController)
            return;
        _npcList.Add(npc);
    }
    public void RemoveEntity(BaseEntityController npc)
    {
        if (_npcList.Contains(npc))
            _npcList.Remove(npc);
    }

    public void AddEntrance(MapEntrance entry)
    {
        if (_mapEntrances.Contains(entry))
            return;
        _mapEntrances.Add(entry);
    }
    public void RemoveEntrance(MapEntrance entry)
    {
        if (_mapEntrances.Contains(entry))
            _mapEntrances.Remove(entry);
    }
    public int GetEntranceIndex(MapEntrance entry)
        => _mapEntrances.IndexOf(entry);
    public MapEntrance GetEntrance(int index)
        => _mapEntrances[index];

    public MapEntrance GetDefaultEntrance()
    {
        MapEntrance ent = GetEntrance("");
        if (ent == null)
            ent = _mapEntrances[0];
        return ent;
    }
    public MapEntrance GetEntrance(string name)
        => _mapEntrances.Find(x => x.EntranceName == name);


    #endregion
}
