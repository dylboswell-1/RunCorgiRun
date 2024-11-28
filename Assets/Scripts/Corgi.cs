using System.Collections;
using UnityEngine;


public class Corgi : MonoBehaviour
{
    public SpriteRenderer CorgirSpriteRenderer;
    public Sprite DrunkenSprite;
    public Sprite SoberSprite;
    public UI UI;
    public Game Game;

    private Coroutine drunkenTimerCoroutine;
    private bool IsDrunk = false;
    private bool IsPlastered = false;
    private int randomMoveCountdown = 0;
    private int lastRandomDirection;
    
    public void Update()
    {
        if (IsPlastered)
        {
            MoveRandomly();
        }
    }

    public void Reset()
    {
        SoberUp();
        ResetSprite();
        if(drunkenTimerCoroutine != null)
            StopCoroutine(drunkenTimerCoroutine);
    }

    private void ResetSprite()
    {
        transform.position = new Vector3(0,0,0);
        CorgirSpriteRenderer.flipX = false;
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Beer")
        {
            GetDrunk();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Pill")
        {
            SoberUp();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Bone")
        {
            ScoreOnePoint();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Moonshine")
        {
            GetPlasterd();
            Destroy(other.gameObject);
        }
        
    }
    
    private void ScoreOnePoint()
    {
        ScoreKeeper.Add(1);
        UI.SetScoreText(ScoreKeeper.GetScore());
    }

    private void GetPlasterd()
    {
        IsPlastered = true;
        Inebriate();
    }

    private void Inebriate()
    {
        ChangeToDrunkSprite();
        if (drunkenTimerCoroutine != null) // Stops coroutine if corgi is already drunk
        {
            StopCoroutine(drunkenTimerCoroutine);
        }

        drunkenTimerCoroutine = StartCoroutine(CountdownTillSober());
    }

    private void GetDrunk()
    {
        IsDrunk = true;
        ChangeToDrunkSprite();
        Inebriate();
    }

    private void ChangeToDrunkSprite()
    {
        CorgirSpriteRenderer.sprite = DrunkenSprite;
    }

    public void ChangeToSoberSprite()
    {
        CorgirSpriteRenderer.sprite = SoberSprite;
    }

    IEnumerator CountdownTillSober() // Coroutine for how long the corgi will be "drunk"
    {
        yield return new WaitForSeconds(GameParameters.CorgiDrunkSeconds); 
        SoberUp(); // The SoberUp() method is in the coroutine because we only want the method to run once the coroutine is done.
    }

    private void SoberUp()
    {
        IsDrunk = false;
        IsPlastered = false;
        ChangeToSoberSprite();
    }

    private void Move(Vector2 direction)
    {
        direction = ApplyDrunkenness(direction);
        
        FaceCorrectDirection(direction);
        float xAmount = (direction.x) * Time.deltaTime * GameParameters.CorgiMoveSpeed; // The f is there to indicate that its a float
        float yAmount = (direction.y) * Time.deltaTime * GameParameters.CorgiMoveSpeed; // 4f = 4.0
        transform.Translate(xAmount, yAmount, 0);
        KeepOnScreen();
    }

    public void MoveManually(Vector2 direction)
    {
        if (Game.HasStarted())
        {
            if (IsPlastered)
            {
                return;
            } 
            Move(direction);
        }
    }

    private void MoveRandomly()
    {
        int direction = lastRandomDirection;
        
        if (randomMoveCountdown == 0)
        {
            direction = Random.Range(0, 3);
            randomMoveCountdown = Random.Range(20,70);
            lastRandomDirection = direction;
        }
        
        switch (direction)
        {
            case 0:
                Move(new Vector2(1,0));
                break;
            case 1:
                Move(new Vector2(0,1));
                break;
            case 2:
                Move(new Vector2(-1,0));
                break;
            case 3:
                Move(new Vector2(0,-1));
                break;
        }
        randomMoveCountdown--;
    }

    private Vector2 ApplyDrunkenness(Vector2 direction) // Reverses movement if corgi is drunk
    {
        if (IsDrunk)
        {
            direction.x *= -3; 
            direction.y *= -3;
        }

        return direction;
    }

    private void KeepOnScreen()
    {
        transform.position = SpriteTools.ConstrainToScreen(CorgirSpriteRenderer);
    }

    private void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            CorgirSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            CorgirSpriteRenderer.flipX = true;
        }
    }
    
}
