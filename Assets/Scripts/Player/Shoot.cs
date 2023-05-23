using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Create a reference to the bubble prefab
    [SerializeField] private GameObject bubble;

    // Create a reference to the flower prefab
    [SerializeField] private GameObject flower;

    private void Update()
    {
        // Spawn bubble when shooting
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bubble, transform);
        }

        // Spawn flower when alternate firing
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(flower, transform);
        }
    }
}
