using UnityEngine;

public class AnimatorEvents : MonoBehaviour
{
   
    // Este m�todo se llamar� cuando termine la animaci�n
    public void OnAnimationEnd()
    {
        // Obt�n la referencia al Animator del jugador
        Animator animator = GetComponent<Animator>();

        // Configura el valor del bool "Ataque" en false
        animator.SetBool("Ataque", false);
        
    }
}