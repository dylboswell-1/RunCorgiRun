using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Game : MonoBehaviour
{
    public UI UI;
    private bool hasStarted = false;
    public Corgi Corgi;
    public PoopPlacer PoopPlacer;
    public BonePlacer BonePlacer;
    public BeerPlacer BeerPlacer;
    public MoonshinePlacer MoonshinePlacer;
    public PillPlacer PillPlacer;

    void Start()
    {
        UI.ShowStartScreen();
        UI.HideGameOverScreen();
        UI.HideGamePanel();
    }

    public bool HasStarted()
    {
        return hasStarted;
    }

    public void StartGame()
    {
        UI.HideStartScreen();
        UI.ShowGamePanel();
        Timer.StartTimer(60);
        ScoreKeeper.Reset();
        UI.SetScoreText(0);
        hasStarted = true;
    }
    
    public void RestartGame()
    {
        UI.HideGameOverScreen();
        Corgi.Reset();
        StartGame();
    }

    public void EndGame()
    {
        UI.HideGamePanel();
        UI.ShowGameOverScreen();
        hasStarted = false;
        PoopPlacer.Reset();
        BonePlacer.Reset();
        BeerPlacer.Reset();
        PillPlacer.Reset();
        MoonshinePlacer.Reset();
    }

    void Update()
    {
        UI.SetTimeText(Timer.ConvertToString());
        if (hasStarted)
        {
            if (!Timer.IsRunning() && hasStarted == true)
            {
                EndGame();
            }
        }
    }

    

}
