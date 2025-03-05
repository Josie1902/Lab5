using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerupType { Default, Speed, Invincibility }

public class Powerup : MonoBehaviour
{
    public PowerupType Type;
    private Vector3 originalPosition;

    void Start()
    {
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStateController player = collision.GetComponent<PlayerStateController>();
            player.SetPowerup(Type);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
        }
    }

    public void GameRestart()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}

