using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensaverAI : MonoBehaviour
{
    // Create reference to rigidbody
    private Rigidbody2D rb;

    // Variable to hold time since last input
    private int time;

    // Variable to hold number of frames before AI kicks in
    [SerializeField] private int frameIdleMax;

    // Create player movement speed variable
    [SerializeField] private float speed;

    // Variables to hold the AI Movement
    private float xdir;
    private float ydir;
    private Vector2 dir;

    // Create a reference to the bubble prefab
    [SerializeField] private GameObject bubble;
    [SerializeField] private float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        // Get the rigidbody
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.anyKey)
        {
            time = 0;
            UserMove();
            CancelInvoke("AIShoot");
        }
        else 
        {
            time++;
            
        }

        if (time >= frameIdleMax)
        {
            AIMove();
            CancelInvoke("AIShoot");
            time = 0;
            InvokeRepeating("AIShoot", 0.0f, fireRate);
        }

        // Set the velocity of the player
        rb.velocity= new Vector2(dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime);

    }

    private void UserMove()
    {
        // Get the directional input
        xdir = Input.GetAxisRaw("Horizontal");
        ydir = Input.GetAxisRaw("Vertical");

        // Save the input as a normalised vector
        dir = new Vector2(xdir, ydir).normalized;
    }

    private void AIMove()
    {
        dir = Random.insideUnitCircle;
        
    }

    private void AIShoot()
    {
        Instantiate(bubble, transform);
    }

    // Check to see if player has not assumed control for 5s?
    // Assume control, move in direction for 2s
    // Randomly shoot
}
