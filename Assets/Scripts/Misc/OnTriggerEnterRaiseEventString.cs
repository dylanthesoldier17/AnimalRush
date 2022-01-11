using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class OnTriggerEnterRaiseEventString : MonoBehaviour
{
    public StringGameEvent raiseEvent;
    public StringVariable objectRaised;

    private void OnTriggerEnter(Collider other) 
    {
        raiseEvent.Raise(objectRaised);    
    }
}
