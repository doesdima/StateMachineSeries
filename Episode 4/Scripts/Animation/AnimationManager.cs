using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator Animator;

    public void SetAnimation(PlayerAnimation animation)
    {
        foreach(PlayerAnimation value in Enum.GetValues(typeof(PlayerAnimation)))
        {
            //Animator.SetBool(value.ToString(), false);
        }
        Animator.SetBool(animation.ToString(), true);
    }
}

public enum PlayerAnimation
{
    Idle,
    Move,
    InAir,
    Jump
}
