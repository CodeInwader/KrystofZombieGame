using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardOfScore : MonoBehaviour
{
    public Text firstPlace;
    public Text secondPlace;
    public Text thirdlace;
    public Text fourthPlace;
    public Text fivethPlace;
    public Text sixthPlace;
    public Text seventhPlace;
    public Text eitghthPlace;
    public Text ninethPlace;
    public Text tenthPlace;

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

    // Start is called before the first frame update
    void Start()
    {
         intfirstPlace = PlayerPrefs.GetInt("firstPlace");
        intsecondPlace = PlayerPrefs.GetInt("firstPlace");
        intthirdlace = PlayerPrefs.GetInt("firstPlace");
        intfourthPlace = PlayerPrefs.GetInt("firstPlace");
        intfivethPlace = PlayerPrefs.GetInt("firstPlace");
        intsixthPlace = PlayerPrefs.GetInt("firstPlace");
        intseventhPlace = PlayerPrefs.GetInt("firstPlace");
        inteitghthPlace = PlayerPrefs.GetInt("firstPlace");
        intninethPlace = PlayerPrefs.GetInt("firstPlace");
        inttenthPlace = PlayerPrefs.GetInt("firstPlace");
        

        firstPlace.text =  intfirstPlace.ToString();
        secondPlace.text = intfirstPlace.ToString();
        thirdlace.text = intfirstPlace.ToString();
        fourthPlace.text = intfirstPlace.ToString();
        fivethPlace.text = intfirstPlace.ToString();
        sixthPlace.text = intfirstPlace.ToString();
        seventhPlace.text = intfirstPlace.ToString();
        eitghthPlace.text = intfirstPlace.ToString();
        ninethPlace.text = intfirstPlace.ToString();
        tenthPlace.text = intfirstPlace.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
