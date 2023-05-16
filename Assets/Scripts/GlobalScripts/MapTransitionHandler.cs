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

        World.Instance.WorldPaused = true;
        World.Player.PauseInput = true;

        _moveMag = (_targetEntrance.EntranceFacingDirection == DirectionEnum.RIGHT) ? -1 : 1;

    }
    private void EndMapTransition()
    {
        _targetEntrance = null;
        _transitionState = 0;
        IsTransitioning = false;

        World.Instance.WorldPaused = false;
        World.Player.PauseInput = false;

        CameraController.Instance.SetState((int)CameraModeEnum.FOLLOW_PLAYER);
    }

    private void Entering()
    {
        if(_time == 0)
            CameraController.Instance.StartFade(Color.black, _transitionTime, null, false);
        _time += Time.deltaTime;
        World.Player.MovementMagnitude = _moveMag;
        if(_time >= _transitionTime)
        {
            _time = 0;
            _transitionState++;
            World.Player.MovementMagnitude = 0;
        }
    }

    private void Loading()
    {
        string targetMap = _targetEntrance.TargetMapName;
        string targetEntry = _targetEntrance.TargetMapEntranceName;
        
        //If target map is null, then we are targeting an entrance on the currently loaded map.
        if(!string.IsNullOrEmpty(targetMap))
            World.Instance.LoadMap(targetMap);

        if (string.IsNullOrEmpty(targetEntry))
            _targetEntrance = World.Instance.GetDefaultEntrance();
        else
            _targetEntrance = World.Instance.GetEntrance(targetEntry);
        World.Instance.SetWorldVariable("player.lastentrance", World.Instance.GetEntranceIndex(_targetEntrance));

        _moveMag = (_targetEntrance.EntranceFacingDirection == DirectionEnum.RIGHT) ? 1 : -1;

        World.Player.transform.position = _targetEntrance.transform.position;
        _transitionState++;
    }

    private void Exiting()
    {
        if (_time == 0)
            CameraController.Instance.StartFade(Color.black, _transitionTime, null, true);
        _time += Time.deltaTime;
        World.Player.MovementMagnitude = _moveMag;
        if (_time >= _transitionTime)
        {
            _time = 0;
            _transitionState++;
            World.Player.MovementMagnitude = 0;
            EndMapTransition();
        }
    }

}

