using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    // Create a reference to the rigidbody
    private Rigidbody2D rb;
    
    // Create a variable to hold bullet lifetime
    [SerializeField] private float lifetime;

    // Create a variable that holds the bubble speed
    [SerializeField] private float speed;

    private void Start()
    {
        // Get the rigidbody
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, lifetime);
    }

    private void FixedUpdate()
    {
        // Apply velocity to the right
        rb.velocity = new Vector2(speed * Time.deltaTime, 0.0f);
    }
}
