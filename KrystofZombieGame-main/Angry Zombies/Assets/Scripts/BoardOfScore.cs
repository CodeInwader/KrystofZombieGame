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
        intsecondPlace = PlayerPrefs.GetInt("secondPlace");
        intthirdlace = PlayerPrefs.GetInt("thirdlace");
        intfourthPlace = PlayerPrefs.GetInt("fourthPlace");
        intfivethPlace = PlayerPrefs.GetInt("fivethPlace");
        intsixthPlace = PlayerPrefs.GetInt("sixthPlace");
        intseventhPlace = PlayerPrefs.GetInt("seventhPlace");
        inteitghthPlace = PlayerPrefs.GetInt("eitghthPlace");
        intninethPlace = PlayerPrefs.GetInt("ninethPlace");
        inttenthPlace = PlayerPrefs.GetInt("tenthPlace");
        

        firstPlace.text =  intfirstPlace.ToString();
        secondPlace.text = intsecondPlace.ToString();
        thirdlace.text = intthirdlace.ToString();
        fourthPlace.text = intfourthPlace.ToString();
        fivethPlace.text = intfivethPlace.ToString();
        sixthPlace.text = intsixthPlace.ToString();
        seventhPlace.text = intseventhPlace.ToString();
        eitghthPlace.text = inteitghthPlace.ToString();
        ninethPlace.text = intninethPlace.ToString();
        tenthPlace.text = inttenthPlace.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
