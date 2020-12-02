using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUpdater : MonoBehaviour
{

    // Displays health change numbers under health bar 

    Text lifeText;
    [SerializeField] GameObject lifeCanvas;

    private float timeToAppear = 1.5f;
    private float timeWhenDisappear;

    public int lifeNow;



    void Start()
    {

        lifeText = GetComponent<Text>();
        lifeText.enabled = false;


    }


    void Update()
    {
         lifeNow = FindObjectOfType<Health>().GetHealth();

        
        if (lifeText.enabled && (Time.time >= timeWhenDisappear))
        {
            lifeText.enabled = false;
        }
       
    }


    public void DisplayLife()
    {

        lifeText.enabled = true;
        lifeNow = FindObjectOfType<Health>().GetHealth();
        lifeText.text = lifeNow.ToString();

        timeWhenDisappear = Time.time + timeToAppear;

    }

   

}

