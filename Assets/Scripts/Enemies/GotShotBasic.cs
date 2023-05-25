using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotShotBasic : MonoBehaviour
{
    // Create a variable for health
    [SerializeField] private int health;

    // Crete a holder for the score manager
    private ScoreManager scoreManager;

    // Create a variable to hold the score if you destroy object
    [SerializeField] private int score;


    private void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    private void Update()
    {
        if (health == 0)
        {
            scoreManager.AddScore(score);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bubble")
        {
            health--;
        }

        Destroy(collider.gameObject, 0.01f);
    }
}
