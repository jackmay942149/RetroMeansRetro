using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkinManager : MonoBehaviour
{
    // Create a reference to the SkinSelector
    [SerializeField] private GameObject skinSelector;
    private SpriteRenderer sr;

    // Create the list of sprites
    [SerializeField] private List<Sprite> sprites;
    private int currSkin;

    private void Start()
    {
        sr = skinSelector.GetComponent<SpriteRenderer>();
        currSkin = 0;
        sr.sprite = sprites[currSkin];
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
