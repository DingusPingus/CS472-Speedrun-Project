using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Contains Options for any Menu Elements that have been created so far, incorporated previous "MainMenu" file
public class MenuOperations : MonoBehaviour
{

    public Slider sensitivitySlider;

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }


    //Declares value for Custom Sensitivity, to prevent everything from being stuck.
    public static float CustomSens = 5f;

    public void Start()
    {
        //Sets the slider to be value of current Sensitivity to properly reflect previous settings/prevent from defaulting to different value
        sensitivitySlider.value = CustomSens;

        //Adds listener at start of Frame to check for any value changes throughout.
        sensitivitySlider.onValueChanged.AddListener(delegate { ChangeSensitivity(); });
    }

    public void ChangeSensitivity()
    {
        //Changes sensitivity to reflect current slider value
        CustomSens = sensitivitySlider.value;
    }

    public void ResetSensitivity()
    {
        CustomSens = 5f;
        sensitivitySlider.value = CustomSens;
    }
    
    public void ReturnToTitle()
    {
        SceneManager.LoadScene("Title Page");
    }

    public void LevelSelector()
    {
        SceneManager.LoadScene("Level Selection");
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("level2");
    }
}