using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
  
    public void LoadNextScene()
    {
        FindObjectOfType<Gamesession>().LoadNextScene();
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        ResetGame();

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResetGame()

    {
        Destroy(gameObject);
    }

    public void StartFirstLevel()
    {

        SceneManager.LoadScene(1);
    }

}


