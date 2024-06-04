using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTrigger : MonoBehaviour
{
    private int playerLastLap; // Tracks player's previous lap
    private Dictionary<GameObject, int> aiLastLap = new Dictionary<GameObject, int>(); // Tracks AI's previous lap (GameObject: AI vehicle, int: previous lap)
    public Text lapText; // Reference to UI Text element (assign in Inspector)
    public int lapAmount;

    void Start()
    {
        playerLastLap = 0; // Initialize player lap at 0
        aiLastLap.Clear(); // Initialize AI lap dictionary
        lapText.text = "Lap: " + playerLastLap + "/" + lapAmount; // Set initial lap text on UI
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // Check for player collision
        {
            int currentLap = playerLastLap + 1; // Increment player lap

            if (currentLap > lapAmount) // Check if race is finished (replace with your total laps variable)
            {
                // Handle race finish logic (e.g., display win message)
            }
            else
            {
                playerLastLap = currentLap; // Update player lap
                lapText.text = "Lap: " + currentLap + "/" + lapAmount; // Update lap text on UI
            }
        }
        else if (other.gameObject.tag.StartsWith("AI")) // Check for AI collision (assuming AI tags start with "AI")
        {
            // ... (rest of AI lap logic remains the same)
        }
    }
}
