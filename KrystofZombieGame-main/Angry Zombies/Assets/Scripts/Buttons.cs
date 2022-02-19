using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject settingsPanel;

    public  void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

   public  void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

   public void Exit()
    {
        Application.Quit();
    }


   


    public void Resume()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 1;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    private void Start()
    {
        pauseMenu.SetActive(false);
        settingsPanel.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
