using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreKeeper // Static because there will only be one score
{
    
    private static int score = 0;

    public static void Add(int points)
    {
        score = score + points;
    }

    public static void Reset()
    {
        score = 0;
    }

    public static int GetScore()
    {
        return score;
    }
    
}
