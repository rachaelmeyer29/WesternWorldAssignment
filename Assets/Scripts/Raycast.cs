using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Raycast : MonoBehaviour
{
    public AudioSource bottleCollection;
    public int rayBottleCount = 0;
    [SerializeField] LineRenderer lineRender;
    private Raycasting rc;

    private void Awake()
    {
        rc = new Raycasting();
    }

    private void OnEnable()
    {
        rc.Player.Collect.started += SpaceClicked;
        rc.Player.Collect.canceled += SpaceReleased;
        rc.Player.Enable();
    }

    private void OnDisable()
    {
        rc.Player.Collect.started -= SpaceClicked;
        rc.Player.Collect.canceled -= SpaceReleased;
    }

    private void SpaceClicked(InputAction.CallbackContext obj)
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        Vector3 originOfRay = ray.GetPoint(1);
        Vector3 currentCamPos = Camera.main.transform.position - new Vector3(0, .3f, 0);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            lineRender.material.color = Color.white;
            lineRender.enabled = true;
            lineRender.SetPosition(0, currentCamPos);
            lineRender.SetPosition(1, hit.point);

            if (hit.collider.gameObject.CompareTag("RayTarget"))
            {
                hit.collider.gameObject.SetActive(false);
                bottleCollection.Play();
                rayBottleCount++;
            }
        }
        else
        {
            lineRender.enabled = false;
        }
    }

    private void SpaceReleased(InputAction.CallbackContext obj)
    {
        lineRender.enabled = false;
    }
}
