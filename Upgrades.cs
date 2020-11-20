using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject lifeBasicIcon;
    [SerializeField] GameObject shieldBasicIcon;
    [SerializeField] GameObject coinsBasicIcon;

    public static bool lifeBasicUpgrade;
    public static bool shieldBasicUpgrade;
    public static bool coinsBasicUpgrade;
    private void Awake()
    {
    // SetUpSingleton();
    }



    void Start()
    {
       LifeBasicUpgradeOnOff();
       ShieldBasicUpgradeOnOff();
        CoinsBasicUpgradeOnOff();

        lifeBasicIcon.SetActive(false);
        shieldBasicIcon.SetActive(false);
        coinsBasicIcon.SetActive(false);

        ShowUpgrade01();
        ShowUpgrade02();
        ShowUpgrade03();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowUpgrade01()
    {
        if (lifeBasicUpgrade)
        {
            lifeBasicIcon.SetActive(true);
        }
       
    }

    public void ShowUpgrade02()
    {
        if (shieldBasicUpgrade)
        {
            shieldBasicIcon.SetActive(true);
        }

    }

    public void ShowUpgrade03()
    {
        if (coinsBasicUpgrade)
        {
            coinsBasicIcon.SetActive(true);
        }

    }


    public void LifeBasicUpgradeOn()
    {

        lifeBasicUpgrade = true;
        Debug.Log("Life upgrade installed");
        lifeBasicIcon.SetActive(true);
        Debug.Log("Life basic icon is on");

       

    }
    public bool LifeBasicUpgradeOnOff()
        {
        return lifeBasicUpgrade;
        }

    public void ShieldBasicUpgradeOn()
    {

        shieldBasicUpgrade = true;
         Debug.Log("Shield upgrade installed");
        shieldBasicIcon.SetActive(true);
        Debug.Log("Shield basic icon is on");


    }
    public bool ShieldBasicUpgradeOnOff()
    {
        return shieldBasicUpgrade;
    }


    public void CoinsBasicUpgradeOn()
    {

        coinsBasicUpgrade = true;
        Debug.Log("Coins upgrade installed");
        coinsBasicIcon.SetActive(true);
        Debug.Log("Coins basic icon is on");


    }
    public bool CoinsBasicUpgradeOnOff()
    {
        return coinsBasicUpgrade;
    }





    //private void SetUpSingleton()
    //{
    //    int numberUpgrades = FindObjectsOfType<Upgrades>().Length;

    //    if (numberUpgrades > 1)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}
}
