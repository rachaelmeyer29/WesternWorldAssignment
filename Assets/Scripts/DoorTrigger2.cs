using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myDoor.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                myDoor.Play("DoorOpen2", 0, 0.0f);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myDoor.GetCurrentAnimatorStateInfo(0).IsName("StayOpen2"))
            {
                myDoor.Play("DoorClose2", 0, 0.0f);
            }
        }
    }
}
