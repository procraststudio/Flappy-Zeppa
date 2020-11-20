using UnityEngine;

public class Zeppelin : MonoBehaviour
{ 
    // Script that moves left all enemies, obstacles, awards

    private float timer = 0;
    public float speed;

    public bool randomness = false;
    public float randomFactor;
    public bool moveUpDown = false;

    [SerializeField] AudioClip BaloonExplosion;
    [SerializeField] [Range(0, 1)] float fireSoundVolume;

    [SerializeField] public float speedUpDown;

    public bool shieldBasicUpgrade;

    private void Start()
    {
        shieldBasicUpgrade = FindObjectOfType<Upgrades>().ShieldBasicUpgradeOnOff();
 
    }


    void Update()
    {
        Move();
        timer += Time.deltaTime;
      
    }
    public void Move()
{
     randomFactor = Random.Range(0.6f, 1.4f);
    if (randomness)
    {
        transform.position += Vector3.left * speed * randomFactor * Time.deltaTime;
    }
    else if (moveUpDown)
        {
            transform.position += Vector3.down * speedUpDown * Time.deltaTime;
        }
    else if ((moveUpDown)&&(timer>3))
            {
            transform.position += Vector3.up * speedUpDown * Time.deltaTime;
            timer = 0;

        }
    else
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
}



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (shieldBasicUpgrade)
            {
                FindObjectOfType<Health>().ModifyHealth(-15);
                AudioSource.PlayClipAtPoint(BaloonExplosion, Camera.main.transform.position, fireSoundVolume);
                Destroy(this.gameObject);
            }

            else
            {
                FindObjectOfType<Health>().ModifyHealth(-20);
                AudioSource.PlayClipAtPoint(BaloonExplosion, Camera.main.transform.position, fireSoundVolume);
                Destroy(this.gameObject);
            }

        }

    }



}
