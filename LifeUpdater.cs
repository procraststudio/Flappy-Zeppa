using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUpdater : MonoBehaviour
{
   
    Text lifeText;
    [SerializeField] GameObject lifeCanvas;

    private float timeToAppear = 1.5f;
    private float timeWhenDisappear;

    public int lifeNow;


    // Start is called before the first frame update
    void Start()
    {
        //  pointsCanvas.SetActive(false);
        lifeText = GetComponent<Text>();
        lifeText.enabled = false;

        // gameSession = FindObjectOfType<Gamesession>();

    }

    // Update is called once per frame
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
        //  pointsCanvas.SetActive(true); 
        lifeText.enabled = true;
        lifeNow = FindObjectOfType<Health>().GetHealth();
        lifeText.text = lifeNow.ToString();

        timeWhenDisappear = Time.time + timeToAppear;

        //   GetComponent<Animator>().SetTrigger("MoveUp");
    }

   

}

