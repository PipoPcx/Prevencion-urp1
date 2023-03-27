using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionCamara : MonoBehaviour


{
    public GameObject objeto1;
    public GameObject objeto2;
    public Animator animador;
    private bool activado = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activado = !activado;
            objeto1.SetActive(false);
            objeto2.SetActive(true);
            animador.SetBool("camara piso 3", true);
            animador.Play("camara piso 3");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objeto1.SetActive(true);
            objeto2.SetActive(false);
            animador.SetBool("camara piso 3", false);
            animador.Play("camara piso 3");
        }
    }
}
