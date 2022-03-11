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
        SceneManager.LoadScene("LevelSelection");
    }
}
