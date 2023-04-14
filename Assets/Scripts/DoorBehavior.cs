using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{

    private Quaternion openPos;
    private Quaternion closedPos;

    public float frames;

    // Start is called before the first frame update
    void Start()
    {
        closedPos.Set(0, 0, 0, 1.0f);
        openPos.Set(0, -90, 0, 1.0f);

    }

    //public void CloseGate()
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MoveDoor(openPos, closedPos, 1 / frames));
        }
    }

    //public void OpenGate()
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(MoveDoor(closedPos, openPos, 1 / frames));
        }
    }

    public IEnumerator MoveDoor(Quaternion startPos, Quaternion endPos, float step)
    {
        for (float i = 0; i <= 1; i += step)
        {
            Quaternion newPosition = Quaternion.Lerp(startPos, endPos, i);
            transform.rotation = newPosition;
            yield return null;
        }
    }
}
