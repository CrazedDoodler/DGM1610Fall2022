using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnManager : MonoBehaviour
{
   public GameObject[] itemPrefabs; // Array to store Enemy Ships
    private float spawnRangeX = 60f;
    private float spawnPosZ = 35f;
    private float startDelay = 7f;
    private float spawnInterval = 5.5f;
    void Start()
    {
        InvokeRepeating("SpawnItem", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    void SpawnItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int itemIndex = Random.Range(0,itemPrefabs.Length); // Picks a random enemy
        Instantiate(itemPrefabs[itemIndex],spawnPos, itemPrefabs[itemIndex].transform.rotation); // Spawns enemy from array on X
    }
}
