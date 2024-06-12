using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    //Them variables
    public Light[] toggleLights; // Lights toggled with the E key
    public Light[] holdLights; // Lights toggled with the Down Arrow key

    private bool areToggleLightsOn = false;

    //private void Start()
    //{
    //    // Ensure all lights are off by default
    //    foreach (Light light in toggleLights)
    //    {
    //        light.enabled = false;
    //    }

    //    foreach (Light light in holdLights)
    //    {
    //        light.enabled = false;
    //    }
    //}

    private void Update()
    {
        // Toggle lights with E key
        if (Input.GetKeyDown(KeyCode.E))
        {
            areToggleLightsOn = !areToggleLightsOn;
            foreach (Light light in toggleLights)
            {
                light.enabled = areToggleLightsOn;
            }
        }

        // Turn on hold lights with Down Arrow key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            foreach (Light light in holdLights)
            {
                light.enabled = true;
            }
        }

        // Turn off hold lights when Down Arrow key is released
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            foreach (Light light in holdLights)
            {
                light.enabled = false;
            }
        }
    }
}
