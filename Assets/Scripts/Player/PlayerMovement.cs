using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Create reference to rigidbody
    private Rigidbody2D rb;

    // Create player movement speed variable
    [SerializeField] private float speed;

    // Create variables to hold the input of the player
    private float xdir;
    private float ydir;
    private Vector2 dir;

    private void Start()
    {
        // Get the rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the directional input
        xdir = Input.GetAxisRaw("Horizontal");
        ydir = Input.GetAxisRaw("Vertical");

        // Save the input as a normalised vector
        dir = new Vector2(xdir, ydir).normalized;
    }

    private void FixedUpdate()
    {
        // Set the velocity of the player
        rb.velocity= new Vector2(dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime);
    }
}
