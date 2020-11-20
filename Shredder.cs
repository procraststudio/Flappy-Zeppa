using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
         if (collision.tag=="Player")
        {
            FindObjectOfType<LittleBaloon>().Die();
        }
         else if (collision.tag=="mountain")
        {
            Debug.Log("Mountain hit");
            return;
        }
        else
        {
          Destroy(collision.gameObject);
          Debug.Log("Object destroyed");
        }
    }
}
