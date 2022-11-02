using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array to store Enemy Ships
    private float spawnRangeX = 60f;
    private float spawnPosZ = 20f;
    private float startDelay = 4f;
    private float spawnInterval = 2.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int enemyIndex = Random.Range(0,enemyPrefabs.Length); // Picks a random enemy
        Instantiate(enemyPrefabs[enemyIndex],spawnPos, enemyPrefabs[enemyIndex].transform.rotation); // Spawns enemy from array on X
    }
}
