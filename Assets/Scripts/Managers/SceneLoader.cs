using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Function to quit game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Function to start game
    public void StartGame()
    {
        SceneManager.LoadScene("Endless");
    }
}
