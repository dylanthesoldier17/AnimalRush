using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class DeathAnimationOnEvent : StateMachineBehaviour, IGameEventListener
{
    public GameEvent playerDeathEvent;
    private Animator animator1;
    public string deathAnimationName;

    public void OnEventRaised()
    {
        animator1.SetBool(deathAnimationName, true);
    }

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator1 = animator;
        playerDeathEvent.AddListener(this);
    }
}
