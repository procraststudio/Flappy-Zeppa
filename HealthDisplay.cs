using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
   
    
    [SerializeField] Text healthText;
     LittleBaloon baloon;

    void Start()
    {
        healthText = GetComponent<Text>();
        baloon = FindObjectOfType<LittleBaloon>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = baloon.GetHealth().ToString();
        Debug.Log("Health updated");
    }
}
