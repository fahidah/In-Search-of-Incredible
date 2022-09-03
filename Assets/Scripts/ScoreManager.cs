using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //public CoachController coachController;

    private int baseScore = 0;
    public int bestScore = 760;

    public TextMeshProUGUI scoreText, bestScoreText;

    public TextMeshProUGUI timeText;
    private float startTime = 0;
    public float bestTime = 105;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + bestScore;
    }


    private void Update()
    {
        UpdateTime();
    }

    public void UpdateScore(int scoreUpdate)
    {
        baseScore += scoreUpdate;
        scoreText.text = baseScore.ToString();

        if((baseScore < bestScore) && (startTime == bestTime))
        {
            //GameOver
        }
        else if((baseScore >= bestScore) && (startTime <= bestTime))
        {
            //Excellent Move
            //Continue
        }
        else 
        {
            //Continue
        }
    }

    private void UpdateTime()
    {
        startTime += Time.deltaTime;
        timeText.text = "Timer: " + startTime.ToString("0.00");
    }
}
