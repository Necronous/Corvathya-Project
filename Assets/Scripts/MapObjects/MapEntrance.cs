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
    [SerializeField]
    public Direction EntranceFacingDirection = Direction.RIGHT;


    void Start()
    {
        MapManager.Instance.AddEntrance(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (MapManager.Instance.IsMapTransition())
            return;
        MapManager.Instance.StartMapTransition(this);
    }
}
