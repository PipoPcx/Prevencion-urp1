using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairDetector : MonoBehaviour
{
    private bool onStairs = false;
    private Animator animator;
    public GameObject plataforma; // Agregar referencia al objeto animado
    public GameObject plataforma2; // Agregar referencia al objeto animado
    public GameObject plataforma3; // Agregar referencia al objeto animado
    public GameObject plataforma4; // Agregar referencia al objeto animado
    public GameObject plataforma5; // Agregar referencia al objeto animado
    public GameObject plataforma6; // Agregar referencia al objeto animado

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EscaleraSinTrigger")
        {
            onStairs = true;
            
            animator.SetBool("Subir", true);
            plataforma.GetComponent<Animator>().SetBool("LadderUp", true); // Activar la animación del objeto
            plataforma2.GetComponent<Animator>().SetBool("LadderUp1", true); // Activar la animación del objeto
            plataforma3.GetComponent<Animator>().SetBool("LadderUp2", true); // Activar la animación del objeto
            plataforma4.GetComponent<Animator>().SetBool("LadderUp3", true); // Activar la animación del objeto
            plataforma5.GetComponent<Animator>().SetBool("LadderUp4", true); // Activar la animación del objeto
            plataforma6.GetComponent<Animator>().SetBool("LadderUp5", true); // Activar la animación del objeto
            animator.SetBool("LadderUp", true);
            animator.SetBool("LadderUp1", true);
            animator.SetBool("LadderUp2", true);
            animator.SetBool("LadderUp3", true);
            animator.SetBool("LadderUp4", true);
            animator.SetBool("LadderUp5", true);



        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EscaleraSinTrigger")
        {
            onStairs = false;
            animator.SetBool("Subir", false);
            animator.SetBool("Subir1", false);

            plataforma.GetComponent<Animator>().SetBool("LadderUp", false); // Desactivar la animación del objeto
            plataforma2.GetComponent<Animator>().SetBool("LadderUp1", false); // Desactivar la animación del objeto
            plataforma3.GetComponent<Animator>().SetBool("LadderUp2", false); // Desactivar la animación del objeto
            plataforma4.GetComponent<Animator>().SetBool("LadderUp3", false); // Desactivar la animación del objeto
            plataforma5.GetComponent<Animator>().SetBool("LadderUp4", false); // Desactivar la animación del objeto
            plataforma6.GetComponent<Animator>().SetBool("LadderUp5", false); // Desactivar la animación del objeto
            animator.SetBool("LadderUp", false);
            animator.SetBool("LadderUp1", false);
            animator.SetBool("LadderUp2", false);
            animator.SetBool("LadderUp3", false);
            animator.SetBool("LadderUp4", false);
            animator.SetBool("LadderUp5", false);
        }
    }
}
