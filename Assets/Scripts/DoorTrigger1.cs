using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger1 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myDoor.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                myDoor.Play("DoorOpen1", 0, 0.0f);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myDoor.GetCurrentAnimatorStateInfo(0).IsName("StayOpen1"))
            {
                myDoor.Play("DoorClose1", 0, 0.0f);
            }
        }
    }
}
