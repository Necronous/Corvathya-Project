using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerInputHandler : MonoBehaviour
{
    /*
     * Convert const to public enums.
     */
    public const int KEY_UP = 0;
    public const int KEY_PRESSED = 1;
    public const int KEY_DOWN = 2;
    public const int KEY_RELEASED = 3;

    public const int ACTION_PAUSE = 0;
    public const int ACTION_JUMP = 1;
    public const int ACTION_LIGHTATTACK = 2;
    public const int ACTION_HEAVYATTACK = 3;

    private PlayerInput _input;

    private float _horizontalInput;
    private float _verticalInput;

    private int[] _states;

    private InputAction _horizontal;
    private InputAction _vertical;
    private InputAction _pause;
    private InputAction _jump;
    private InputAction _lightAttack;
    private InputAction _heavyAttack;

    public bool PauseInput;


    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _horizontal = _input.actions["Horizontal"];
        _vertical = _input.actions["Vertical"];
        _pause = _input.actions["Pause"];
        _jump = _input.actions["Jump"];
        _lightAttack = _input.actions["LightAttack"];
        _heavyAttack = _input.actions["HeavyAttack"];
        _states = new int[4];
    }

    void Update()
    {
        _horizontalInput = _horizontal.ReadValue<float>();
        _verticalInput = _vertical.ReadValue<float>();
        _states[ACTION_PAUSE] = ParseButtonState(_pause, _states[ACTION_PAUSE]);
        _states[ACTION_JUMP] = ParseButtonState(_jump, _states[ACTION_JUMP]);
        _states[ACTION_LIGHTATTACK] = ParseButtonState(_lightAttack, _states[ACTION_LIGHTATTACK]);
        _states[ACTION_HEAVYATTACK] = ParseButtonState(_heavyAttack, _states[ACTION_HEAVYATTACK]);
    }

    public int GetKeyState(int key)
    {
        if (PauseInput)
            return KEY_UP;
        return _states[key];
    }
    public float GetHorizontalMovement()
        => PauseInput ? 0 : _horizontalInput;
    public float GetVerticalMovement()
        => PauseInput ? 0 : _verticalInput;
    
    private int ParseButtonState(InputAction action, int oldstate)
    {
        if(action.IsPressed())
        {
            switch(oldstate)
            {
                case KEY_UP:
                case KEY_RELEASED:
                    return KEY_PRESSED;
                case KEY_PRESSED:
                case KEY_DOWN:
                    return KEY_DOWN;
            }
        }
        switch(oldstate)
        {
            case KEY_DOWN:
            case KEY_PRESSED:
                return KEY_RELEASED;
        }
        return KEY_UP;
    }
}
