using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons2 : MonoBehaviour
{
    public static bool settingsCanPlay = false;
    public GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
       
    }

    public void exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Settings()
    {
        Time.timeScale = 1;
        Buttons.GameOrmainMenu = true;
        SceneManager.LoadScene("MainMenu");
        settingsCanPlay = true;
      
    }
}
