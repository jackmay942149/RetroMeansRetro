using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplySkin : MonoBehaviour
{
    // Get references to player
    private GameObject player;
    private SpriteRenderer sr;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            player = GameObject.Find("Player");
            sr = player.GetComponent<SpriteRenderer>();
            sr.sprite = this.gameObject.GetComponent<SkinManager>().ReturnSkin();
        }
    }
}
