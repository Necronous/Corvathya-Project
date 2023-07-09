using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntityAnimation : MonoBehaviour
{
    public Animator Animator { get; private set; }

    private AnimationClip[] _clips;
    private AnimationClip _currentAnimation;

    private void Start()
    {
        Animator = transform.Find("Sprite").GetComponent<Animator>();
        _clips = Animator.runtimeAnimatorController.animationClips;
    }

    public void Play(string name)
    {
        if (_currentAnimation != null && _currentAnimation.name == name)
            return;
        if (!HasAnimation(name))
            return;

        _currentAnimation = GetAnimationClip(name);
        Animator.Play(name);
    }

    public bool HasEnded()
        => GetCurrentAnimationTime() >= GetCurrentAnimationLength();
    public bool IsLooping()
        => _currentAnimation.wrapMode == WrapMode.Loop;

    public int GetCurrentLoopCount()
    {
        AnimatorStateInfo info = Animator.GetCurrentAnimatorStateInfo(0);
        return Mathf.FloorToInt(info.normalizedTime);
    }
    public float GetCurrentAnimationTime()
    {
        AnimatorStateInfo info = Animator.GetCurrentAnimatorStateInfo(0);
        float diff = info.normalizedTime - Mathf.Floor(info.normalizedTime);
        return diff * info.length;
    }
    public float GetCurrentAnimationLength()
        => _currentAnimation == null ? 0 : _currentAnimation.length;

    public bool HasAnimation(string name)
    {
        for (int i = 0; i < _clips.Length; i++)
            if (_clips[i].name == name)
                return true;
        return false;
    }
    public AnimationClip GetAnimationClip(string name)
    {
        for(int i = 0; i < _clips.Length; i++)
            if (_clips[i].name == name)
                return _clips[i];
        return null;
    }
}
