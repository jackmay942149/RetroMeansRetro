using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBanner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Banner")
        {
            Destroy(this.gameObject);
        }
    }
}
