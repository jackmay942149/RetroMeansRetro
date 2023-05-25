using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByFlower : MonoBehaviour
{
    // Create a reference to the score manager
    private ScoreManager scoreManager;

    // Create a variable to hold the score if you destroy object
    [SerializeField] private int score;

    private void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Flower")
        {
            scoreManager.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
