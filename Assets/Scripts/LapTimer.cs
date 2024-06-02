using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    //Them variables
    public Text lapTimeText; // Assign this in the Inspector

    private float lapStartTime; // Time when the current lap started
    private float currentLapTime; // Time elapsed for the current lap

    private void Start()
    {
        lapStartTime = Time.time; // Initialize lap start time
    }

    private void Update()
    {
        // Update the current lap time continuously
        currentLapTime = Time.time - lapStartTime;
        UpdateLapTimeUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Print the current lap time (optional, for debugging)
            Debug.Log("Lap Time: " + currentLapTime);

            // Reset lap timer for the next lap
            lapStartTime = Time.time;
        }
    }

    private void UpdateLapTimeUI()
    {
        lapTimeText.text = "Lap Time: " + currentLapTime.ToString("F2") + "s";
    }
}
