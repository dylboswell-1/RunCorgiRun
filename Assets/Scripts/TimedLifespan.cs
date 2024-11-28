using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLifespan : MonoBehaviour
{
    public float secondsOnScreen;
    public virtual void Start() // Gives permission to child classes to override this method.
    {
        StartCoroutine(CountdownTilDeath());
    }


    IEnumerator CountdownTilDeath()
    {
        yield return new WaitForSeconds(secondsOnScreen);
        Destroy(gameObject);
    }

    
}
