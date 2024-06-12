using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Method to load Level 1
    public void LoadLevel1()
    {
        SceneManager.LoadScene("RTGTest"); 
    }

    // Method to load Level 2
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Highway1"); 
    }

    // Method to return to the main menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
