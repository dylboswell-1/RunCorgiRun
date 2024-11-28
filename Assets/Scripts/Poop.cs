using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : TimedLifespan
{
    public override void Start() // Keyword "override" indicates that the computer should run this start method, rather than the start method in TimedLifespan.
    {
        secondsOnScreen = GameParameters.PoopSecondsOnScreen;
        base.Start(); // This will call the Start method from TimedLifespan -- The parent class.
    }
}
