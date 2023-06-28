using System;
using UnityEngine;

public enum EntityState
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

    LEDGE_GRABBING,
    LEDGE_CLIMBING,

    WALL_HANGING,
    WALL_RUNNING, 
    WALL_SLIDING, 
    WALL_JUMPING,

    GROUND_LIGHT_ATTACK,
    GROUND_HEAVY_ATTACK,
    AIR_LIGHT_ATTACK,
    AIR_HEAVY_ATTACK,

    //EnemySpecific
}
