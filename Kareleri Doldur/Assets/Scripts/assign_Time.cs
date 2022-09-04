using System;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json.Linq;
using TMPro;

public class assign_Time : MonoBehaviour
{
    public static float level_Time;
    public TextMeshPro timer;
    
    void Start()
    {
        //level_Time = 120;
        timer = GetComponent<TextMeshPro>();
        float begin_Time = 5.0f;
        while (begin_Time > 0.0f) begin_Time -= Time.deltaTime; //parçalar geldikten sonra sürenin başlaması için
    }

    
    void Update()
    {
        

        if(level_Time > 0)
        {
            level_Time -= Time.deltaTime;
            update_Timer(level_Time);
        }

        else
        {
            ///game over;
        }
    }

    void update_Timer(float level_Time)
    {
        float minutes = Mathf.FloorToInt(level_Time / 60);
        float seconds = Mathf.FloorToInt(level_Time % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
