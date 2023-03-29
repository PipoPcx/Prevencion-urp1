
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityStandardAssets.Characters.ThirdPerson;

public class Teletransport : MonoBehaviour
{


    public Transform entryPortal;
    public Transform exitPortal;
    public GameObject camara;
    public GameObject posicionCamara;
    public float offSet;
    //private ThirdPersonUserControl tPC;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            exitPortal.gameObject.SetActive(false);
            print("rotacion: " + Mathf.RoundToInt(other.transform.localEulerAngles.y));


          
            other.transform.position = new Vector3(exitPortal.position.x , exitPortal.position.y, exitPortal.position.z + offSet);
            camara.transform.position = posicionCamara.transform.position;

            if (Mathf.RoundToInt(other.transform.localEulerAngles.y) == 180)
            {
                other.transform.localEulerAngles = new Vector3 (0, 0, 0);

            }
            else
            {
                other.transform.localEulerAngles = new Vector3(0, 180, 0);


            }

            //tPC =other.GetComponent<ThirdPersonUserControl>();
           // tPC.canMove = false;

           // tPC.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            Invoke(nameof(EnableExitPortalCollider), 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                       camara.transform.position = posicionCamara.transform.position;
        }
    }

    private void EnableExitPortalCollider()

    {
        exitPortal.gameObject.SetActive(true);
        //tPC.canMove = true;


    }



}

