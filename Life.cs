using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Script attached to hearts (lives)
    
    public float speed;

    public static bool lifeBasicUpgrade;


    [SerializeField] AudioClip blurpSound;
    [SerializeField] [Range(0, 1)] float blurpVolume;

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
        
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(blurpSound, Camera.main.transform.position, blurpVolume);
            
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
