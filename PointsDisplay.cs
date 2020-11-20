using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    Text pointsText;
    [SerializeField] GameObject pointsCanvas;

    private float timeToAppear = 0.4f;
    private float timeWhenDisappear;

    public int scoreValue;


    // Start is called before the first frame update
    void Start()
    {
        //  pointsCanvas.SetActive(false);
        pointsText = GetComponent<Text>();

        // gameSession = FindObjectOfType<Gamesession>();

    }

    // Update is called once per frame
    void Update()
    {
        if (pointsText.enabled && (Time.time >= timeWhenDisappear))
        {
            pointsText.enabled = false;
        }

    }


    public void DisplayText()
    {
        //  pointsCanvas.SetActive(true); 
        pointsText.enabled = true;

        pointsText.text = "100";

        timeWhenDisappear = Time.time + timeToAppear;

       //   GetComponent<Animator>().SetTrigger("MoveUp");


    }

    public void DisplaySecondText()
    {
        //  pointsCanvas.SetActive(true); 
        pointsText.enabled = true;
        pointsText.text = "500";

        timeWhenDisappear = Time.time + timeToAppear;

      //   GetComponent<Animator>().SetTrigger("MoveUp");


    }

    public void DisplayThirdText()
    {
       
        pointsText.enabled = true;
        pointsText.text = "150";

        timeWhenDisappear = Time.time + timeToAppear;



    }

}


