using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopPlacer : MonoBehaviour
{
    public GameObject PoopPrefab;
    public Game Game;
    public void Place(Vector3 corgiPosition)
    {
        if (Game.HasStarted())
        {
            Instantiate(PoopPrefab, corgiPosition,
                Quaternion.identity); // Just means "make"  - Instantiate(what, where, rotation)
        }
    }

    public void Reset()
    {
        foreach (GameObject poopPiece in GameObject.FindGameObjectsWithTag("Poop"))
        {
            Destroy(poopPiece);
        }
    }
}
