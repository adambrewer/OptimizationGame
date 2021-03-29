using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{
    public float turnSpeed;
    public Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    void FixedUpdate()
    {
        //transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        //rb.velocity = transform.forward * rb.velocity.magnitude;
        //rb.velocity = transform.up * rb.velocity.magnitude * turnSpeed * Input.GetAxis("Horizontal");
        //rb.velocity = transform.up * turnSpeed * Input.GetAxis("Horizontal");
        rb.angularVelocity = (Input.GetAxis("Horizontal") * turnSpeed);
    }
}
