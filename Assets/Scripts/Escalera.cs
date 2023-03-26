using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escalera : MonoBehaviour
{
    
    public GameObject escalera;
    public GameObject escalera1;
    public GameObject escalera2;
    public GameObject escaleraUno;
    public GameObject escaleraDos;
    public GameObject escaleraTres;
    public GameObject escaleraCuatro;
    public GameObject escaleraCinco;
    public GameObject escaleraSeis;
    




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
            escalera.SetActive(true);
            Collider escaleraCollider1 = escalera1.GetComponent<Collider>();
            escaleraCollider1.isTrigger = true;
            escalera.SetActive(true);
            Collider escaleraCollider2 = escalera2.GetComponent<Collider>();
            escaleraCollider2.isTrigger = true;





        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Escalera"))
        {
            
            col.gameObject.SetActive(false);
            escaleraUno.SetActive(false);
            escaleraDos.SetActive(true);
         
        }

        if (col.gameObject.CompareTag("Escalera1"))
        {

            col.gameObject.SetActive(false);
            escaleraTres.SetActive(false);
            escaleraCuatro.SetActive(true);

        }
        if (col.gameObject.CompareTag("Escalera2"))
        {

            col.gameObject.SetActive(false);
            escaleraCinco.SetActive(false);
            escaleraSeis.SetActive(true);

        }
    }
            
           

}
