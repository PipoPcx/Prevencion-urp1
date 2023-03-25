using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionMAscotas : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Mascota")) 
            // Reemplaza "Objeto" con el tag que le hayas asignado al objeto que quieres desactivar.
        {
            col.gameObject.SetActive(false); // Desactiva el objeto.
        }
    }
}
