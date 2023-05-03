using System;
using UnityEngine;


//Add all entity states here.
//If its a state specific to an entity prefix it with entity type 
//IE BOSSNAME_SPECIAL_ATTACK,
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
    GROUND_SLAM_EXIT,//NOT IMPLEMENTED. Triggers after Ground_slam lands.Used to check for superjump input.

    WALL_HANG,//NOT IMPLEMENTED. Hanging in place on wall (Not ledge)
    WALL_RUN, //NOT IMPLEMENTED. Running up a wall
    WALL_SLIDE, //NOT IMPLEMENTED. Sliding down a wall.
}
