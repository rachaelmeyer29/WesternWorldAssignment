using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    public Text winTextDisplay;
    public FirstPersonMovement firstPersonMovement;
    int aidc;
    int bottlesc;
    int bookc;

    void Start()
    {
        winTextDisplay.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        bottlesc = firstPersonMovement.bottleCount;
        bookc = firstPersonMovement.bookCount;
        aidc = firstPersonMovement.aidCount;
        if (aidc == 2 && bottlesc == 7 && bookc == 1)
        {
            winTextDisplay.enabled = true;
        }
    }
}
