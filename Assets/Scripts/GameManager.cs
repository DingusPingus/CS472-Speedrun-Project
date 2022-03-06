using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text targetsLeftText;
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
        targetCount = targets.transform.childCount;
        targetsLeftText.text = "Targets Left: " + targetCount;


        if (targetCount == 0 && !isLevelEnd()){
            setLevelOver(true);
        }
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

}
