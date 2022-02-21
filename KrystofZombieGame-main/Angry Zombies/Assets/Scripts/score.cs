using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int playerScore = 0;
    public bool foreachEnd = false;


    //public InputField nameOfPlayer;


    List<int> scoreList = new List<int>();

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
        Debug.Log("jsem ve endofplay");

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
        Debug.Log(scoreList);

        if (scoreList.Count > 10)
        {
            scoreList.Remove(scoreList[10]);
        }

        PlayerPrefs.SetInt("firstPlace", scoreList[1]);
        //PlayerPrefs.SetInt("secondPlace", scoreList[1]);
        PlayerPrefs.SetInt("thirdlace", scoreList[2]);
        PlayerPrefs.SetInt("fourthPlace", scoreList[3]);
        PlayerPrefs.SetInt("fivethPlace", scoreList[4]);
        PlayerPrefs.SetInt("sixthPlace", scoreList[5]);
        PlayerPrefs.SetInt("seventhPlace", scoreList[6]);
        PlayerPrefs.SetInt("eitghthPlace", scoreList[7]);
        PlayerPrefs.SetInt("ninethPlace", scoreList[8]);
        PlayerPrefs.SetInt("tenthPlace", scoreList[9]);

        /*
        firstPlace.text = scoreList[0].ToString();
        secondPlace.text = scoreList[1].ToString();
        thirdlace.text = scoreList[2].ToString();
        fourthPlace.text = scoreList[3].ToString();
        fivethPlace.text = scoreList[4].ToString();
        sixthPlace.text = scoreList[5].ToString();
        seventhPlace.text = scoreList[6].ToString();
        eitghthPlace.text = scoreList[7].ToString();
        ninethPlace.text = scoreList[8].ToString();
        tenthPlace.text = scoreList[9].ToString();
        */
        playerScore = 0;
    }
}
