using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public float speedVal=1;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="P1" || other.tag=="P2")
        {
            print("speeeed");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 1000* speedVal);
        }
    }
}
