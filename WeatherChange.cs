using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherChange : MonoBehaviour
{
    // Weather change during level, stops the rain, activates sun
    
    public GameObject blackSun;
    public GameObject yellowSun;
    public GameObject sunnyBG;

   public GameObject rainCloudsSpawner;
    [SerializeField] public GameObject goodWeatherSpawners;

    public float timer;
    [SerializeField] public float durationOfRain;
    [SerializeField] public bool weatherTimerOn = true;



    private void Start()
    {
        goodWeatherSpawners.SetActive(false);
    }


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
            goodWeatherSpawners.SetActive(true);
   
            sunnyBG.SetActive(true);
            weatherTimerOn = false;
            Debug.Log("Weather changed");
            
        }

    }




}
