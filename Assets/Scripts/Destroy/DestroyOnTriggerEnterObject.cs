using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTriggerEnterObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        #if UNITY_EDITOR
            Debug.Log($"{other.name} hit {gameObject.name}, Destroyed {other.gameObject.name}");
        #endif
        Destroy(other.gameObject);
    }
}
