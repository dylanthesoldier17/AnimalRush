using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseEventOnKeyDown : MonoBehaviour
{
    public IntGameEvent raiseEvent;
    public KeyCode theKey;

    private void Update() 
    {
        if(Input.GetKeyDown(theKey))
        {
            raiseEvent.Raise((int)theKey);
        }
    }
}
