using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntos = 0;
    
    public void sumarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
        Debug.Log("puntos: " + puntos);
    }
}
