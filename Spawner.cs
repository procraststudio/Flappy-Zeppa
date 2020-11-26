using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject newObject;
    public float height;
    public float positionCorrect = 0;
    public int timeToDestroy = 20;

    [SerializeField] public bool fixedPosition;
    [SerializeField] public float xPos;
    [SerializeField] public float yPos;

    [SerializeField] bool timerOn;

    [SerializeField] public bool randomizer = true;


 

    // Update is called once per frame
    void Update()
    {
      
        timer += Time.deltaTime;
        if(timer > maxTime)
            {
            SpawnObjects();
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

    public void SpawnObjects()
    {

        if (fixedPosition)
        {
            GameObject newObj = Instantiate(newObject);
            newObj.transform.position = transform.position + new Vector3(xPos, yPos, 0);
        }
        else
        {
            GameObject newObj = Instantiate(newObject);
            newObj.transform.position = transform.position + new Vector3(0, Random.Range(-height, height) + positionCorrect, 0);
            Destroy(newObj, timeToDestroy);
        }

    }
}
