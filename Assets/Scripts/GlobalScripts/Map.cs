using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// All maps must have this global script at the top of the hierarchy
/// otherwise errors will be thrown
/// </summary>
public class Map : MonoBehaviour
{
    public static Map Instance { get; private set; }

    private List<MapEntrance> _mapEntrances = new();
    private List<BaseEntityController> _npcList = new();

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;
    }

    #region Entities
    public int GetEntityCount() => _npcList.Count;
    public void AddEntity(BaseEntityController npc)
    {
        if (_npcList.Contains(npc) || npc is PlayerController)
            return;
        _npcList.Add(npc);
    }
    public void RemoveEntity(BaseEntityController npc)
    {
        if(_npcList.Contains(npc))
            _npcList.Remove(npc);
    }
    #endregion
    #region Entrances
    public int GetEntranceCount() => _mapEntrances.Count;
    public void AddEntrance(MapEntrance entry)
    {
        if (_mapEntrances.Contains(entry))
            return;
        _mapEntrances.Add(entry);
    }
    public void RemoveEntrance(MapEntrance entry)
    {
        if(_mapEntrances.Contains(entry))
            _mapEntrances.Remove(entry);
    }
    public MapEntrance GetDefaultEntrance()
    {
        MapEntrance ent = GetEntrance("");
        if(ent == null)
            ent = _mapEntrances[0];
        return ent;
    }
    public MapEntrance GetEntrance(string name)
        => _mapEntrances.Find(x => x.EntranceName == name);

    #endregion
}
