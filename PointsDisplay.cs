using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    // Displays new points when player scores
    
    Text pointsText;
    [SerializeField] GameObject pointsCanvas;

    private float timeToAppear = 0.4f;
    private float timeWhenDisappear;

    public int scoreValue;



    void Start()
    {

        pointsText = GetComponent<Text>();

    }

    void Update()
    {
        if (pointsText.enabled && (Time.time >= timeWhenDisappear))
        {
            pointsText.enabled = false;
        }

    }


    public void DisplayText(int scoreValue)
    {

        pointsText.enabled = true;
        pointsText.text = scoreValue.ToString();

        timeWhenDisappear = Time.time + timeToAppear;


    }


}


