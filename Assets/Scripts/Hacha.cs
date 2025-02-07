using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hacha : MonoBehaviour
{
    public GameObject hacha;
    public Button boton;
    public Animator animator;
    public GameObject player;
    public Transform mano;
    public GameObject hachaGrande;
    public GameObject hachaChica;
    public AudioClip clip;


    private void Start()
    {
        animator = player.GetComponent<Animator>();
    }

    public void BotonActivarHacha()
    {
        if (hacha != null)
        {
            Collider hachaCollider = hachaChica.GetComponent<Collider>();
            hachaCollider.enabled = true;

           
            animator.SetBool("Ataque", true);
            GetComponent<AudioSource>().PlayOneShot(clip);

            Invoke("DesactivarAtaque", 1.0f);
        }
    }

    void DesactivarAtaque()
    {
        animator.SetBool("Ataque", false);
        Collider hachaCollider = hachaChica.GetComponent<Collider>();
        hachaCollider.enabled = false;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Hacha"))
        {
            boton.gameObject.SetActive(true);
            col.gameObject.SetActive(false);
            hachaGrande.SetActive(false);
            hachaChica.SetActive(true);
        }
    }
}
