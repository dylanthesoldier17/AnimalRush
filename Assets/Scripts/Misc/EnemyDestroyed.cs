using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
public class EnemyDestroyed : MonoBehaviour
{
    public StringVariable projectileTag;
    public GameEvent enemyDestroy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(projectileTag))
        {
            enemyDestroy.Raise();
        }
    }
}
