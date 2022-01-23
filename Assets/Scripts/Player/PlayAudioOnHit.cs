using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
public class PlayAudioOnHit : MonoBehaviour
{
    public StringVariable executeWhenNameIs;
    public AudioClipGameEvent theClipEvent;
    public AudioClip theClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals(executeWhenNameIs))
        {
            theClipEvent.Raise(theClip);
        }
    }
}
