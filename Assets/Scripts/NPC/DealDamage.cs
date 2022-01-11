using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class DealDamage : MonoBehaviour
{
    public int damageToApply;
    public GameEvent damageDealtEvent;
    public IntVariable health;
    public StringVariable triggerTag;

    public void apply()
    {
        health.Value -= damageToApply;
        damageDealtEvent.Raise();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == triggerTag)
        {
            apply(); //Apply Damage
        }
    }
}
