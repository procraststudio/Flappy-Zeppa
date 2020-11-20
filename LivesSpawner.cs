using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject heart;
    public float height;
    public float positionCorrect = 0;
    public int timeToDestroy = 20;
    public int health;

    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        health = FindObjectOfType<Health>().GetHealth();
        timer += Time.deltaTime;
        if ((timer > maxTime) && (health<100))
        {
            NewLife();
            timer = Random.Range(0, 3);


        }

    }

    public void NewLife()
    {
        GameObject newzep = Instantiate(heart);
        newzep.transform.position = transform.position + new Vector3(0, Random.Range(-height, height)+positionCorrect, 0);
        Destroy(newzep, timeToDestroy);

    }
}

