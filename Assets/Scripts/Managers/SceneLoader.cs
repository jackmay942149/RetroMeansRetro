using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Create reference to the mode manager
    [SerializeField] private GameObject modeManager;
    private string mode;

    public void InsertCoins()
    {
        mode = modeManager.GetComponent<ModeManager>().ReturnMode();
        if (mode == "Mode: Normal")
        {
            StartNormal();
        }
        else if (mode == "Mode: Mayhem")
        {
            StartMayhem();
        }
        else if (mode == "Mode: Screensaver")
        {
            StartScreenSaver();
        }
    }

    // Function to quit game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Function to start game
    public void StartMayhem()
    {
        SceneManager.LoadScene("Mayhem");
    }

    public void StartNormal()
    {
        SceneManager.LoadScene("Normal");
    }

    public void StartScreenSaver()
    {
        SceneManager.LoadScene("ScreenSaver");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
