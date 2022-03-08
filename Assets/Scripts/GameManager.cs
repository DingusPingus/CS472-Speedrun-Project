using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text targetsLeftText;

    public TMP_Text TimerText;
    public GameObject targets;
    public GameObject player;
    private static int targetCount = 0;
    // Start is called before the first frame update
     static bool levelOver = false;

     public static Vector3 respawnPoint = Vector3.up;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    //returnes the targets that have not been destroyed yet
    public static int getTargetsLeft(){
        return targetCount;
    }
    public static bool isLevelEnd(){
        return levelOver;
    }

    public static void setLevelOver(bool value){
        levelOver = value;
    }

    void UpdateUI(){
        //update targets left
        targetCount = targets.transform.childCount;
        targetsLeftText.text = "Targets Left: " + targetCount;

        //display current time
        double currentTime = Timer.getCurrentTime();

        TimerText.text = Time.timeSinceLevelLoadAsDouble.ToString("F2");

        if (targetCount == 0 && !isLevelEnd()){
            setLevelOver(true);
        }
    }
}
