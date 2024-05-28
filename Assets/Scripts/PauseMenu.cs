using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Them variables
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject[] otherUIElements;  // Array to hold references to other UI elements

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        // Re-enable other UI elements
        foreach (GameObject uiElement in otherUIElements)
        {
            uiElement.SetActive(true);
        }
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        // Disable other UI elements
        foreach (GameObject uiElement in otherUIElements)
        {
            uiElement.SetActive(false);
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
