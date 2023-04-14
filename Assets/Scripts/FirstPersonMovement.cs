using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public Rigidbody rb;
    public float gravityScale = 5;

    public int bottleCount;
    public int aidCount;
    public int bookCount;

    public AudioSource ouch;
    public AudioSource bottleCollection;
    public AudioSource bookAndKitCollection;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 localDirection = transform.TransformDirection(direction);
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        direction.x = inputVector.x;
        direction.z = inputVector.y;
        direction.y = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cactus"))
        {
            ouch.Play();
        }

        if (other.gameObject.CompareTag("Bottle"))
        {
            other.gameObject.SetActive(false);
            bottleCount++;
            bottleCollection.Play();
        }

        if (other.gameObject.CompareTag("FirstAid"))
        {
            other.gameObject.SetActive(false);
            aidCount++;
            bookAndKitCollection.Play();
        }

        if (other.gameObject.CompareTag("GuideBook"))
        {
            other.gameObject.SetActive(false);
            bookCount = 1;
            bookAndKitCollection.Play();
        }
    }
}
