using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonshinePlacer : RandomObjectPlacer
{
    public void Start()
    {
        PrefabTag = "Moonshine";
        MinimumSecondsUntilCreate = GameParameters.MoonshineMinimumSecondsToCreate;
        MaximumSecondsUntilCreate = GameParameters.MoonshineMaximumSecondsToCreate;
    }
    
    public override void  Place()
    {
        // pick random place on screen
        Vector3 position = SpriteTools.RandomTopOfScreenLocationWorldSpace();
        // Create bone
        Instantiate(ObjectPrefab, position, Quaternion.identity);
    }
}
