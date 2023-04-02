using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasos : MonoBehaviour
{
    public AudioSource pie;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Suelo")
        {
            pie.Play();
        }
   }
}
