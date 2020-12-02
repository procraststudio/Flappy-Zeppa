using UnityEngine;

public class Zeppelin : MonoBehaviour
{ 
    // Script that moves left all enemies, obstacles, awards

   
    public float speed;

    
    [SerializeField] AudioClip BaloonExplosion;
    [SerializeField] GameObject explosion;
    [SerializeField] [Range(0, 1)] float fireSoundVolume;

   

    public bool shieldBasicUpgrade;

    private void Start()
    {
        shieldBasicUpgrade = FindObjectOfType<Upgrades>().ShieldBasicUpgradeOnOff();
 
    }


    void Update()
    {
        Move();
     
      
    }
    public void Move()
{
   
        transform.position += Vector3.left * speed * Time.deltaTime;

    
}



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-15);
                GameObject baloonExplosion = Instantiate(explosion, transform.position, transform.rotation);
                AudioSource.PlayClipAtPoint(BaloonExplosion, Camera.main.transform.position, fireSoundVolume);
                Destroy(baloonExplosion, 2f);
                Destroy(this.gameObject);
            }

            else
            {
                FindObjectOfType<Health>().ModifyHealth(-20);
                GameObject baloonExplosion = Instantiate(explosion, transform.position, transform.rotation);
                AudioSource.PlayClipAtPoint(BaloonExplosion, Camera.main.transform.position, fireSoundVolume);
                Destroy(baloonExplosion, 2f);
                Destroy(this.gameObject);
            }

        }

    }



}
