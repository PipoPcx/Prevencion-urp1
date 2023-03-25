using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairDetector : MonoBehaviour
{
    private bool onStairs = false;
    private Animator animator;
    public GameObject plataforma; // Agregar referencia al objeto animado

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
            animator.SetBool("LadderUp", true);
            
           
         
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EscaleraSinTrigger")
        {
            onStairs = false;
            animator.SetBool("Subir", false);
            plataforma.GetComponent<Animator>().SetBool("LadderUp", false); // Desactivar la animación del objeto
            animator.SetBool("LadderUp", false);
        }
    }
}
