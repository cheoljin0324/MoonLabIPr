using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _frontAnimator = null;

    [SerializeField]
    private Animator[] _backAnimator = null;

    public void PlayMoveAnimation()
    {
        _frontAnimator.SetBool("IsMove", true);
        foreach (var animator in _backAnimator)
        {
            animator.SetBool("IsMove", true);
        }
    }

    public void PlayStopAnimation()
    {
        _frontAnimator.SetBool("IsMove", false);
        foreach (var animator in _backAnimator)
        {
            animator.SetBool("IsMove", false);
        }
    }
}
