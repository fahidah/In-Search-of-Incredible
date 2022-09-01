using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private int baseScore = 0;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI timeText;
    private float startTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }


    private void Update()
    {
        UpdateTime();
    }

    public void UpdateScore(int scoreUpdate)
    {
        baseScore += scoreUpdate;
        scoreText.text = "Score: " + baseScore.ToString();
    }

    private void UpdateTime()
    {
        startTime += Time.deltaTime;
        timeText.text = "Timer: " + startTime.ToString("0.00");
    }
}
