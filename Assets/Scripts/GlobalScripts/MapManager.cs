
using System.Collections.Generic;
using System.IO;
using UnityEngine.SceneManagement;

public class MapManager
{
    #region Singleton

    public static MapManager Instance { get; private set; }

    public static void Create()
    {
        if (Instance != null)
            return;
        Instance = new MapManager();
        Instance.Initialize();
    }

    private MapManager() { }

    #endregion

    private MapTransitionHandler _transitionHandler;

    public string CurrentMapName { get; private set; }
    public int CurrentMapIndex { get; private set; }

    public List<MapEntrance> MapEntrances { get; private set; }
    public List<BaseEntityController> MapEntities { get; private set; }

    private void Initialize()
    {
        _transitionHandler = new();
        MapEntrances = new();
        MapEntities = new();
    }

    public void Update()
    {
        if(_transitionHandler.IsTransitioning)
            _transitionHandler.Update();
    }

    public void StartMapTransition(MapEntrance entry)
        => _transitionHandler.StartMapTransition(entry);
    public bool IsMapTransition()
        => _transitionHandler.IsTransitioning;

    public void LoadMap(string name)
    {
        if (!MapExists(name) || name == CurrentMapName)
            return;
        SceneManager.LoadScene(name);
        CurrentMapName = name;
        CurrentMapIndex = GetMapIndexFromName(name);
        WorldVariables.Set(WorldVariables.CURRENT_MAP_INDEX, CurrentMapIndex);
    }
    public void LoadMap(int index)
        => LoadMap(GetMapNameFromIndex(index));

    public int GetMapIndexFromName(string name)
        => SceneUtility.GetBuildIndexByScenePath(name);
    public string GetMapNameFromIndex(int index)
        => Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(index));
    
    public bool MapExists(string name)
        => GetMapIndexFromName(name) != -1;
    public bool MapExists(int index)
        => !string.IsNullOrEmpty(GetMapNameFromIndex(index));

    public bool HasEntity(BaseEntityController e)
        => MapEntities.Contains(e);
    public void AddEntity(BaseEntityController e)
        => MapEntities.Add(e);
    public void RemoveEntity(BaseEntityController e)
        => MapEntities.Remove(e);
    

    public void HasEntrance(MapEntrance entry)
        => MapEntrances.Contains(entry);
    public void AddEntrance(MapEntrance entry)
        => MapEntrances.Add(entry);
    public void RemoveEntrance(MapEntrance entry)
        => MapEntrances.Remove(entry);
    
    public int GetEntranceIndex(MapEntrance entry)
        => MapEntrances.IndexOf(entry);
    public MapEntrance GetEntrance(int index)
        => MapEntrances[index];
    public MapEntrance GetEntrance(string name)
        => MapEntrances.Find(x => x.EntranceName == name);
}
