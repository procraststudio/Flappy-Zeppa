﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Airport : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Gamesession>().LoadNextScene();


        }
    }
   
}
