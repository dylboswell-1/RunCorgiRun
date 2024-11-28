using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GaveOverCanvasGroup;
    public CanvasGroup GamePanelCanvasGroup;

    public Text ScoreText;
    public Text TimeText;

    public void SetScoreText(int score)
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    public void SetTimeText(string time)
    {
        TimeText.text = time;
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }
    
    public void ShowGameOverScreen()
    {
        CanvasGroupDisplayer.Show(GaveOverCanvasGroup);
    }

    public void HideGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(GaveOverCanvasGroup);
    }
    
    public void ShowGamePanel()
    {
        CanvasGroupDisplayer.Show(GamePanelCanvasGroup);
    }

    public void HideGamePanel()
    {
        CanvasGroupDisplayer.Hide(GamePanelCanvasGroup);
    }
    
    
    

    
    

}
    

