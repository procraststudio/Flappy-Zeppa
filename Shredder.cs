﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {

         if (collision.tag=="Player")
        {
            FindObjectOfType<LittleBaloon>().Die();
        }
         else if (collision.tag=="baloon")
        {
            Destroy(collision.gameObject);
          
           
        }
        else if(collision.tag == "award")
        {
            
            Destroy(collision.gameObject);
          
        }

        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
           
        Destroy(collision.gameObject);
    }
}
