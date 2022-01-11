using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class IncrementScore : MonoBehaviour
{
    public StringVariable OnTriggerEnterObjectTag;
    public FloatVariable score;
    public GameEvent scoreChanged;
    public int scoreIncrement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == OnTriggerEnterObjectTag)
        {
            score.Value += scoreIncrement;
            scoreChanged.Raise();
        }
    }
}
