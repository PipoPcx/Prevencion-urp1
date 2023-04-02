using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gato"))
        // Reemplaza "Objeto" con el tag que le hayas asignado al objeto que quieres desactivar.
        {
            other.gameObject.SetActive(false); // Desactiva el objeto.
            Debug.Log("gato");
        }
    }

}
