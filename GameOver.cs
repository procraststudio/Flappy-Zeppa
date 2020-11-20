using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    public GameObject gameOverCanvas;

    void Start()
    {
       
        gameOverCanvas.SetActive(false);
    }

 public void GameOverMenu()
    {
         gameOverCanvas.SetActive(true);
         Time.timeScale = 0.2f;
    }


    public void PlayAgain()
    {
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        FindObjectOfType<Gamesession>().ResetScore();
        SceneManager.LoadScene(currentSceneIndex);
   
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1;
        FindObjectOfType<Gamesession>().ResetScore();
        SceneManager.LoadScene(0);
        gameOverCanvas.SetActive(false);
    }

}
