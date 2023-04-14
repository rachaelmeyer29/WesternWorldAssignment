using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBottles : MonoBehaviour
{
    public Text BottlesText;
    public FirstPersonMovement firstPersonMovement;
    int bottlesc_collide;
    public Raycast raycast;
    int bottlesc_raycast;
    int jointBottleCount = 0;

    // Update is called once per frame
    void Update()
    {
        bottlesc_collide = firstPersonMovement.bottleCount;
        bottlesc_raycast = raycast.rayBottleCount;
        jointBottleCount = bottlesc_collide + bottlesc_raycast;

        BottlesText.text = "Bottles: " + jointBottleCount + "/10";
    }
}