using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivateDisplays : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }

        text.text = "displays: " + Display.displays.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
