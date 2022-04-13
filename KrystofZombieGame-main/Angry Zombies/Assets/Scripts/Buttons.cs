using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Buttons2 Buttons2;
   
   
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        Buttons2.GameOrmainMenu = true;
    }

    public void SettingsFromMainMenu()
    {
        Buttons2.GameOrmainMenu = false;
        Buttons2.settingsCanPlay = true;
        SceneManager.LoadScene("sampleScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0f;
       
    }

    public void Exit()
    {
        Application.Quit();
    }
    
}
