using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private static double currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.timeSinceLevelLoadAsDouble;
        Debug.Log(currentTime.ToString());
    }

    public static double getCurrentTime(){
        return currentTime;
    }
   
}
