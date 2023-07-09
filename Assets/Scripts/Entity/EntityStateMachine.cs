using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityStateMachine
{

    public interface IEntityState
    {
        public StateGroup StateGroup { get; }
        public string StateName { get; }
        

        public bool Update();
        public void FixedUpdate();
    }

    private IEntityState _currentState;
    private Dictionary<EntityState, IEntityState> _allStates = new();
    private EntityState _currentStateID, _lastStateID;

    public float CurrentStateTime { get; private set; }
    public float LastStateTime { get; private set; }

    public EntityState GetCurrentStateID() => _currentStateID;
    public EntityState GetLastStateID() => _lastStateID;

    public StateGroup GetCurrentStateGroup() => _currentState.StateGroup;
    public StateGroup GetStateGroup(EntityState id) => _allStates[id].StateGroup;
    public string GetCurrentStateName() => _currentState.StateName;
    public string GetStateName(EntityState id) => _allStates[id].StateName;

    public bool StateExists(EntityState state) => _allStates.ContainsKey(state);

    public bool RegisterState(EntityState stateid, IEntityState state, bool replace = false)
    {
        if(StateExists(stateid))
        {
            if (!replace)
                return false;
            _allStates[stateid] = state;
            return true;
        }
        _allStates.Add(stateid, state);
        return true;
    }
    public bool RemoveState(EntityState stateid)
    {
        if(StateExists(stateid))
        {
            _allStates.Remove(stateid);
            return true;
        }
        return false;
    }

    public bool SetState(EntityState stateid)
    {
        if (!StateExists(stateid))
            return false;
        _lastStateID = _currentStateID;
        LastStateTime = CurrentStateTime;
        CurrentStateTime = 0;
        _currentStateID = stateid;
        _currentState = _allStates[stateid];

        return true;
    }

    public void Update()
    {
        CurrentStateTime += Time.deltaTime;

        byte loopcount = 0;
        while(!_currentState.Update())
        {
            loopcount++;
            if (loopcount >= 100)
                throw new Exception($"[EntityStateMachine] Infinite loop detected on state {GetCurrentStateName()}");
        }
    }
    public void FixedUpdate()
    {
        _currentState?.FixedUpdate();
    }
}
