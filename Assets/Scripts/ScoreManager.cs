using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshPro scoreText;
    private int score = 0;
    public UnityEvent gameOver;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    public void MinusScore(int points)
    {
        score -= points;
        if (score < 0)
        {
            GameOver();
        }
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameRestart()
    {
        score = 0;
        UpdateScoreText();
    }

    public void GameOver()
    {
        gameOver.Invoke();
    }
}

