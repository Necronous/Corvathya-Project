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
    
    public static World Instance { get; private set; }
    public static PlayerController Player { get; private set; }


    public MapTransitionHandler MapTransitionHandler { get; private set; }
    public SaveInterface SaveHandler { get; private set; }

    public bool WorldPaused;

    #region MapProperties
    private List<MapEntrance> _mapEntrances = new();
    private List<BaseEntityController> _npcList = new();
    
    public int MapEntityCount => _npcList.Count;
    public int MapEntranceCount => _mapEntrances.Count;
    #endregion

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);

        Application.targetFrameRate = 60;
    }
    private void Start()
    {
        MapTransitionHandler = new();
        SaveHandler = new();
        WorldVariables.Reset();
        Player = transform.Find("Player").GetComponent<PlayerController>();
        //Player.PauseInput = true;
    }


    private void Update()
    {
        if(MapTransitionHandler.IsTransitioning)
            MapTransitionHandler.Update();
    }

    /// <summary>
    /// Sets up the game from the active save file.
    /// </summary>
    public void SetupGame()
    {
        string mapname = GetMapNameByIndex(GetCurrentMapIndex());
        LoadMap(mapname);
        Player.Load();
        CameraController.Instance.SetStaticCamera();
        CameraController.Instance.SetPosition(Player.transform.position);
        CameraController.Instance.StartFade(Color.black, .5f, CameraController.Instance.SetPlayerFollowCamera, true);
        Player.PauseInput = false;
    }

    public void QuitToMainMenu()
    {
        //Assume saving has been done.
        Player.PauseInput = true;
        SceneManager.LoadScene("MainMenu");
        WorldVariables.Reset();
    }

    
    #region MapLoading

    public string GetCurrentMapName()
        => GetMapNameByIndex(GetCurrentMapIndex());
    public int GetCurrentMapIndex()
        => WorldVariables.Get<int>(WorldVariables.CURRENT_MAP_INDEX);

    public bool MapExists(string mapName)
        => GetMapIndexByName(mapName) != -1;
    public bool MapExists(int index)
        => !string.IsNullOrEmpty(GetMapNameByIndex(index));

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
        WorldVariables.Set(WorldVariables.CURRENT_MAP_INDEX, GetMapIndexByName(mapname));
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
