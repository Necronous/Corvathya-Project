using System;
using UnityEngine;

[Serializable]
public class SpriteAnimation
{
    public string Name;
    
    public int FramesPerSecond;

    public bool Loop;

    public Sprite[] Frames;
}