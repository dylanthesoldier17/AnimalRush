using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class IncrementScore : MonoBehaviour
{
    public StringVariable OnTriggerEnterObjectTag;
    public FloatVariable score;
    public GameEvent scoreChanged;

    private void OnTriggerEnter(Collider other)
    {
        scoreChanged.Raise();
    }
}
