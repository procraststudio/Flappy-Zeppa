using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Rain : MonoBehaviour
{
    public float maxTime = 2f;
    private float timer = 0f;
    public int damage = 2;


    void Update()
    {
     
        timer += Time.deltaTime;
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((timer > maxTime) && (collision.tag == "Player"))
        {
            Attack();
        }

    }

    public void Attack()
    {
        FindObjectOfType<Health>().ModifyHealth(-damage);
        timer = 0f;
    }
}
