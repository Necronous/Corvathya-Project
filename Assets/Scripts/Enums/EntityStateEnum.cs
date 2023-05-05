using System;
using UnityEngine;


//Add all entity states here.
public enum EntityStateEnum
{
    IDLE,
    MOVING,
    DASHING,//NOT IMPLEMENTED
    HARD_TURN, //NOT IMPLEMENTED, When entity turns around while velocity is high.

    FALLING,
    JUMP_TAKEOFF,
    JUMP_LAND, //NOT IMPLEMENTED.

    GLIDING,//NOT IMPLEMENTED.

    LEDGE_HANG,//NOT IMPLEMENTED.
    LEDGE_CLIMB,//NOT IMPLEMENTED.

    GROUND_SLAM,//NOT IMPLEMENTED. Same as falling, Higher gravity less horizontal movement speed?
    GROUND_SLAM_EXIT,//NOT IMPLEMENTED. Triggers after Ground_slam lands.Used to check for superjump input. And do damage / effects.

    WALL_HANG,//NOT IMPLEMENTED. Hanging in place on wall (Not ledge)
    WALL_RUN, //NOT IMPLEMENTED. Running up a wall
    WALL_SLIDE, //NOT IMPLEMENTED. Sliding down a wall.


    //ATTACK TYPES
    MELEE_ATTACK,
    HEAVY_MELEE_ATTACK,
    FAST_MELEE_ATTACK,
    STAGGER_MELEE_ATTACK,
    CHARGE_ATTACK,
    JUMP_ATTACK,
    AOE_ATTACK,
    BACKWARDS_ATTACK,
    COMBO_ATTACK,
    RANGED_ATTACK,
    HEAVY_RANGED_ATTACK,
    FAST_RANGED_ATTACK,
    ATTACK_COOLDOWN,
}
