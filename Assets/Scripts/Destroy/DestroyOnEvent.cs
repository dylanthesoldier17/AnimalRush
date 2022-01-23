using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
    
public class DestroyOnEvent : MonoBehaviour, IGameEventListener<string>
{
    public StringGameEvent theEvent;
    public int delayInSeconds = 1;
    private void Awake()
    {
        theEvent.AddListener(this);
    }
    
    public void OnEventRaised(string tag)
    {
        if(tag.Equals(this.name))
        {
            destroyNow();
        }
    }
    
    private void destroyNow()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        theEvent.RemoveListener(this);
    }
}
