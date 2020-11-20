using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
   
    
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
            {

            FindObjectOfType<LittleBaloon>().Die();
            Debug.Log("Sun trigger entered");
        }

    }
}
