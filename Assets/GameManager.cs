using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int puntos = 0;
    public TMP_Text puntajeText;
    
    
    public void sumarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
       
       
        Debug.Log("puntos: " + puntos);
    }

    private void Update()
    {
        puntajeText.text = "Puntaje: " + puntos;
    }
}
