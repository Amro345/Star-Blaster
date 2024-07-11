using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnrangeX = 12;
    private float spawnposz = 5;
    private float startDelay = 2;
    private float spawnInterval = 0.9f;
    private bool isSpawning = true; // Track if spawning is active
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomenemy", startDelay, spawnInterval);
    }
    // Function to stop spawning enemies
   
    
    void spawnRandomenemy()
    {
        if (isSpawning)
        {
            Vector3 spawnpos = new Vector3(Random.Range(2, spawnrangeX), 7, spawnposz);
            int enemyindex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyindex], spawnpos, enemyPrefabs[enemyindex].transform.rotation);
        }
    }
    public void StopSpawning()
    {
        // Stop spawning enemies
        CancelInvoke("SpawnRandomEnemy");
    }
}
