using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleIncreaseSpeed : MonoBehaviour
{
    // Get reference to script and speed
    private EnemyMovementBasic script;
    private float speed;

    // Create a variable for speed multiplier
    [SerializeField] private float speedMulti;

    private void Start()
    {
        script = GetComponent<EnemyMovementBasic>();
        speed = script.Speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bubble")
        {
            speed *= speedMulti;
            script.Speed = speed;
        }
    }
}
