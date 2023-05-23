using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMovement : MonoBehaviour
{
    // Create a reference to the rigidbody 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
    }

    
}
