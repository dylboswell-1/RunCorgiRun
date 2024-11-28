using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameParameters // Static class - We can use the code from anywhere in our code without needing to instantiate an object.
{
    public static float CorgiMoveSpeed = 5f;
    public static float CorgiDrunkSeconds = 5f;
    
    public static float PoopSecondsOnScreen = 3f;
    
    public static float BeerMinimumSecondsToCreate = 1f;
    public static float BeerMaximumSecondsToCreate = 2f;
    public static float BeerSecondsOnScreen = 5f;
    
    public static float BoneMinimumSecondsToCreate = 1f;
    public static float BoneMaximumSecondsToCreate = 2f;
    public static float BoneSecondsOnScreen = 3f;
    
    public static float PillMinimumSecondsToCreate = 3f;
    public static float PillMaximumSecondsToCreate = 5f;
    public static float PillSecondsOnScreen = 3f;
    
    public static float MoonshineMinimumSecondsToCreate = 0.5f;
    public static float MoonshineMaximumSecondsToCreate = 1.5f;
    public static float MoonshineSecondsOnScreen = 5f;
    
}
