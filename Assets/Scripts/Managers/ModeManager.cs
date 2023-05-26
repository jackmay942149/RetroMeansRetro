using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModeManager : MonoBehaviour
{
    // Create a reference to the ModeSelector
    [SerializeField] private TextMeshProUGUI modeSelector;
    
    // Create the list of modes
    [SerializeField] private List<string> modes;
    private int currMode;

    private void Start()
    {
        currMode = 0;
        modeSelector.text = modes[currMode];
    }

    // Function to change to the previous mode
    public void PrevMode()
    {
        currMode--;

        if (currMode < 0)
        {
            currMode = modes.Count - 1;
        }

        modeSelector.text = modes[currMode];
    }
    // Function to change to the next mode
    public void NextMode()
    {
        currMode++;
        
        if (currMode == modes.Count)
        {
            currMode = 0;
        }

        modeSelector.text = modes[currMode];
    }

    public string ReturnMode()
    {
        return modes[currMode];
    }

}