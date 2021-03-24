using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRotationControlReverse : MonoBehaviour
{
    public float turnSpeed;
    public Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.angularVelocity = ((-1 * Input.GetAxis("Horizontal")) * turnSpeed);
    }
}
