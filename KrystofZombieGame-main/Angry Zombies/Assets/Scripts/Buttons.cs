using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    

    public GameObject settingsPanel;
    

  public static bool GameOrmainMenu = false;

    public void Awake()
    {
       
    }

    private void Start()
    {
        

        if (Buttons2.settingsCanPlay)
        {
            settingsPanel.SetActive(true);
        }else
        {
            settingsPanel.SetActive(false);
        }
        Buttons2.settingsCanPlay = false;
        
    }

    public  void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        GameOrmainMenu = true;
    }

   public  void SettingsFromMenu()
    {
        settingsPanel.SetActive(true);
        GameOrmainMenu = false;
    }

 
    public void SettingsFromgame()
    {
        SceneManager.LoadScene("MainMenu");
        settingsPanel.SetActive(true);
     
    }
   


   public void BackTogameOrMenu()
   {
        if (GameOrmainMenu == false)
        {
            settingsPanel.SetActive(false);
        }
        else if (GameOrmainMenu == true) 
        {
            SceneManager.LoadScene("Samplescene");
            
        }
       
   }
   

    

    public void ExitToMainMenu()
    {
        GameOrmainMenu = false;
        
    }



    public void Exit()
    {
        Application.Quit();
    }
}
