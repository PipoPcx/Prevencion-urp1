using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscaleraDeMano : MonoBehaviour
{
    public GameObject personaje; // Referencia al objeto del personaje 3D
    public Transform puntoDeSubida; // Punto de la escalera donde el personaje puede subir

    public bool subiendo = false; // Bandera para indicar si el personaje está subiendo la escalera
    public float velocidadSubida = 2f; // Velocidad a la que el personaje subirá la escalera

    private void OnTriggerStay(Collider other)
    {
        // Verificar si el objeto en contacto es el objeto del personaje y si se presionó la tecla W
        if (other.gameObject == personaje && Input.GetKey(KeyCode.W))
        {
            subiendo = true;
            Debug.Log("true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reiniciar la bandera de subida cuando el personaje deja el punto de subida
        if (other.gameObject == personaje)
        {
            subiendo = false;
            personaje.transform.position -= new Vector3(0, 0, 2);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        // Si el personaje está subiendo la escalera, moverlo hacia arriba
        if (subiendo)
        {
            Debug.Log("true");
            Vector3 posicionActual = personaje.transform.position;
            Vector3 nuevaPosicion = new Vector3(puntoDeSubida.position.x,
                                                 posicionActual.y + velocidadSubida * Time.fixedDeltaTime,
                                                 posicionActual.z);
            personaje.transform.position = nuevaPosicion;
        }
    }

    }
