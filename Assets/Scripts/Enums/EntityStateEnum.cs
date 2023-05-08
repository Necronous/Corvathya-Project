using System;
using UnityEngine;


//Add all entity states here.
public enum EntityStateEnum
{
    IDLE,
    MOVING,
    DASHING,//NOT IMPLEMENTED
    HARD_TURN, //NOT IMPLEMENTED, When entity turns around while velocity is high.
    CROUCHING,

    FALLING,
    JUMP_TAKEOFF,
    AIR_LAND,

    GLIDING,
    //Glide land state?

    LEDGE_HANG,
    LEDGE_CLIMB,

    GROUND_SLAM,//NOT IMPLEMENTED. Same as falling, Higher gravity less horizontal movement speed?
    GROUND_SLAM_EXIT,//NOT IMPLEMENTED. Triggers after Ground_slam lands.Used to check for superjump input. And do damage / effects.

    WALL_HANG,
    WALL_RUN, 
    WALL_SLIDE, 
    WALL_KICK_OFF,

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
