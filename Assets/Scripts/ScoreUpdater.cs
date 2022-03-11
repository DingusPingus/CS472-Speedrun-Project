using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    public TMPro.TMP_Text highscoreLevel1;
    public TMPro.TMP_Text highscoreLevel2;

    //int score1 = 999999;
    //int score2 = 999999;
    int score1;
    int score2;


    // Start is called before the first frame update
    void Start()
    {
        highscoreLevel1.text = PlayerPrefs.GetFloat("level1").ToString();
        highscoreLevel2.text = PlayerPrefs.GetFloat("level2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUpdate()
    {
    
    //PseudoCode
    /*
    if (currentScore > PlayerPrefs.GetFloat("level1"))
        {
            currentScore = PlayerPrefs.GetFloat("level1");
        }
    */



    //    = PlayerPrefs.GetFloat("level1");
    //    = PlayerPrefs.GetFloat("level2");
    }
}
