using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Create a variable to hold the score
    [SerializeField] private int score;

    // Create a reference to the text component
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        text.text = "Score: " + score.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        this.score += scoreToAdd;
    }

    private void SaveHighScore()
    {
        if (PlayerPrefs.HasKey("EndlessHighScore"))
        {
            if (score > PlayerPrefs.GetInt("EndlessHighScore"))
            {
                PlayerPrefs.SetInt("EndlessHighScore", score);
                PlayerPrefs.Save();
            }
        }
        else
        {   
            PlayerPrefs.SetInt("EndlessHighScore", score);
            PlayerPrefs.Save();
        }
    }
}
