﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamesession : MonoBehaviour
{
    static int score;
    [SerializeField] int health = 100;
    
    [SerializeField] Text scoreText;
    public int price;

    [SerializeField] public int debugPoints = 0;

 

    private void Awake()
    {
        SetUpSingleton();
    }

    private void Start()
    {
        scoreText = GetComponent<Text>();
        GetScore();


    }
    


    private void Update()
    {
      //  UpdateScore();
      //? not needed?
       
    }

    //private void UpdateScore()
    //{
    //    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    //    if (currentSceneIndex > 0)
    //    {
    //        scoreText.text = score.ToString();
    //    }
    //}



    private void SetUpSingleton()
    {
        int numberGamesessions = FindObjectsOfType<Gamesession>().Length;

        if (numberGamesessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score + debugPoints;
    }
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
        FindObjectOfType<PointsDisplay>().DisplayText(scoreValue);

           //if (scoreValue == 500)
        //{
        //    FindObjectOfType<PointsDisplay>().DisplaySecondText();
        //}

        //else if (scoreValue == 150)
        //{
        //    FindObjectOfType<PointsDisplay>().DisplayThirdText();
        //}

    }


    public void BuyUpgrades(int price)
    {
        score -= price;

    }


    public void ResetGame()

    {
        Destroy(gameObject);
    }

    public void ResetScore()

    {
       score = 0;
    }


    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }


    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        ResetScore();
        ResetGame();

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    
 
}
