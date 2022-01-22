using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseGameEventOnLifecycle : MonoBehaviour
{
    public bool enableEvents = true;
    public enum lifecycleMethod { NONE, START, AWAKE, ON_DESTROY, ON_ENABLE, ON_DISABLE, ON_TRIGGER_ENTER, ON_TRIGGER_EXIT }
    public lifecycleMethod selectLiftcycleMethod = lifecycleMethod.NONE;
    public GameEvent[] gameEvents;

    // Start is called before the first frame update
    private void Start()
    {
        if(selectLiftcycleMethod == lifecycleMethod.START && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void Awake() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.AWAKE && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void OnDestroy() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_DESTROY && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void OnDisable() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_DISABLE && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void OnEnable() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_ENABLE && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_TRIGGER_ENTER && enableEvents == true)
        {
            raiseEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_TRIGGER_EXIT && enableEvents == true)
        {
            raiseEvent();
        }
    }

    public void raiseEvent()
    {
        foreach(GameEvent gameEvent in gameEvents)
        {
            gameEvent.Raise();
        }
    }
}