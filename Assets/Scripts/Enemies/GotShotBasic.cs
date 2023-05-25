using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotShotBasic : MonoBehaviour
{
    // Create a variable for health
    [SerializeField] private int health;

    private void Update()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bubble")
        {
            health--;
        }
        Destroy(collider.gameObject, 0.01f);
    }
}
