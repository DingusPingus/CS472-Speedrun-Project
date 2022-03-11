using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOperations : MonoBehaviour
{
   public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
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
