using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Baloon : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float fallSpeed = 20f;
    [SerializeField] private Vector2 targetVelocity;

    [SerializeField] float padding = 1f;

    float xMin;
    float xMax;
    float yMin;
    float yMax;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        SetupMoveBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Tap();
    }

    public void FixedUpdate()
    {
        //F = mΔv / t
        // stała grawitacja
        Vector2 force = rigid.mass * (targetVelocity - rigid.velocity) / Time.fixedDeltaTime;
        rigid.velocity = force;
    }


    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        //var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, transform.position.y);


    }
    private void Tap()
    {
      var deltaY = Input.GetAxis("Fire1") * Time.deltaTime * fallSpeed;
      var newYPos = Mathf.Clamp(transform.position.y - deltaY, yMin, yMax);
      transform.position = new Vector2(transform.position.x, newYPos);
        

       // if (Input.GetMouseButtonDown(1))
       // {
           //rigid.velocity =Vector2.zero;
           // rigid.AddForce(Vector2.down);


            // }
       // }
    }

    private void SetupMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;

    }


}
