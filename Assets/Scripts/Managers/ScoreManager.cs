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

    // Create a string for the name of the high score affected in the gamemode
    [SerializeField] private string scoreMode;

    private void Start()
    {
        score = 0;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        text.text = "Score: " + score.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        this.score += scoreToAdd;
    }

    public void SaveHighScore()
    {
        if (PlayerPrefs.HasKey(scoreMode))
        {
            if (score > PlayerPrefs.GetInt(scoreMode))
            {
                PlayerPrefs.SetInt(scoreMode, score);
                PlayerPrefs.Save();
            }
        }
        else
        {   
            PlayerPrefs.SetInt(scoreMode, score);
            PlayerPrefs.Save();
        }
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(scoreMode);
    }
}
