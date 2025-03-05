using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public TextMeshPro scoreText;

    void Start()
    {
        scoreText.alpha = 0f;
        scoreText = GetComponent<TextMeshPro>();
    }

    // Start is called before the first frame update
    public void GameOver()
    {
        scoreText.alpha = 1f;
        Time.timeScale = 0f;  // Freezes time
    }

    public void GameRestart()
    {
        scoreText.alpha = 0f;
        Time.timeScale = 1f;  // Freezes time
    }
}
