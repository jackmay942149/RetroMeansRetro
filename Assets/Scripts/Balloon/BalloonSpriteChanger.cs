using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpriteChanger : MonoBehaviour
{
    // Create a variable to hold a list of sprites
    [SerializeField] private List<Sprite> sprites;
    private Sprite sp;
    private SpriteRenderer sr;
    private void Start()
    {
        sp = sprites[Random.Range(0, sprites.Count)];
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sp;
        sr.color = new Color(1.0f, 1.0f, 1.0f, 0.7f);
    }
}
