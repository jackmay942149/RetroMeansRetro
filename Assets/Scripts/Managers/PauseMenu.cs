using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void MainMenu()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        GameObject scoreManager = GameObject.FindWithTag("ScoreManager");
        Destroy(scoreManager);
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        Application.Quit();
    }
}
