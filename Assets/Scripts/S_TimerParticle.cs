using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_TimerParticle : MonoBehaviour
{
    [SerializeField] private float deactivateTime = 2.0f * Time.deltaTime;
    [SerializeField] private float reactivateTime = 1.0f * Time.deltaTime;

    private float timer = 0f;

   
        
       private void Update()
       {
            if(gameObject.activeSelf)
            {
                   // (timer) += Time.deltaTime;
                   // Debug.Log("Tiempo Transcurrido: " +  timer.ToString("F0"));
            }

       }
    private void Start()
       {
            InvokeRepeating("DeactivateAndReactivate", 0f, deactivateTime + reactivateTime);
           
       }

        private void DeactivateAndReactivate()
        {
            gameObject.SetActive(false);
            Invoke("Reactivate", reactivateTime);
        }

        private void Reactivate()
        {
            gameObject.SetActive(true);
        }
        
  

   
    

}





