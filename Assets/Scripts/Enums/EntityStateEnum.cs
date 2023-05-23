using System;
using UnityEngine;

public enum EntityStateEnum
{
    //Common
    IDLING,
    RUNNING,
    SLIDING,
    DODGING,
    HARD_TURNING,
    CROUCHING,
    JUMP_TAKINGOFF,
    JUMP_LANDING,

    FALLING,
    JUMPING,
    JUMP_APEX,

    //Player specific
    GLIDING,

    LEDGE_HANGING,
    LEDGE_CLIMBING,

    WALL_HANGING,
    WALL_RUNNING, 
    WALL_SLIDING, 
    WALL_JUMPING,

    //EnemySpecific
}
