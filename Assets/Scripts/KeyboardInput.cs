using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeboardInput : MonoBehaviour
{
    public Corgi CorgiSprite;
    public PoopPlacer PoopPlacer;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 direction = new Vector2(0,1);
            CorgiSprite.MoveManually(direction);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 direction = new Vector2(-1,0);
            CorgiSprite.MoveManually(direction);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 direction = new Vector2(0,-1);
            CorgiSprite.MoveManually(direction);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 direction = new Vector2(1,0);
            CorgiSprite.MoveManually(direction);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoopPlacer.Place(CorgiSprite.transform.position);
        }
        
    }
}
