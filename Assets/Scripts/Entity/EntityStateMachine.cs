using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStateMachine
{
    private Dictionary<int, Func<BaseEntityController, bool>> _states = new();
    private Func<BaseEntityController, bool> _activeState;

    public int CurrentState { get; private set; }
    public int LastState { get; private set; }
    public float CurrentStateTime { get;private set; }
    public float LastStateTime { get;private set; }

    public void UpdateMachine(BaseEntityController entity)
    {
        CurrentStateTime += Time.deltaTime;

        //If the state return true break the loop;
        //If the state returns false it means the state was changed and the next state must be updated immediatly.
#if DEBUG
        byte maxloopcount = 0;
#endif
        while (!_activeState(entity))
        {
#if DEBUG
            maxloopcount++;
            if(maxloopcount == 100)
            {
                Debug.LogError($"EntityStateMachine.cs \"{entity.name}\" stuck in infinite loop! CurrentState:{CurrentState}");
                SetState(0); //Attempt to change state to prevent constant infinite looping.
                break;
            }
#endif
        }
    }

    /// <summary>
    /// Check is a state already exists in the machine.
    /// </summary>
    /// <param name="id">ID of the state.</param>
    /// <returns></returns>
    public bool HasState(int id) => _states.ContainsKey(id);


    /// <summary>
    /// Registers a new state.
    /// </summary>
    /// <param name="state">Id of the state.</param>
    /// <param name="fun">Function to use.</param>
    /// <returns></returns>
    public bool RegisterState(int id, Func<BaseEntityController, bool> function, bool replace = false)
    {
        if (HasState(id))
        {
            if (!replace)
                return false;
            _states[id] = function;
            return true;
        }
        _states.Add(id, function);
        return true;
    }

    /// <summary>
    /// Removes a state from the machine if it exists.
    /// </summary>
    /// <param name="id">ID of the state to remove.</param>
    public bool DeRegisterState(int id)
    {
        if (HasState(id))
        {
            _states.Remove(id);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Sets the currently active state.
    /// </summary>
    /// <param name="id">ID of the state to set active.</param>
    /// <returns>Returns false if state does not exist.</returns>
    public bool SetState(int id)
    {
        if (!HasState(id))
            return false;

        LastState = CurrentState;
        LastStateTime = CurrentStateTime;
        CurrentStateTime = 0;
        CurrentState = id;

        _activeState = _states[id];

        return true;
    }

}
