public class Bone : TimedLifespan
{
    public override void Start() // Keyword "override" indicates that the computer should run this start method, rather than the start method in TimedLifespan.
    {
        secondsOnScreen = GameParameters.BoneSecondsOnScreen;
        base.Start(); // This will call the Start method from TimedLifespan -- The parent class.
    }
    
}
