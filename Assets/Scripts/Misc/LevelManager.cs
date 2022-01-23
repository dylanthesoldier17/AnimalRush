using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelManager : MonoBehaviour
{
    public StringGameEvent enemyDestroyed;
    public GameEvent levelCompleted;
    public IntGameEvent enemiesLeftEvent;
    public int enemiesToDestroy;
    private int _enemiesDestroyedCounter = 0;
    
    private void Awake()
    {
        enemyDestroyed.AddListener(HandleEnemyDestroyedEvent);
    }

    private void HandleEnemyDestroyedEvent()
    {
        _enemiesDestroyedCounter++;
        if (_enemiesDestroyedCounter >= enemiesToDestroy)
        {
            levelCompleted.Raise();
        }
        
        RaiseEventEnemiesLeft();
    }

    public void RaiseEventEnemiesLeft()
    {
        enemiesLeftEvent.Raise(enemiesToDestroy-_enemiesDestroyedCounter);
    }
}