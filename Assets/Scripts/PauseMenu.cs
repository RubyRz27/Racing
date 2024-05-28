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
    public GameObject[] audioGameObjects;  // Array to hold references to GameObjects with audio sources

    //void Start()
    //{
    //    // Get all audio sources in the scene
    //    allAudioSources = FindObjectsOfType<AudioSource>();
    //}

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

        // Enable all audio GameObjects
        foreach (GameObject audioObject in audioGameObjects)
        {
            audioObject.SetActive(true);
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

        // Disable all audio GameObjects
        foreach (GameObject audioObject in audioGameObjects)
        {
            audioObject.SetActive(false);
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game..."); //This is just for debugging since the quit function never work unless it's standalone game
        Application.Quit();
    }
}
