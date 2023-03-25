using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tp : MonoBehaviour
{
    public GameObject ThePlayer;
    public Transform Target;
   
  
    

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = Target.position;
       
        ThePlayer.transform.rotation = Quaternion.Euler(0,ThePlayer.transform.rotation.y + 180,0);
        ThePlayer.transform.position -= new Vector3(0,0,2);

    }

}
