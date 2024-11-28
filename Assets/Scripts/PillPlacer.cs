public class PillPlacer : RandomObjectPlacer
{
    public void Start()
    {
        PrefabTag = "Pill";
        MinimumSecondsUntilCreate = GameParameters.PillMinimumSecondsToCreate;
        MaximumSecondsUntilCreate = GameParameters.PillMaximumSecondsToCreate;
    }
    
}
