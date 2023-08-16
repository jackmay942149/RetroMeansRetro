using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SkinManager : MonoBehaviour
{
    // Create a reference to the SkinSelector
    [SerializeField] private GameObject skinSelector;
    private SpriteRenderer sr;

    // Create the list of sprites
    [SerializeField] private List<Sprite> sprites;
    private int currSkin;

    private GameObject player;
    private SpriteRenderer playerSr;

    private void Start()
    {
        DontDestroyOnLoad(this);
        sr = skinSelector.GetComponent<SpriteRenderer>();
        currSkin = 0;
        sr.sprite = sprites[currSkin];
    }

    void Awake()
    {
        Debug.Log("Worked!");
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            player = GameObject.Find("Player");
            playerSr = player.GetComponent<SpriteRenderer>();
            playerSr.sprite = ReturnSkin();
        }
    }

    // Function to switch to next skin
    public void NextSkin()
    {
        currSkin++;

        if (currSkin == sprites.Count)
        {
            currSkin = 0;
        }

        sr.sprite = sprites[currSkin];

        EventSystem.current.SetSelectedGameObject(null);
    }

    // Function to switch to previous skin
    public void PrevSkin()
    {
        currSkin--;

        if (currSkin < 0)
        {
            currSkin = sprites.Count - 1;
        }

        sr.sprite = sprites[currSkin];

        EventSystem.current.SetSelectedGameObject(null);
    }


    public Sprite ReturnSkin()
    {
        Sprite sp = sprites[currSkin];
        return sp;
    }
}
