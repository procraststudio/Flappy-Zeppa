using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    // Scrolling background
    
    [SerializeField] public float speed = 0.2f;


    void Update()
    {
        Move();

    }  
    
    void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;


    }
}
