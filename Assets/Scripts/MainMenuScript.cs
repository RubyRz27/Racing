using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Method to load the racing scene (nah it's not really a racing scene, it's just there to trick the player
    public void StartRace()
    {
        SceneManager.LoadScene("LevelSelectScene"); // Replace later
    }

    // Method to load the settings scene
    public void OpenSettings()
    {
        // Load the settings scene or open settings panel
        SceneManager.LoadScene("SettingsScene"); // Replace "SettingsScene" with the name of your settings scene if you have one
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit();
        // Note: This will not work in the editor. It only works in the built application.
        Debug.Log("Quit Game"); // This is for testing in the editor
    }
}
