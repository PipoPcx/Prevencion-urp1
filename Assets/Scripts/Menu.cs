using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("3P");

    }

    public void CargarNivel(string npmbreNivel)
    {
        SceneManager.LoadScene("nombreNivel");
    }

    public void Salir()
    {
        Application.Quit();
    }
}