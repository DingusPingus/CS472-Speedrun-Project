using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text targetsLeftText;
    [SerializeField]
    private TMP_Text TimerText;
    [SerializeField]
    private GameObject targets;
    [SerializeField]
    private GameObject player;
    private static int targetCount = 0;
    // Start is called before the first frame update
     static bool levelOver = false;

     public static Vector3 respawnPoint = Vector3.up;
    void Start()
    {
        //when gamemanager is brought into the scene (AKA a level is active) we dont want the cursor to move
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();

         if (targetCount == 0 && !isLevelEnd()){
            setLevelOver(true);
        }
    }

    //returns the targets that have not been destroyed yet
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

       
    }
    public static void ReturnToMenu(){
        //before we return to main menu we want to unlock cursor
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Title Page");
    }
}
