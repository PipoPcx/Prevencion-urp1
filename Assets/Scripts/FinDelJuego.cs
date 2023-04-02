using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDelJuego : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verificar si el objeto que colisiona es el personaje
        {
            SceneManager.LoadScene("Fin"); // Cargar la escena "ganaste"
        }
    }
}
