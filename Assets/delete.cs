using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject Ball;

   
    void Update()
    {
        transform.position = new Vector3(Ball.transform.position.x - 13, Ball.transform.position.y, Ball.transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);

        if (other.tag=="cube")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;

        }
        if (other.tag == "Small")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (other.tag == "Big")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (other.tag == "bb")
        {
            Destroy(other.gameObject,1f);
        }



    }
}
