using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hangar : MonoBehaviour
{


    [SerializeField] int lifeBasicCost;
    [SerializeField] Text lifeBasicCost_text;
    [SerializeField] int shieldBasicCost;
    [SerializeField] Text shieldBasicCost_text;
    [SerializeField] int coinsBasicCost;
    [SerializeField] Text coinsBasicCost_text;

    [SerializeField] GameObject upgrade01Canvas;
    [SerializeField] GameObject upgrade02Canvas;
    [SerializeField] GameObject upgrade03Canvas;

    [SerializeField] GameObject notEnoughPointsCanvas;

    [SerializeField] Text pointsToSpend;
    public bool upgrade01Installed;
    public bool upgrade02Installed;
    public bool upgrade03Installed;

    public int actualPoints;

    void Start()
    {
        actualPoints = FindObjectOfType<Gamesession>().GetScore();
        pointsToSpend = GetComponent<Text>();

        upgrade01Installed = FindObjectOfType<Upgrades>().LifeBasicUpgradeOnOff();
        upgrade02Installed = FindObjectOfType<Upgrades>().ShieldBasicUpgradeOnOff();
        upgrade03Installed = FindObjectOfType<Upgrades>().CoinsBasicUpgradeOnOff();

        //  lifeBasicCost_text = GetComponent<Text>();
        lifeBasicCost_text.text = lifeBasicCost.ToString();
        shieldBasicCost_text.text = shieldBasicCost.ToString();
        coinsBasicCost_text.text = coinsBasicCost.ToString();
        notEnoughPointsCanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Upgrade01Appear();
        Upgrade02Appear();
        Upgrade03Appear();

        actualPoints = FindObjectOfType<Gamesession>().GetScore();
    }

    public void Upgrade01Appear()
    {
        if ((actualPoints < lifeBasicCost) ||(upgrade01Installed))
        {
            upgrade01Canvas.SetActive(false);

        }
      
    }

    public void Upgrade02Appear()
    {
        if ((actualPoints < shieldBasicCost) || (upgrade02Installed))
        {
            upgrade02Canvas.SetActive(false);

        }
    }

    public void Upgrade03Appear()
    {
        if ((actualPoints < coinsBasicCost) || (upgrade03Installed))
        {
            upgrade03Canvas.SetActive(false);

        }
    }


    public void LifeBasicUpgrade()
    {
      if (actualPoints>=lifeBasicCost)
                {
            FindObjectOfType<Gamesession>().BuyUpgrades(lifeBasicCost);
             FindObjectOfType<Upgrades>().LifeBasicUpgradeOn();
            
            upgrade01Canvas.SetActive(false);
        }
      else
        {
            notEnoughPointsCanvas.SetActive(true);
            Debug.Log("Not enough gold");
        }
    }

    public void ShieldBasicUpgrade()
    {
        if (actualPoints >= shieldBasicCost)
        {
            FindObjectOfType<Gamesession>().BuyUpgrades(shieldBasicCost);
            FindObjectOfType<Upgrades>().ShieldBasicUpgradeOn();
          

            upgrade02Canvas.SetActive(false);
        }
        else
        {
            notEnoughPointsCanvas.SetActive(true);
            Debug.Log("Not enough gold");
        }
    }

    public void CoinsBasicUpgrade()
    {
        if (actualPoints >= coinsBasicCost)
        {
            FindObjectOfType<Gamesession>().BuyUpgrades(coinsBasicCost);
            FindObjectOfType<Upgrades>().CoinsBasicUpgradeOn();


            upgrade03Canvas.SetActive(false);
        }
        else
        {
            notEnoughPointsCanvas.SetActive(true);
            Debug.Log("Not enough gold");
        }
    }




}
