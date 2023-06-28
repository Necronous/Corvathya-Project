using System;
using System.Collections.Generic;
using UnityEngine;


public class MapTransitionHandler
{
    public bool IsTransitioning;

    private MapEntrance _targetEntrance;
    private byte _transitionState;
    private float _moveMag;
    private float _time;
    private float _transitionTime = .5f;

    public void Update()
    {
        switch (_transitionState)
        {
            case 0: Entering(); break;
            case 1: Loading(); break;
            case 2: Exiting(); break;
        }
    }

    public void StartMapTransition(MapEntrance entry)
    {
        _targetEntrance = entry;
        _transitionState = 0;
        IsTransitioning = true;
        _time = 0;

        PlayerController.Instance.PauseInput = true;

        _moveMag = (_targetEntrance.EntranceFacingDirection == Direction.RIGHT) ? -1 : 1;
        CameraController.Instance.StartFade(Color.black, _transitionTime, null, false);
    }

    private void Entering()
    {
        _time += Time.deltaTime;
        PlayerController.Instance.MovementMagnitude = _moveMag;
        if(_time >= _transitionTime)
        {
            _time = 0;
            _transitionState++;
            PlayerController.Instance.MovementMagnitude = 0;
        }
    }

    private void Loading()
    {
        string targetMap = _targetEntrance.TargetMapName;
        string targetEntry = _targetEntrance.TargetMapEntranceName;
        
        //If target map is null, then we are targeting an entrance on the currently loaded map.
        if(!string.IsNullOrEmpty(targetMap))
            MapManager.Instance.LoadMap(targetMap);

        _targetEntrance = MapManager.Instance.GetEntrance(targetEntry);
        
        WorldVariables.Set(WorldVariables.PLAYER_LAST_ENTRANCE, MapManager.Instance.GetEntranceIndex(_targetEntrance));

        _moveMag = (_targetEntrance.EntranceFacingDirection == Direction.RIGHT) ? 1 : -1;

        PlayerController.Instance.transform.position = _targetEntrance.transform.position;
        _transitionState++;
        CameraController.Instance.StartFade(Color.black, _transitionTime, null, true);

    }

    private void Exiting()
    {
        _time += Time.deltaTime;
        PlayerController.Instance.MovementMagnitude = _moveMag;
        if (_time >= _transitionTime)
        {
            _time = 0;
            _transitionState++;
            PlayerController.Instance.MovementMagnitude = 0;
            EndMapTransition();
        }
    }

    private void EndMapTransition()
    {
        _targetEntrance = null;
        _transitionState = 0;
        IsTransitioning = false;

        PlayerController.Instance.PauseInput = false;

        CameraController.Instance.SetPlayerFollowCamera();
    }
}

