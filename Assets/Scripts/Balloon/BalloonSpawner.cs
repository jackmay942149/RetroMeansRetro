using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    // Create a variables for spawn frequency
    [SerializeField] private int minSpawnRate; // # of frames
    [SerializeField] private int maxSpawnRate;
    private int currSpawnRate;

    // Create a variable for a frame counter
    private int framesSinceSpawn;

    // Create Variables to hold spawn position
    [SerializeField] private float spawnPosX;
    [SerializeField] private float spawnPosY;

    // Create a reference to the ballon prefab
    [SerializeField] private GameObject balloon;

    private void Start()
    {
        framesSinceSpawn = 0;
        currSpawnRate = Random.Range(minSpawnRate, maxSpawnRate);
    }

    private void FixedUpdate()
    {
        framesSinceSpawn++;
        if (framesSinceSpawn >= currSpawnRate)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Vector2 spawnPos = new Vector2(spawnPosX, spawnPosY);
        Instantiate(balloon, spawnPos, Quaternion.identity);
        framesSinceSpawn = 0;
        currSpawnRate = Random.Range(minSpawnRate, maxSpawnRate);
    }
}
