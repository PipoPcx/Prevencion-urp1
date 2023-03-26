using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarScriptEscalera : MonoBehaviour
{
    public Escalera escaleraScript;

    void Start()
    {
        // Desactiva el script "Escalera"
        escaleraScript.enabled = false;
    }

    void Update()
    {

    }
}
