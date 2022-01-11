using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseEventOnKeyPressed : MonoBehaviour
{
    public KeyCode theKey;
    public GameEvent theEvent;

    public void Update()
    {
        if(Input.GetKeyDown(theKey))
        {
            theEvent.Raise();
        }
    }
}
