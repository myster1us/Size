using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public GameObject restart;
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "P1")
        {
            Destroy(other.gameObject);
            restart.SetActive(true);

        }
        if (other.tag == "P2")
        {
            Destroy(other.gameObject);      
        }
     



    }
}
