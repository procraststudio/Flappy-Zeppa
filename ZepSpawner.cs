using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject zeppelin;
    public float height;
    public float positionCorrect = 0;
    public int timeToDestroy = 20;

    [SerializeField] bool timerOn;


 

    // Update is called once per frame
    void Update()
    {
      
        timer += Time.deltaTime;
        if(timer > maxTime)
            {
            NewZep();
            timer = Random.Range(0, 3);
           
            
        }
        
    }

    public void NewZep()
    {
        GameObject newzep = Instantiate(zeppelin);
        newzep.transform.position = transform.position + new Vector3(0, Random.Range(-height, height)+positionCorrect, 0);
        Destroy(newzep, timeToDestroy);

    }
}
