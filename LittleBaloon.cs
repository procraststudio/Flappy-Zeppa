using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LittleBaloon : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rb;
    private Collider2D myCollider2D;
    [SerializeField] int health = 100;

    [SerializeField] AudioClip killSound;
    [SerializeField] [Range(0, 1)] float killSoundVolume;

    [SerializeField] AudioClip scratchSound;
    [SerializeField] [Range(0, 1)] float scratchSoundVolume;

    [SerializeField] GameObject explosion;
    [SerializeField] AudioClip explosionSound;

    public static bool shieldBasicUpgrade;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      shieldBasicUpgrade = FindObjectOfType<Upgrades>().ShieldBasicUpgradeOnOff();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
       

    }

    private void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.down * velocity;
        }

    }
    public int GetHealth()
    {
        return health;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mountain")
        {
            Debug.Log("mountain hit");
            AudioSource.PlayClipAtPoint(scratchSound, Camera.main.transform.position, scratchSoundVolume);
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-10);
            }
            else
            {
                FindObjectOfType<Health>().ModifyHealth(-15);
            }
       


        }
        //else if (collision.gameObject.tag == "baloon")
        //{
        //    Debug.Log("baloon hit");

        //    if (shieldBasicUpgrade)
        //    {
        //        FindObjectOfType<Health>().ModifyHealth(-15);
        //    }
        //    else
        //    {
        //        FindObjectOfType<Health>().ModifyHealth(-20);

        //    }
        //}

        else if (collision.gameObject.tag == "poison_cloud")
        {
            Debug.Log("poison cloud hit");
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-1);
            }
            else
            {
                FindObjectOfType<Health>().ModifyHealth(-5);
            }
        }
        else if (collision.gameObject.tag == "industrial")
        {
            AudioSource.PlayClipAtPoint(scratchSound, Camera.main.transform.position, scratchSoundVolume);
            Debug.Log("industrial object hit");
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-10);
            }
            else
            {
                FindObjectOfType<Health>().ModifyHealth(-15);
            }

        }
        else if (collision.gameObject.tag =="aircraft")
        {
            Debug.Log("aircraft hit");
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-25);
            }
            else
            {
                FindObjectOfType<Health>().ModifyHealth(-30);
            }
        }
    }
  

    public void Die()
    {
       // FindObjectOfType<GameSession>().AddToScore(scoreValue);
       
        
        GameObject zeppExplosion = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
         AudioSource.PlayClipAtPoint(explosionSound, Camera.main.transform.position);
        Destroy(zeppExplosion, 2f);
        FindObjectOfType<GameOver>().GameOverMenu();

    }

}
