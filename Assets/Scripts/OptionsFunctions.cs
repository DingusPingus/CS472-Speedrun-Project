using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Currently used for changin the sensitivity of the player camera. In future can be expanded to contain other things.
public class OptionsFunctions : MonoBehaviour
{
    //Declares value for Custom Sensitivity, to prevent everything from being stuck.
    public static float DefaultCustomSens = 5f;

    //Declaring slider variable to associate in game
    public Slider sensitivitySlider;

    public void Start()
    {
        //Sets the slider to be value of current Sensitivity to properly reflect previous settings/prevent from defaulting to different value
        //sensitivitySlider.value = CustomSens;
        sensitivitySlider.value = PlayerPrefs.GetFloat("sensitivity", DefaultCustomSens);

        //Adds listener at start of Frame to check for any value changes throughout.
        sensitivitySlider.onValueChanged.AddListener(delegate { ChangeSensitivity(); });
    }

    //Changes sensitivity to reflect current slider value, refreshing on movement per listener above
    public void ChangeSensitivity()
    {
        //CustomSens = sensitivitySlider.value;
        PlayerPrefs.SetFloat("sensitivity", sensitivitySlider.value);
    }

    //Resets the sensitivity value to 5 (Default during design), and moves the slider accordingly
    public void ResetSensitivity()
    {
        PlayerPrefs.SetFloat("sensitivity", DefaultCustomSens);
        //sensitivitySlider.value = DefaultCustomSens;
    }
}