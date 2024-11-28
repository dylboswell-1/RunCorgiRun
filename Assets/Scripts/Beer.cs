public class Beer : TimedLifespan
{
    public override void Start() // Keyword "override" indicates that the computer should run this classes Start method, rather than the Start method in TimedLifespan, the parent class of Beer.
    {
        secondsOnScreen = GameParameters.BeerSecondsOnScreen;
        base.Start(); // This will call the Start method from TimedLifespan -- The parent class.
    }

}
