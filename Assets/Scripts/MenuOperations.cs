using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Contains Options for any Menu Elements that have been created so far, incorporated previous "MainMenu" file
public class MenuOperations : MonoBehaviour
{
   public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public Slider sensitivitySlider;
    /*
    public void ChangeSensitivity()
    {
        PlayerLook.mouseSensitivity = sensitivitySlider.value;
    }
    
    public void ResetSensitivity()
    {
        PlayerPrefs.GetFloat("sensitivity", 5);
    }
   */
    
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