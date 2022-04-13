using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settinghs : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropDown;

    public Slider slider;

    public Toggle toggle;

    public Dropdown dropdownQuality;

    public Dropdown dropdownResolution;

    public GameObject settingsPanel;

    public int oneOrZero;

    Resolution[] resolutions;

    public void Start()
    {
        int currentresolutionIndex = 0;

        resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();
        {

        }
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;

            options.Add(option);

            if (resolutions[1].width == Screen.currentResolution.width && resolutions[1].height == Screen.currentResolution.height)
            {

                currentresolutionIndex = i;
            }

        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentresolutionIndex;
        resolutionDropDown.RefreshShownValue();

        //Setting Volume
        audioMixer.SetFloat("Volume", PlayerPrefs.GetFloat("volume"));
        slider.SetValueWithoutNotify(PlayerPrefs.GetFloat("volume"));

        //Setting Resolution
        Resolution resolution = resolutions[PlayerPrefs.GetInt("Resolutionindex")];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        dropdownResolution.SetValueWithoutNotify(PlayerPrefs.GetInt("Resolutionindex"));



        //Setting Quality
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualityIndex"));
        dropdownQuality.SetValueWithoutNotify(PlayerPrefs.GetInt("qualityIndex"));


        //Setting FullScreen
        oneOrZero = PlayerPrefs.GetInt("isFullScreen");

        if (oneOrZero == 1)
        {
            Screen.fullScreen = true;
            toggle.SetIsOnWithoutNotify(true);
        }
        else if (oneOrZero == 0)
        {
            Screen.fullScreen = false;
            toggle.SetIsOnWithoutNotify(false);
        }


    }

    public void setResolution(int resolutionindex)
    {
        PlayerPrefs.SetInt("Resolutionindex", resolutionindex);
        Resolution resolution = resolutions[PlayerPrefs.GetInt("Resolutionindex")];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
        audioMixer.SetFloat("Volume", PlayerPrefs.GetFloat("volume"));
    }

    public void SetQuality(int qualityIndex)
    {
        PlayerPrefs.SetInt("qualityIndex", qualityIndex);
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualityIndex"));
    }

    public void SetFullScreen(bool isFullscreen)
    {
      

        if (isFullscreen)
        {
            oneOrZero = 1;
        }
        else
        {
            oneOrZero = 0;
        }


        PlayerPrefs.SetInt("isFullScreen", oneOrZero);

        if (oneOrZero == 1)
        {
            Screen.fullScreen = true;
        }
        else if(oneOrZero == 0)
        {
            Screen.fullScreen = false;
        }


        
    }

    private void Update()
    {
       
    }


}
