using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class EnemySpawner : MonoBehaviour
{
    public float xLeftBounds, xRightBounds;
    public float yPosition, zPosition;
    public GameObjectCollection enemiesCollection;
    public float initialSpawnDelayInSeconds = 3;
    public float spawnRateInSeconds = 1;
    public bool enableSpawner = false;
    public Quaternion startingRotation;

    private void Start() 
    {
        // Create Timer to spawn enemy
        InvokeRepeating("spawnEnemy", initialSpawnDelayInSeconds, spawnRateInSeconds);
    }

    private void spawnEnemy()
    {
        if(enableSpawner)
        {
            int index = Random.Range(0, enemiesCollection.Count);
            float randomXPosition = Random.Range(xLeftBounds, xRightBounds); 
            Instantiate(enemiesCollection[index], new Vector3(randomXPosition, yPosition, zPosition), startingRotation);
        }
        
    }

    #region eventable_functions

    public void startSpawner()
    {
        enableSpawner = true;
    }

    public void stopSpawner()
    {
        enableSpawner = false;
    }

    #endregion eventable_functions
}
