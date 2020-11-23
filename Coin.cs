
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    [SerializeField] AudioClip pickupSound01;
    [SerializeField] AudioClip pickupSound02;
  


    [SerializeField] int scoreValue = 100;

    [SerializeField] float speed = 1.5f;

    public bool randomness = false;

    public static bool coinsBasicUpgrade;


    private void Start()
    {
        coinsBasicUpgrade = FindObjectOfType<Upgrades>().CoinsBasicUpgradeOnOff();
    }


    void Update()
    {
        if (randomness)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            // coin rotation:  transform.Rotate(0, 0, Time.deltaTime * speedOfSpin);
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }


    }




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (coinsBasicUpgrade)
            {
                FindObjectOfType<Gamesession>().AddToScore(scoreValue+50);
            }

            else
            {
             FindObjectOfType<Gamesession>().AddToScore(scoreValue);

            }
           
            PlayCoinSound();
            Destroy(gameObject);
        }

    }

    public void PlayCoinSound()
    {
        int generateSound = Random.Range(1, 2);

        if (generateSound == 1)
        {
            AudioSource.PlayClipAtPoint(pickupSound01, Camera.main.transform.position);
        }
        if (generateSound == 2)
        {
            AudioSource.PlayClipAtPoint(pickupSound02, Camera.main.transform.position);
        }

    }

}
