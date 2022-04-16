using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public int intfirstPlace;
    public int intsecondPlace;
    public int intthirdlace;
    public int intfourthPlace;
    public int intfivethPlace;
    public int intsixthPlace;
    public int intseventhPlace;
    public int inteitghthPlace;
    public int intninethPlace;
    public int inttenthPlace;

    public int playerScore = 0;
    public bool foreachEnd = false;

    int scoreToPrint;
    public TextMeshProUGUI scoreText;
    public GameObject diepanel;
    
    public List<int> scoreList = new List<int>();


    private void Start()
    {
        diepanel.SetActive(false);

        intfirstPlace = PlayerPrefs.GetInt("firstPlace");
        intsecondPlace = PlayerPrefs.GetInt("secondPlace");
        intthirdlace = PlayerPrefs.GetInt("thirdlace");
        intfourthPlace = PlayerPrefs.GetInt("fourthPlace");
        intfivethPlace = PlayerPrefs.GetInt("fivethPlace");
        intsixthPlace = PlayerPrefs.GetInt("sixthPlace");
        intseventhPlace = PlayerPrefs.GetInt("seventhPlace");
        inteitghthPlace = PlayerPrefs.GetInt("eitghthPlace");
        intninethPlace = PlayerPrefs.GetInt("ninethPlace");
        inttenthPlace = PlayerPrefs.GetInt("tenthPlace");

        scoreList.Add(intfirstPlace);
        scoreList.Add(intsecondPlace);
        scoreList.Add(intthirdlace);
        scoreList.Add(intfourthPlace);
        scoreList.Add(intfivethPlace);
        scoreList.Add(intsixthPlace);
        scoreList.Add(intseventhPlace);
        scoreList.Add(inteitghthPlace);
        scoreList.Add(intninethPlace);
        scoreList.Add(inttenthPlace);
    }
    // Update is called once per frame
    private void Update()
    {
        
    }

    public void AddScore()
    {
        playerScore = playerScore + 100;
        scoreToPrint = playerScore;
    }

    public void EndOfPlay()
    {
        

        scoreText.text = "Your score is : " + scoreToPrint.ToString();
        diepanel.SetActive(true);
        Cursor.visible = true;
        
       

        foreach (int element in scoreList)
        {
            
            if(element < playerScore && foreachEnd == false)
            {
                scoreList.Add(playerScore); 
                
              
                foreachEnd = true;
            }
            else if (element == playerScore)
            {
                break;
            }

           
        }

        scoreList.Sort();
        

        if (scoreList.Count > 10)
        {
            scoreList.Remove(scoreList[0]);
        }

        PlayerPrefs.SetInt("firstPlace", scoreList[9]);
        PlayerPrefs.SetInt("secondPlace", scoreList[8]);
        PlayerPrefs.SetInt("thirdlace", scoreList[7]);
        PlayerPrefs.SetInt("fourthPlace", scoreList[6]);
        PlayerPrefs.SetInt("fivethPlace", scoreList[5]);
        PlayerPrefs.SetInt("sixthPlace", scoreList[4]);
        PlayerPrefs.SetInt("seventhPlace", scoreList[3]);
        PlayerPrefs.SetInt("eitghthPlace", scoreList[2]);
        PlayerPrefs.SetInt("ninethPlace", scoreList[1]);
        PlayerPrefs.SetInt("tenthPlace", scoreList[0]);

        
        playerScore = 0;
    }
}
