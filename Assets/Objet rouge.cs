using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetrouge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// <summary>
        /// OnTriggerEnter is called when the Collider other enters the trigger.
        /// </summary>
        /// <param name="other">The other Collider involved in this collision.</param>
        /// 
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Boule 3")){
            Debug.Log("Collision avec Boule 3 détectée !");
            Destroy(gameObject);
        }
        
        }
}