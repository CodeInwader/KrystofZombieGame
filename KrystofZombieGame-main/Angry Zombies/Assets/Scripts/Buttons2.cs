using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


   

public class Buttons2 : MonoBehaviour
{
    public static bool settingsCanPlay = false;
    public GameObject pauseMenu;

    public Waves waves;

    public GameObject settingsPanel;

    public static bool GameOrmainMenu = false;

    private void Start()
    {
        pauseMenu.SetActive(false);

        if (settingsCanPlay)
        {
            settingsPanel.SetActive(true);
        }
        else
        {
            settingsPanel.SetActive(false);
        }
         settingsCanPlay = false;
    }

    public void exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Resume()
    {
       
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void SettingsFromGame()
    {
        settingsPanel.SetActive(true);
    }

    public void ExitFromSettings()
    {
        if (GameOrmainMenu == true)
        {
            settingsPanel.SetActive(false);
        }
        else if (GameOrmainMenu == false)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
        }
    }

}
