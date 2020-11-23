using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Airport : MonoBehaviour
{
    [SerializeField] int scoreValue = 500;
   // [SerializeField] AudioClip FunfairSound;

    public int timeToWait = 1;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Gamesession>().AddToScore(scoreValue);
           // AudioSource.PlayClipAtPoint(FunfairSound, Camera.main.transform.position);
            Time.timeScale = 0;
            StartCoroutine(WaitForTime());
           


           
      
        }
    }
    IEnumerator WaitForTime()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(timeToWait);
        FindObjectOfType<Gamesession>().LoadNextScene();
    }
}
