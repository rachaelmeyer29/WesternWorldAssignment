using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmChairJump : MonoBehaviour
{
    public float jumpForce;
    public AudioSource audioPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();

            playerRb.AddForce(other.transform.up * jumpForce, ForceMode.Impulse);

            if (audioPlayer.isPlaying)
            {
                audioPlayer.Stop();
                audioPlayer.Play();
            }
            else
                audioPlayer.Play();
        }
    }
}