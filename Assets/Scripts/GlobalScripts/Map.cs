using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void AddNPC(BaseEntityController npc)
    {
        if (_npcList.Contains(npc) || npc is PlayerController)
            return;
        _npcList.Add(npc);
    }
    public void RemoveNPC(BaseEntityController npc)
    {
        if(_npcList.Contains(npc))
            _npcList.Remove(npc);
    }

    public void AddEntrance(MapEntrance entry)
    {
        if (_mapEntrances.Contains(entry))
            return;
        _mapEntrances.Add(entry);
    }
    public void RemoveEntry(MapEntrance entry)
    {
        if(_mapEntrances.Contains(entry))
            _mapEntrances.Remove(entry);
    }
    public MapEntrance GetEntrance(string name)
        => _mapEntrances.Find(x => x.EntranceName == name);
  
    
}
