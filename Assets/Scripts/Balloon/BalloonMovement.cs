using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    // Create Variables for balloon vertical speed
    [SerializeField] private float ySpeedMin;
    [SerializeField] private float ySpeedMax;
    private float ySpeed;

    // Create variables for ballon horizontal speed
    [SerializeField] private float xSpeedMin;
    [SerializeField] private float xSpeedMax;
    private float xSpeed;

    // Create a variable to hold balloon lifetime
    [SerializeField] private float lifetime;


    // Create a variable for the frequency that a ballon changes x speed
    [SerializeField] private float changeDirTime;

    // Invoke the balloon changing movement script repeatedly
    private void Start()
    {
        ySpeed = Random.Range(ySpeedMin, ySpeedMax);
        InvokeRepeating("ChangeDir", 0.0f, changeDirTime);
        Destroy(this.gameObject, lifetime);
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(-xSpeed * Time.deltaTime, ySpeed * Time.deltaTime);
        transform.Translate(movement);
    }

    private void ChangeDir()
    {
        xSpeed = Random.Range(xSpeedMin, xSpeedMax);
    }
}
