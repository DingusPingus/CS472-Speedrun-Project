using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    public TMPro.TMP_Text highscoreLevel1;
    public TMPro.TMP_Text highscoreLevel2;

    float score1 = 999999;
    float score2 = 999999;
    //float score1;
    //float score2;


    // Start is called before the first frame update
    void Start()
    {
        if (score1 > PlayerPrefs.GetFloat("level1")){
            score1 = PlayerPrefs.GetFloat("level1");
            highscoreLevel1.text = score1.ToString() + "s";
        }

        if (score2 > PlayerPrefs.GetFloat("level2"))
        {
            score2 = PlayerPrefs.GetFloat("level2");
            highscoreLevel2.text = score2.ToString() + "s";
        }

        //Bandaid fix for No Attemt = 0s
        if (score1 == 0 || score1 == 999999)
        {
            highscoreLevel1.text = "Not Attempted";
        }
        if (score2 == 0 || score2 == 999999)
        {
            highscoreLevel2.text = "Not Attempted";
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
