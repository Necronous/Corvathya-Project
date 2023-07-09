using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class SpriteAnimator : MonoBehaviour
{
    private SpriteRenderer Sprite;
    public SpriteAnimation[] Animations;

    public int CurrentAnimationIndex { get; private set; }
    public int StartFrame { get; private set; }
    public int EndFrame { get; private set; }
    public int CurrentFrame { get; private set; }
    public int LoopCount { get; private set; }

    public float TimePerFrame { get; private set; }
    public float FrameTime { get; private set; }

    public bool IsPlaying { get; private set; }
    public bool HasFinished { get; private set; }

    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!IsPlaying || HasFinished)
            return;

        FrameTime += Time.deltaTime;
        if(FrameTime >= TimePerFrame)
        {
            SpriteAnimation anim = GetPlayingAnimation();
            FrameTime -= TimePerFrame;
            CurrentFrame++;
            if(CurrentFrame == EndFrame)
            {
                if (anim.Loop)
                {
                    CurrentFrame = StartFrame;
                    LoopCount++;
                }
                else
                {
                    HasFinished = true;
                    IsPlaying = false;
                    return;
                }
            }
            Sprite.sprite = anim.Frames[CurrentFrame];
        }
    }
    public void PlayAnimation(string name, int startframe = 0, int endframe = -1)
        => PlayAnimation(GetAnimationIndex(name), startframe, endframe);

    
    public void PlayAnimation(int index, int startframe = 0, int endframe = -1)
    {
        if (index < 0 || index >= Animations.Length)
            return;
        if (CurrentAnimationIndex == index && IsPlaying)
            return;

        SpriteAnimation anim = GetAnimation(index);
        
        if (endframe == -1)
            endframe = anim.Frames.Length;
        else
            endframe = Math.Clamp(endframe, 1, anim.Frames.Length);

        startframe = Math.Clamp(startframe, 0, anim.Frames.Length);

        CurrentAnimationIndex = index;
        CurrentFrame = 0;
        TimePerFrame = 1.0f / (float)anim.FramesPerSecond;
        FrameTime = 0;
        IsPlaying = true;
        HasFinished = false;
        LoopCount = 0;
        StartFrame = Math.Min(startframe, endframe);
        EndFrame = Math.Max(startframe, endframe);
        CurrentFrame = StartFrame;
    }

    public SpriteAnimation GetPlayingAnimation()
        => GetAnimation(CurrentAnimationIndex);
    public SpriteAnimation GetAnimation(int index)
        => Animations[index];
    public SpriteAnimation GetAnimation(string name)
        => Animations.First(x => x.Name == name);

    public int GetAnimationIndex(string name)
    {
        for(int i = 0; i < Animations.Length; i++)
            if (Animations[i].Name == name)
                return i;
        return -1;
    }

    public bool HasAnimation(string name)
        => GetAnimation(name) != null;
}
