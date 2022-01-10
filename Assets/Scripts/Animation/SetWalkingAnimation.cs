using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWalkingAnimation : MonoBehaviour
{
    public Animator entityAnimator;

    private void Start()
    {
        entityAnimator.SetFloat("Speed_f", 1);
    }
}
