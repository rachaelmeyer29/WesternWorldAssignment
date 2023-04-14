using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public Text StartTextDisplay;
    float timer = 5f;

    public void Start()
    {
        StartTextDisplay.enabled = true;
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (Input.anyKey && timer <= 0)
        {
            StartTextDisplay.enabled = false;
        }
    }
}