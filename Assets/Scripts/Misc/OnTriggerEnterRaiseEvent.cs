using UnityEngine;
using ScriptableObjectArchitecture;

public class OnTriggerEnterRaiseEvent : MonoBehaviour
{
    public GameEvent raiseEvent;

    private void OnTriggerEnter(Collider other) 
    {
        raiseEvent.Raise();
    }
}
