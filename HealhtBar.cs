﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealhtBar : MonoBehaviour
{
  
   // Script from Tilevania tutorial by Ben Tristem, Gamedev.tv
    
    
    [SerializeField] private Image foregroundImage;
    [SerializeField] private float updateSpeedSeconds = 0.1f;


    private void Awake()
    {
        GetComponentInParent<Health>().OnHealthPctChanged += HandleHealthChanged;

    }

    private void HandleHealthChanged(float pct)
    {
        StartCoroutine(ChangeToPct(pct));
    }

    private IEnumerator ChangeToPct(float pct)
    {
        float preChangePct = foregroundImage.fillAmount;
        float elapsed = 0f;

        while (elapsed < updateSpeedSeconds)
        {
            elapsed += Time.deltaTime;
            foregroundImage.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / updateSpeedSeconds);
            yield return null;
        }
        foregroundImage.fillAmount = pct;
    }

}