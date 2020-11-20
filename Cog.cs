using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float speedOfSpin;

    void Update()
    {
        Move();

    }
    public void Move()
    {
      
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.Rotate(0, 0, Time.deltaTime * speedOfSpin);
    }



    }






