using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject targets;
    [SerializeField]
    private TMP_Text targetsLeftText;
    [SerializeField]
    private static double currentTime;
    [SerializeField]
    private TMP_Text TimerText;
   
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private static string sceneName;
    private static int targetCount = 0;
    // Start is called before the first frame update
     private static bool levelOver = false;

     public static Vector3 respawnPoint = Vector3.up;
    void Start()
    {
        //when gamemanager is brought into the scene (AKA a level is active) we dont want the cursor to move
        Cursor.lockState = CursorLockMode.Locked;

        sceneName = SceneManager.GetActiveScene().name;
        setLevelOver(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime = Time.timeSinceLevelLoadAsDouble;
        targetCount = targets.transform.childCount;

        if (targetCount == 0 && !isLevelEnd()){
            setLevelOver(true);
        }
        if(Input.GetKeyDown("escape")){
            ReturnToMenu();
        }

        UpdateUI();
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
        targetsLeftText.text = "Targets Left: " + targetCount;
        TimerText.text = currentTime.ToString("F2");
    }
    public static void ReturnToMenu(){
        //before we return to level selection we want to unlock cursor
        Cursor.lockState = CursorLockMode.None;

        //we also want to save the fastest time
        //if the user made a faster time

        if(isLevelEnd() && currentTime < PlayerPrefs.GetFloat(sceneName, 999999)){
            PlayerPrefs.SetFloat(sceneName,(float)currentTime);
        }
    
        PlayerPrefs.Save();
        SceneManager.LoadScene("Level Selection");
    }
}
