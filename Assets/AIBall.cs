using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBall : MonoBehaviour
{
    Rigidbody rb;
    bool canspeed = false;
    public bool small = false, big = false;
    public bool  finish=false;
    public GameObject canv;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        canv.transform.position = new Vector3(transform.position.x,transform.position.y+3,transform.position.z);
        if (finish == false)
        { 
            if (rb.velocity.x > 35)
        {
            rb.AddForce((Vector3.left * 5) / (transform.localScale.x * 3));
        }
        else
        {
            rb.AddForce((Vector3.right * 80) / (transform.localScale.x * 3));
        }
        if (transform.localScale.x < 7)
        {
            if (rb.velocity.x < 0f)
            {
                canspeed = true;
            }
            if (canspeed)
            {
                rb.AddForce((Vector3.right * 400) / (transform.localScale.x * 2));
                if (rb.velocity.x > 10)
                {
                    canspeed = false;
                }
            }

        }

        if (big==true&small==false)
        {
            if (transform.localScale.x < 12f)
            {
                transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }

        }
        if (small == true & big == false)
        {
            if (transform.localScale.x > 3f)
            {
                transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

            }

        }
        }
    }
   
}
