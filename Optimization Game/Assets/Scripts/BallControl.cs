using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Animator anim;
    public float airTime;
    public bool isColliding;

    // Start is called before the first frame update
    void Start()
    {
        isColliding = true;
    }

    // Update is called once per frame
    void Update()
    {
        if((isColliding == false) && (airTime > 0))
        {
            airTime -= (Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isColliding = true;
        Debug.Log("hello");
        if (airTime < 1)
        {
            anim.SetInteger("Hit", 1);
            anim.SetInteger("Hit", 0);
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        airTime = 1;
        isColliding = false;
        Debug.Log("goodbye");
    }

}
