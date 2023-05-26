using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBasic : MonoBehaviour
{
    // Create a variable for the rigidbody
    private Rigidbody2D rb;

    // Create a variable for speed
    [SerializeField] private float speed;

    // Create a variable to see if enemy has been collided with
    private bool touchedPlayer;

    // Create a variable for enemy lifetime
    [SerializeField] private float lifetime;

    public float Speed
    {
        get { return speed; } 
        set { speed = value; }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        touchedPlayer = false;
        Destroy(this.gameObject, lifetime);
    }

    private void FixedUpdate()
    {
        if (!touchedPlayer)
        {
            rb.velocity = new Vector2(-speed * Time.deltaTime, 0.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchedPlayer = true;
        }
    }
}
