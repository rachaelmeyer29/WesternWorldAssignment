using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFirstAid : MonoBehaviour
{
    public Text firstaidText;
    public FirstPersonMovement firstPersonMovement;
    int aidc;

    // Update is called once per frame
    void Update()
    {
        aidc = firstPersonMovement.aidCount;
        firstaidText.text = "First Aid Kits: " + aidc + "/2";
    }
}
