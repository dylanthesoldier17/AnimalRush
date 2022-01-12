using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class DeathAnimationOnEvent : MonoBehaviour, IGameEventListener
{
    public StringVariable deathAnimationName;
    public GameEvent playerDeath;
    public Animator playerAnimator;

    void Start()
    {
        playerDeath.AddListener(this);
    }

    public void OnEventRaised()
    {
        playerAnimator.SetBool(deathAnimationName, true);
    }
}
