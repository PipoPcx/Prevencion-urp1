using UnityEngine;

public class AnimatorEvents : MonoBehaviour
{
   
    // Este método se llamará cuando termine la animación
    public void OnAnimationEnd()
    {
        // Obtén la referencia al Animator del jugador
        Animator animator = GetComponent<Animator>();

        // Configura el valor del bool "Ataque" en false
        animator.SetBool("Ataque", false);
        
    }
}