using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Perro : MonoBehaviour
{
    private int puntosGanados = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            Destroy(gameObject);
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.sumarPuntos(puntosGanados);
        }
        

            
    }

}
