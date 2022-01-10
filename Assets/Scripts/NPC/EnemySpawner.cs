using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float xLeftBounds, xRightBounds;
    public float yPosition, zPosition;
    public GameObject[] enemies;
    public float initialSpawnDelayInSeconds = 3;
    public float spawnRateInSeconds = 1;
    public bool enableSpawner = false;
    public Quaternion startingRotation;

    private void Start() 
    {
        InvokeRepeating("spawnEnemy", initialSpawnDelayInSeconds, spawnRateInSeconds);
    }

    private void spawnEnemy()
    {
        if(enableSpawner)
        {
            int index = Random.Range(0, enemies.Length);
            float randomXPosition = Random.Range(xLeftBounds, xRightBounds); 
            Instantiate(enemies[index], new Vector3(randomXPosition, yPosition, zPosition), startingRotation);
        }
        
    }
}
