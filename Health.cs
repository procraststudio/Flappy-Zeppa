using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Health script from Tilevania tutorial by Ben Tristem, Gamedev.tv

    [SerializeField] int health = 100;
    [SerializeField] int maxHealth = 100;



    private int currentHealth;

    public event Action<float> OnHealthPctChanged = delegate { };

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }


    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth <= 0)
        {

            FindObjectOfType<LittleBaloon>().Die();

        }
        if (currentHealth > 100)
        {
            currentHealth = 100;
        }
        
       
        FindObjectOfType<LifeUpdater>().DisplayLife();

        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);

        
    }


    public int GetHealth()
    {
        return currentHealth;
    }

  


}
