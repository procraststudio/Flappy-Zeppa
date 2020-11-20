using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PoisonCloud : MonoBehaviour
{
    public float speed;

    private float timer = 0f;
    private float maxTime = 1f;
    [SerializeField] GameObject rainVFX;

    [SerializeField] public int damage = 2;

    [SerializeField] AudioClip scratchSound;
    [SerializeField] [Range (0, 1)] float soundVolume;
    // [SerializeField] GameObject rainVFX;



    void Start()
    {
      
    }

    void Update()
    {
        Move();
        
        timer += Time.deltaTime;
    }
    public void Move()
    {
      
            transform.position += Vector3.left * speed * Time.deltaTime;

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(scratchSound, Camera.main.transform.position, soundVolume);
            FindObjectOfType<Health>().ModifyHealth(-damage);
            Debug.Log("poison cloud hit");

        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((timer>maxTime) && (collision.tag == "Player"))
        {
            Attack();
        }
        
    }

    void Attack()
    {
  
        FindObjectOfType<Health>().ModifyHealth(-damage);
        timer = 0f;
    }

}

