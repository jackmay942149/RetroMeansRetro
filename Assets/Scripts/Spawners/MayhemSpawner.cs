using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayhemSpawner : MonoBehaviour
{
    // Create a array to hold the enemy prefabs
    [SerializeField] private EnemyWeighted[] enemies;

    // Create a variable to hold the wave difficulty
    [SerializeField] private int waveWeight;
    [SerializeField] private float spawnFreq;
    [SerializeField] private float incWeightFreq;

    // Create a array to hold the y values for the spawn positions
    [SerializeField] private List<float> ySpawnPositions = new List<float>() {-0.565f,  -0.442f, -0.319f, -0.196f, -0.073f, 0.073f, 0.196f, 0.319f, 0.442f, 0.565f};

    private void Start()
    {
        InvokeRepeating("Spawn", 0.0f, spawnFreq);
        InvokeRepeating("AddWeight", incWeightFreq, incWeightFreq);
    }

    private void Spawn()
    {
        int weightRemaining = waveWeight;
        List<float> spawnPosRemaining = new List<float>();

        foreach (float f in ySpawnPositions)
        {
            spawnPosRemaining.Add(f);
        }

        while (weightRemaining > 0)
        {
            if (spawnPosRemaining.Count == 0)
            {
                Debug.Log("Spawning");
                break;
            }

            EnemyWeighted enemyToSpawn =  enemies[Random.Range(0, enemies.Length)];

            if (enemyToSpawn.Weight <= weightRemaining)
            {
                int spawnPosIndex = Random.Range(0, spawnPosRemaining.Count);
                Instantiate(enemyToSpawn.Enemy, new Vector2(1.8f, spawnPosRemaining[spawnPosIndex]), Quaternion.identity);
                weightRemaining -= enemyToSpawn.Weight;
                spawnPosRemaining.RemoveAt(spawnPosIndex);
            }
            else
            {
                weightRemaining--;
            }
        }
    }

    private void AddWeight()
    {
        waveWeight++;
    }
}
