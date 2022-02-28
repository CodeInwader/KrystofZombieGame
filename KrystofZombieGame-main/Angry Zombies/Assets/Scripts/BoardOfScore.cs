using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardOfScore : MonoBehaviour
{
    public TextMeshProUGUI firstPlace;
    public TextMeshProUGUI secondPlace;
    public TextMeshProUGUI thirdlace;
    public TextMeshProUGUI fourthPlace;
    public TextMeshProUGUI fivethPlace;
    public TextMeshProUGUI sixthPlace;
    public TextMeshProUGUI seventhPlace;
    public TextMeshProUGUI eitghthPlace;
    public TextMeshProUGUI ninethPlace;
    public TextMeshProUGUI tenthPlace;

    public InputField inputfield;
    public  string Nickname;
  

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

   public void NickNameSetter()
    {
         Nickname = inputfield.text;
       
        PlayerPrefs.SetString("Nickname", Nickname);

    }
    

    private void Update()
    {
         
    }

}
