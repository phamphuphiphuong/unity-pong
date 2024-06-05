using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 500f;
    public GameManager gameManager;

    void Start()
    {
        float x = Random.value < 0.5 ? -1.0f : 1.0f;
        float y = Random.value < 0.5 ? Random.Range(-1.0f, -0.5f) : Random.Range(-1.0f, -0.5f);
        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            gameManager.Reset();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Center")
        {
            if (this.transform.position.x > 0)
            {
                gameManager.IncreateComputerScore();
            }
            else
            {
                gameManager.IncreatePlayerScore();
            }
        }
    }
}
