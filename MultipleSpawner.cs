using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject newObject;
    public float height;
    public float width;
    public float positionCorrect = 0;


    [SerializeField] public bool fixedPosition;
    [SerializeField] public float xPos;
    [SerializeField] public float yPos;

    [SerializeField] public int numberOfObjects;
    [SerializeField] bool timerOn;
    [SerializeField] public bool randomizer = true;


    void Update()
    {

        timer += Time.deltaTime;
        if (timer > maxTime)
        {
            SpawnMultiple();
            if (randomizer)
            {
                timer = Random.Range(0, 3);
            }
            else
            {
                timer = 0;
            }

        }

    }


    void SpawnMultiple()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject newObj = Instantiate(newObject);
            newObj.transform.position = transform.position + new Vector3(Random.Range(-width, width), Random.Range(-height, height) + positionCorrect, 0);

        }
    }

  
}

