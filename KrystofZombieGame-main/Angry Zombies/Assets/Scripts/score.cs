using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int playerScore = 0;
    public bool foreachEnd = false;


    //public InputField nameOfPlayer;


    public List<int> scoreList = new List<int>();

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        playerScore = playerScore + 100;
    }

    public void EndOfPlay()
    {
       

        foreach (int element in scoreList)
        {
            Debug.Log("jsem ve foreach");
            if(element < playerScore && foreachEnd == false)
            {
                scoreList.Add(playerScore); 
                
                Debug.Log("score added");
                foreachEnd = true;
            }

           
        }

        scoreList.Sort();
        Debug.Log(scoreList.Count);

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
