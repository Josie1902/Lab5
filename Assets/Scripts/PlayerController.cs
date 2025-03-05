using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float defaultSpeed = 5f; // Store the default speed
    private bool isInvincible = false;

    private Color originalColor; // Store the original color
    private SpriteRenderer sr;
    private Vector3 originalPosition;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
        originalPosition = transform.position;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize(); // Prevent faster diagonal movement

        transform.Translate(movement * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetSpeedColor()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    public void SetInvincibleColor()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.green;
    }

    public void ResetSpeed()
    {
        speed = defaultSpeed;
    }

    public void ResetColor()
    {

        sr.color = originalColor;
    }

    public void SetInvincible(bool invincible)
    {
        isInvincible = invincible;
    }

    public bool IsInvincible()
    {
        return isInvincible;
    }
    public void GameRestart()
    {
        transform.position = originalPosition;
    }
}
