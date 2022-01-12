using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameStateManager : MonoBehaviour {

    public GameEvent levelWonEvent;
    public GameEvent gameOverEvent;

    public void enableLoseState()
    {
        #if UNITY_EDITOR
            Debug.Log("Enable Lose State");
        #endif

        gameOverEvent.Raise();
    }
    
    public void enableWinState()
    {
        #if UNITY_EDITOR
            Debug.Log("Enable Lose State");
        #endif

        levelWonEvent.Raise();
    }
    
}
