using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreManager : MonoBehaviour
{
    // Create a variable to hold Score Manager
    private GameObject scoreManager;

    // Create a variable to hold TextMeshes
    [SerializeField] private TextMeshProUGUI scoreObj;
    [SerializeField] private TextMeshProUGUI highScoreObj;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreManager.GetComponent<ScoreManager>().SaveHighScore();

        scoreObj.text = "Score: " + scoreManager.GetComponent<ScoreManager>().GetScore();
        highScoreObj.text = "High Score: " + scoreManager.GetComponent<ScoreManager>().GetHighScore();
        Destroy(scoreManager);
    }
}
