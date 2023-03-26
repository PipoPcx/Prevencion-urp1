
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour
{


    public Transform entryPortal;
    public Transform exitPortal;
    public GameObject camara;
    public GameObject posicionCamara;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))

        {
            Vector3 positionOffset = other.transform.position - entryPortal.position;
            other.transform.position = exitPortal.position + positionOffset;
            camara.transform.position = posicionCamara.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 positionOffset = other.transform.position - exitPortal.position;
            other.transform.position = entryPortal.position + positionOffset;
            camara.transform.position = posicionCamara.transform.position;
        }
    }

}

