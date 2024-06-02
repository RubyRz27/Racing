using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{
    //Them variables
    public int totalLaps = 3; // Total number of laps for the race
    public Text lapCounterText; // Assign this in the Inspector

    // Dictionary to track laps for each racer
    private Dictionary<string, int> racerLaps = new Dictionary<string, int>();
    // Dictionary to track whether a racer has completed a lap
    private Dictionary<string, bool> lapComplete = new Dictionary<string, bool>();

    private void Start()
    {
        UpdateLapCounterUI("Player"); // Initialize the player's UI
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is a racer
        if (other.CompareTag("Player") || other.CompareTag("AI"))
        {
            string racerName = other.gameObject.name;

            if (!lapComplete.ContainsKey(racerName))
            {
                lapComplete[racerName] = false;
            }

            if (!lapComplete[racerName])
            {
                if (!racerLaps.ContainsKey(racerName))
                {
                    racerLaps[racerName] = 0;
                }

                racerLaps[racerName]++;
                lapComplete[racerName] = true;

                if (racerName == "Player")
                {
                    UpdateLapCounterUI(racerName);
                }

                // Check if the race is finished for this racer
                if (racerLaps[racerName] > totalLaps)
                {
                    Debug.Log(racerName + " has finished the race!");
                    if (racerName == "Player")
                    {
                        lapCounterText.text = "Race Finished!";
                    }
                }
                else
                {
                    Debug.Log(racerName + " Lap: " + racerLaps[racerName]);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reset lapComplete when the racer exits the trigger
        if (other.CompareTag("Player") || other.CompareTag("AI"))
        {
            string racerName = other.gameObject.name;
            lapComplete[racerName] = false;
        }
    }

    private void UpdateLapCounterUI(string racerName)
    {
        if (racerLaps.ContainsKey(racerName))
        {
            Debug.Log("Should be displaying?");
            lapCounterText.text = "Lap: " + racerLaps[racerName] + "/" + totalLaps;
        }
    }
}
