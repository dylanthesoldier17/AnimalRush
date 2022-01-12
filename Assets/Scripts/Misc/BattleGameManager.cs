using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class BattleGameManager : MonoBehaviour
{
    public GameEvent gameStartEvent;
    
    private void Awake() 
    {
        #if UNITY_EDITOR
            Debug.Log($"Raising game start event");
        #endif

        gameStartEvent.Raise();    
    }
}
