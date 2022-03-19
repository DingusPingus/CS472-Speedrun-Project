using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsFunctions : MonoBehaviour
{
    //Declares value for Custom Sensitivity, to prevent everything from being stuck.
    public static float CustomSens = 5f;

    //Declaring slider variable to associate in game
    public Slider sensitivitySlider;

    public void Start()
    {
        //Sets the slider to be value of current Sensitivity to properly reflect previous settings/prevent from defaulting to different value
        sensitivitySlider.value = CustomSens;

        //Adds listener at start of Frame to check for any value changes throughout.
        sensitivitySlider.onValueChanged.AddListener(delegate { ChangeSensitivity(); });
    }

    //Changes sensitivity to reflect current slider value, refreshing on movement per listener above
    public void ChangeSensitivity()
    {
        CustomSens = sensitivitySlider.value;
    }

    //Resets the sensitivity value to 5 (Default during design), and moves the slider accordingly
    public void ResetSensitivity()
    {
        CustomSens = 5f;
        sensitivitySlider.value = CustomSens;
    }
}