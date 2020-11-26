using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherChange : MonoBehaviour
{
    public GameObject blackSun;
    public GameObject yellowSun;
    public GameObject sunnyBG;

   public GameObject rainCloudsSpawner;

    public float timer;
    [SerializeField] public float durationOfRain;
    [SerializeField] public bool weatherTimerOn = true;
    

  
    void Update()
    {
            if (weatherTimerOn)
            {
            timer += Time.deltaTime;
        }
        changeWeather();
    }

    public void changeWeather()
    {
        if (timer >= durationOfRain)
        {
            Destroy(GameObject.FindWithTag("cloud_rain"));
            Destroy(rainCloudsSpawner);
            blackSun.SetActive(false);
             yellowSun.SetActive(true);
   
            sunnyBG.SetActive(true);
            weatherTimerOn = false;
            Debug.Log("Weather changed");
            
        }

    }




}
