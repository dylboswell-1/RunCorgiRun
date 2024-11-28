public class BeerPlacer : RandomObjectPlacer
{
    public void Start()
    {
        PrefabTag = "Beer";
        MinimumSecondsUntilCreate = GameParameters.BeerMinimumSecondsToCreate;
        MaximumSecondsUntilCreate = GameParameters.BeerMaximumSecondsToCreate;
    }
}
