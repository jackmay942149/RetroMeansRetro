using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Create reference to the mode manager
    [SerializeField] private GameObject modeManager;
    private string mode;

    // Reference the sound for starting the game
    [SerializeField] private AudioSource startGameSound;
    [SerializeField] private AudioSource mainMenuSound;

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
        DontDestroyOnLoad(this);
        startGameSound.Play();
        SceneManager.LoadScene("Mayhem");
        Destroy(this, 1.0f);
    }

    public void StartNormal()
    {
        DontDestroyOnLoad(this);
        startGameSound.Play();
        SceneManager.LoadScene("Normal");
        Destroy(this, 1.0f);
    }

    public void StartScreenSaver()
    {
        DontDestroyOnLoad(this);
        startGameSound.Play();
        SceneManager.LoadScene("ScreenSaver");
        Destroy(this, 1.0f);
    }

    public void MainMenu()
    {
        DontDestroyOnLoad(this);
        mainMenuSound.Play();
        SceneManager.LoadScene("Menu"); 
        Destroy(this, 1.0f);
    }
}
