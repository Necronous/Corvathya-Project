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

    //Debugging
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width - 400, 0, 400, 400));
        GUILayout.Label("World Variables::");
        foreach(KeyValuePair<string, object> kvp in _worldVariables)
            GUILayout.Label(kvp.Key + " : " + kvp.Value.ToString());
        
        GUILayout.EndArea();
    }

    private void Start()
    {
        MapTransitionHandler = new();
        //temp
        CreatePlayer();
        CameraController.Instance.SetState((int)CameraModeEnum.FOLLOW_PLAYER);
        Player.transform.position = GetDefaultEntrance().transform.position;
        _currentMapIndex = -1;
        //
    }

    private void Update()
    {
        if(MapTransitionHandler.IsTransitioning)
            MapTransitionHandler.Update();
    }

    #region WorldVariables
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
        else
            _worldVariables.Add(key, value);
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
    #region SavingLoading

    public void SaveGame(string savePath)
    {
        byte[] worldData = SerializeWorldVariables();
        //get player data.

        using (BinaryWriter writer = new(new FileStream(savePath, FileMode.Create)))
        {
            //Header = 30 bytes.
            //the header of all saves will be loaded on game start to fill in the load game list with info.

            //magic
            writer.Write(new char[] { 'S','A', 'V', 'E' });
            //Game version. Major - Minor
            writer.Write(VERSION_MAJOR); writer.Write(VERSION_MINOR);
            //Date and time
            DateTime time = DateTime.Now;
            writer.Write(time.Day); writer.Write(time.Month); writer.Write(time.Year);
            writer.Write(time.Hour); writer.Write(time.Minute);

            //Write current map name as level index (short)
            writer.Write((short)_currentMapIndex);

            //EndHeader 


            //Write serialized world data.
            writer.Write(worldData.Length);
            writer.Write(worldData);
        }
    }

    public void LoadGame()
    {

    }

    private byte[] SerializeWorldVariables()
    {
        MemoryStream ms = new();
        using (BinaryWriter writer = new(ms))
        {
            writer.Write(_worldVariables.Count);
            foreach(KeyValuePair<string, object> kvp in _worldVariables)
            {
                //First we write the key, then we write a byte which indicates value type then we write the value.
                //Maybe implement ISavable interface for other values.
                //Add encryption for strings.
                writer.Write(kvp.Key);
                if (kvp.Value is byte by)
                { writer.Write((byte)0); writer.Write(by); }
                else if (kvp.Value is short sh)
                { writer.Write((byte)1); writer.Write(sh); }
                else if (kvp.Value is int i)
                { writer.Write((byte)2); writer.Write(i); }
                else if (kvp.Value is long lo)
                { writer.Write((byte)3); writer.Write(lo); }
                else if (kvp.Value is bool bo)
                { writer.Write((byte)4); writer.Write(bo); }
                else if (kvp.Value is string st)
                { writer.Write((byte)5); writer.Write(st); }
            }
        }
        return ms.ToArray();
    }
    private void DeserializeWorldVariables(byte[] b)
    {
        MemoryStream ms = new(b);
        ms.Position = 0;
        _worldVariables.Clear();
        using (BinaryReader reader = new(ms))
        {
            int count = reader.ReadInt32();
            for(int i = 0; i < count; i++)
            {
                string key = reader.ReadString();
                byte valuetype = reader.ReadByte();
                object value = 0;
                switch(valuetype)
                {
                    case 0: value = reader.ReadByte(); break;
                    case 1: value = reader.ReadInt16(); break;
                    case 2: value = reader.ReadInt32(); break;
                    case 3: value = reader.ReadInt64(); break;
                    case 4: value = reader.ReadBoolean(); break;
                    case 5: value = reader.ReadString(); break;
                }
                _worldVariables.Add(key, value);
            }
        }
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
