using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class LevelManager : MonoBehaviour, IGameEventListener
{
    public GameEvent enemyDestroyed;
    public GameEvent levelCompleted;
    public IntGameEvent enemiesLeft;
    public int enemiesToDestroy;
    private int counter = 0;
    private void Awake()
    {
        enemyDestroyed.AddListener(this);
        enemiesLeft?.Raise(enemiesToDestroy);
    }

    public void OnEventRaised()
    {
        counter++;
        if (counter >= enemiesToDestroy)
        {
            levelCompleted.Raise();
        }
        
        enemiesLeft?.Raise(enemiesToDestroy-counter);
    }
}