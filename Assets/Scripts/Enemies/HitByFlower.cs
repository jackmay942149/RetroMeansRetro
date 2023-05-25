using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByFlower : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Flower")
        {
            Destroy(this.gameObject);
        }
    }
}
