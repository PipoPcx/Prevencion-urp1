using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escalera : MonoBehaviour
{
    
    public GameObject escalera;
    public GameObject player;
    public Button boton;
    public GameObject objetoVacio;
    public GameObject escaleraUno;
    public GameObject escaleraDos;
    

    private void Start()
    {
        

    }

    public void BotonActivarEscalera()
    {
        if (escalera != null)
        {
            escalera.SetActive(true);
            Collider escaleraCollider = escalera.GetComponent<Collider>();
            escaleraCollider.isTrigger = true;
            boton.gameObject.SetActive(false);
           // escalera.transform.position = player.transform.position;
            escalera.transform.SetPositionAndRotation(objetoVacio.transform.position, objetoVacio.transform.rotation);


            

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Escalera"))
        {
            boton.gameObject.SetActive(true);
            col.gameObject.SetActive(false);
            escaleraUno.SetActive(false);
            escaleraDos.SetActive(true);
        }
    }

}
