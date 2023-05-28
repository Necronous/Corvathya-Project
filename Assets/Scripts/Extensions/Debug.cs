using System;
using UnityEngine;

public class DebugExtensions
{
    public static void DrawBox(Vector2 start, Vector2 end, Color color)
    {
        Debug.DrawLine(start, new Vector2(end.x, start.y), color);
        Debug.DrawLine(new Vector2(start.x, end.y), end, color);
        Debug.DrawLine(start, new Vector2(start.x, end.y), color);
        Debug.DrawLine(new Vector2(end.x, start.y), end, color);
    }
}
