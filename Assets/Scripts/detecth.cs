using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecth : MonoBehaviour
{
    public GameObject Ball;
   
    void Update()
    {
        transform.position = new Vector3(Ball.transform.position.x+10, Ball.transform.position.y, Ball.transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Big")
        {
            Ball.GetComponent<AIBall>().big = true;
            Ball.GetComponent<AIBall>().small = false;
            print("big");
        }
        if (other.tag == "Small")
        {
            Ball.GetComponent<AIBall>().big = false;
            Ball.GetComponent<AIBall>().small = true;
            print("small");
        }
    }
}
