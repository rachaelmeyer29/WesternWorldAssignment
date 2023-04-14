using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBook : MonoBehaviour
{
    public Text BookText;
    public FirstPersonMovement firstPersonMovement;
    int bookc;

    // Update is called once per frame
    void Update()
    {
        bookc = firstPersonMovement.bookCount;
        BookText.text = "Guide Book: " + bookc + "/1";
    }
}
