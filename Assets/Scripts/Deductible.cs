using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deductible : MonoBehaviour
{
    public int pointValue = 1;
    public PlayerController playerController;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (playerController.IsInvincible() == false)
            {
                ScoreManager.instance.MinusScore(pointValue);
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;

            }

        }
    }
    public void GameRestart()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
