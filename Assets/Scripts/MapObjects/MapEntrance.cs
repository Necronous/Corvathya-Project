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
    public DirectionEnum EntranceFacingDirection = DirectionEnum.RIGHT;


    void OnEnable()
    {
        World.Instance.AddEntrance(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (World.Instance.MapTransitionHandler.IsTransitioning)
            return;
        World.Instance.MapTransitionHandler.StartMapTransition(this);
    }
}
