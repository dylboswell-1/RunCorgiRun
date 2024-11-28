using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moonshine : TimedLifespan
{
    
    public override void Start() // Keyword "override" indicates that the computer should run this classes Start method, rather than the Start method in TimedLifespan, the parent class of Beer.
    {
        secondsOnScreen = GameParameters.MoonshineSecondsOnScreen;
        base.Start(); // This will call the Start method from TimedLifespan -- The parent class.
    }
    
}
