using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEntrance : MonoBehaviour
{
    [SerializeField]
    public string EntranceName = "";
    [SerializeField]
    public string TargetMapName = "";
    [SerializeField]
    public string TargetMapEntranceName = "";

    void Start()
    {
        if (Map.Instance.GetEntrance(EntranceName) != null)
            return;
        Map.Instance.AddEntrance(this);
    }

    public void Activate()
    {
        //If mapname is null the entrance points to an entrance on this map.
        if(string.IsNullOrEmpty(TargetMapName))
        {
            MapEntrance e = Map.Instance.GetEntrance(TargetMapEntranceName);
            if (e == null)
                return;
            World.Player.transform.position = e.transform.position;
        }
        else
        {
            World.Instance.LoadMapWithEntrance(TargetMapName, TargetMapEntranceName);
        }
    }
}
