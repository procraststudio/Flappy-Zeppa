using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float speed;

    public static bool lifeBasicUpgrade;


    [SerializeField] AudioClip blurpSound;

    private void Start()
    {
        lifeBasicUpgrade = FindObjectOfType<Upgrades>().LifeBasicUpgradeOnOff(); 
    }
    void Update()
    {
        Move();

    }

    public void Move()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;

        }
    



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            //AudioSource.PlayClipAtPoint(PickupLife, Camera.main.transform.position);
            Destroy(this.gameObject);
           // Debug.Log("Life hit");
            AudioSource.PlayClipAtPoint(blurpSound, Camera.main.transform.position);
            
            if (lifeBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(20);
            }
            else
            {
               FindObjectOfType<Health>().ModifyHealth(15);
            }
        }

    }

}
