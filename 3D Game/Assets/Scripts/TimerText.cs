using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerText : MonoBehaviour
{
    [SerializeField] Text timerText;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }
    
    void update()
    {
        float t = Time.time - startTime;

        string minutes = ((int) t / 60 ).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
    
}
