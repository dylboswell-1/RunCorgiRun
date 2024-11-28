public class Pill : TimedLifespan
{
    
    public override void Start() // Keyword "override" indicates that the computer should run this classes Start method, rather than the Start method in TimedLifespan, the parent class of Beer.
    {
        secondsOnScreen = GameParameters.PillSecondsOnScreen;
        base.Start(); // This will call the Start method from TimedLifespan -- The parent class.
    }

}
