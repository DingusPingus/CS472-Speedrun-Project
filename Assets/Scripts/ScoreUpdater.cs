using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    public TMPro.TMP_Text highscoreLevel1;
    public TMPro.TMP_Text highscoreLevel2;

    //Sets new values to be just over 277 hours, easy value to compare against to ensure whatever attempt is done first will be lower
    float score1 = 999999;
    float score2 = 999999;
    //float score1;
    //float score2;


    // Start is called before the first frame update
    //Using this Since at the moment considering only for the case of one person playing.
    void Start()
    {
        //Checks for if new player score is lower than before.
        if (score1 > PlayerPrefs.GetFloat("level1")){
            score1 = PlayerPrefs.GetFloat("level1");
            highscoreLevel1.text = score1.ToString("F2") + "s";
        }

        if (score2 > PlayerPrefs.GetFloat("level2"))
        {
            score2 = PlayerPrefs.GetFloat("level2");
            highscoreLevel2.text = score2.ToString("F2") + "s";
        }

        //Bandaid fix for No Attemt = 0s (since float defaulting to 0s)
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
    //I believe if scsore updating is moved to Update it will calculate score essentially constantly, for case of multiple users playing the same level. However, as this was sought to not have the competitiveness of multiplayer, likely leaving out.
    void Update()
    {
        
    }

}