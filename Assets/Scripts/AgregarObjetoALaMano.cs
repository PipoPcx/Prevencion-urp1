using UnityEngine;

public class AgregarObjetoALaMano : MonoBehaviour
{
    public GameObject objetoParaAgregar;
    public Transform posicionMano;

    void Start()
    {
        objetoParaAgregar.transform.parent = posicionMano;
        objetoParaAgregar.transform.localPosition = Vector3.zero;
        objetoParaAgregar.transform.localRotation = Quaternion.identity;
    }
}
