using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    Gamesession gameSession;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<Gamesession>();
      
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }

}
