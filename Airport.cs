using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Airport : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            if (SceneManager.GetActiveScene().name == "FinalLevel")
            {
                SceneManager.LoadScene("Victory");
            }

            else
            {
                FindObjectOfType<Gamesession>().SetActualLevel();
                Debug.Log("Actual scene set");

              
                SceneManager.LoadScene("Shop01");
            }
        }
    }
   
}
