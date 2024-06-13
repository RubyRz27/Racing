using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapTrigger : MonoBehaviour
{
    //Variables for lap counting
    private int playerLastLap; // Tracks player's previous lap
    private int aiLastLap; // Tracks AI's previous lap (GameObject: AI vehicle, int: previous lap)
    public Text lapText; // Reference to UI Text element (assign in Inspector)
    public int lapAmount;
    private int playerCurrentLap;
    private int aicurrentLap;

    //Them variables for Win/Lose UI
    public static bool GameIsPaused = false;
    public GameObject winMenuUI;
    public GameObject loseMenuUI;
    public GameObject[] otherUIElements;  // Array to hold references to other UI elements
    public GameObject[] audioGameObjects;  // Array to hold references to GameObjects with audio sources

    void Start()
    {
        playerLastLap = 0; // Initialize player lap at 0
        aiLastLap = 0; // Initialize AI lap dictionary
        lapText.text = "Lap: " + playerLastLap + "/" + lapAmount; // Set initial lap text on UI
        winMenuUI.SetActive(false);
        loseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // Check for player collision
        {
             playerCurrentLap = playerLastLap + 1; // Increment player lap

            if (/*playerCurrentLap > lapAmount && */playerCurrentLap == 5 && aicurrentLap == 4) // Check if race is finished (replace with your total laps variable)
            {
                winMenuUI.SetActive(true);
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
            else
            {
                playerLastLap = playerCurrentLap; // Update player lap
                lapText.text = "Lap: " + playerCurrentLap + "/" + lapAmount; // Update lap text on UI
                GameIsPaused = false;
            }
        }
        else if (other.gameObject.tag.StartsWith("AI")) // Check for AI collision (assuming AI tags start with "AI")
        {
            aicurrentLap = aiLastLap + 1; // Increment AI lap

            if (/*aicurrentLap > lapAmount && */aicurrentLap == 5 && playerCurrentLap == 4)
            {
                loseMenuUI.SetActive(true);
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
            else
            {
                aiLastLap = aicurrentLap; //Update AI lap
                Debug.Log("Lap: " + aicurrentLap + "/" + lapAmount);
                GameIsPaused = false;
            }
        }
    }
}
