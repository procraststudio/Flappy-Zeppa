using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
  
    public void LoadNextScene()
    {
        // FindObjectOfType<Gamesession>().LoadNextScene();
        FindObjectOfType<Gamesession>().ExitShop();
    }
    public void LoadStartScene()
    {
        //ResetGame();
        // SceneManager.LoadScene(0);
        // FindObjectOfType<GameOver>().QuitToMenu();
        FindObjectOfType<Gamesession>().ResetScore();
        Debug.Log("Points reset");
        FindObjectOfType<Upgrades>().ResetUpgrades();
        Debug.Log("Upgrades reset");

        SceneManager.LoadScene(0);
       


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


