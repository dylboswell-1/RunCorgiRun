using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectPlacer : MonoBehaviour
{
    public float MinimumSecondsUntilCreate;
    public float MaximumSecondsUntilCreate;
    public GameObject ObjectPrefab;
    public string PrefabTag;
    public Game Game;
    
    private Coroutine CountdownCoroutine;
    private bool isWaitingToCreate = false;
    public void Update()
    {
        if (Game.HasStarted())
        {
            if (isWaitingToCreate == false)
            {
                CountdownCoroutine = StartCoroutine(CountdownUntilCreation()); 
            }
        }
        
    }

    IEnumerator CountdownUntilCreation() // Coroutine
    {
        isWaitingToCreate = true;
        float secondsToWait = Random.Range(MinimumSecondsUntilCreate, MaximumSecondsUntilCreate);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        isWaitingToCreate = false;
    }

    public void Reset()
    {
        foreach (GameObject thing in GameObject.FindGameObjectsWithTag(PrefabTag))
        {
            Destroy(thing);
        }
        if(CountdownCoroutine != null)
            StopCoroutine(CountdownCoroutine);
        isWaitingToCreate = false;
    }

    public virtual void Place() // The virtual keyword means that we are now allowed to override this method in child classes
    {
        // pick random place on screen
        Vector3 position = SpriteTools.RandomLocationWorldSpace();
        // Create bone
        Instantiate(ObjectPrefab, position, Quaternion.identity);
    }

    
}
