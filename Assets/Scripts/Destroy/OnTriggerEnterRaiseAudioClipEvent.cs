using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
public class OnTriggerEnterRaiseAudioClipEvent : MonoBehaviour
{
    public AudioClip theClip;
    public AudioClipGameEvent theEvent;
    public StringVariable matchTag;
    
    public void OnTriggerEnter(Collider other)
    {
        if (matchTag == null)
        {
            theEvent.Raise(theClip);
            return;
        }
        
        if(other.name.Equals(matchTag.Value))
            theEvent.Raise(theClip);
    }
}
