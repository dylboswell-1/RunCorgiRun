public class BonePlacer : RandomObjectPlacer
{
    public void Start()
    {
        PrefabTag = "Bone";
        MinimumSecondsUntilCreate = GameParameters.BoneMinimumSecondsToCreate;
        MaximumSecondsUntilCreate = GameParameters.BoneMaximumSecondsToCreate;
    }
    
}
