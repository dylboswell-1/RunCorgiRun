using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Timer
{
    private static bool isRunning = false;
    private static float startTimeInSeconds;
    private static float durationInSeconds;
    
    public static void StartTimer(int seconds)
    {
        isRunning = true;
        startTimeInSeconds = Time.time;
        durationInSeconds = seconds;
    }

    public static void StopTimer()
    { 
        isRunning = false;
    }
    
    public static bool IsRunning()
    {
        return isRunning;
    }

    public static string ConvertToString()
    {
        float secondsLeft = durationInSeconds - (Time.time - startTimeInSeconds);

        if (secondsLeft < 0)
        {
            isRunning = false;
            return "00:00:00";
        }
        int minutes = Mathf.FloorToInt(secondsLeft / 60);
        int seconds = Mathf.FloorToInt(secondsLeft % 60);
        return $"{minutes:00}:{seconds:00}";
    }
    
}
