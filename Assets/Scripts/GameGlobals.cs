using UnityEngine;

public static class GameGlobals     // static means that it can be accessed despite not being instanced
{
    public static readonly float MOVE_SPEED = 1f;
    public static readonly float Y_THRESHHOLD = 0f;
    public static readonly float OBSTACLE_LENGTH = 40f;
    public static readonly float OBSTACLE_MOVE_SPEED = 40f;
    public static readonly Vector3 OBSTACLE_SPAWN_POINT = new(0,1,100);
    public static float TimeFactor => 1f + GameManager.TimeAlive*0.005f;      // => means that TimeFactor is re-calculated every time it is accessed.
}
