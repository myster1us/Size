using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    public bool finish = false;
    public GameObject restart;
    bool p2 = false;
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (finish==false)
        {
          
            if (other.tag == "P1")
            {
                if (p2==false)
                {
                    finish = true;
                    other.gameObject.GetComponent<Rigidbody>().AddForce((Vector3.right * 14000));
                    other.gameObject.GetComponent<ball>().finish = true;
                    other.gameObject.GetComponent<ball>().fire = true;
                    GameObject.FindGameObjectWithTag("P2").GetComponent<AIBall>().finish = true;
                }
              
                

            }
            else if (other.tag == "P2")
            {
                p2 = true;
                other.gameObject.GetComponent<Rigidbody>().AddForce((Vector3.right * 14000));
                finish = true;
                GameObject.FindGameObjectWithTag("P1").GetComponent<ball>().finish = true;
                other.gameObject.GetComponent<Rigidbody>().angularDrag = 100f;
                GameObject.FindGameObjectWithTag("P1").GetComponent<Rigidbody>().angularDrag = 1000;
                restart.SetActive(true);
                GameObject.FindGameObjectWithTag("an").GetComponent<Analytics>().LogLevelFailEvent(SceneManager.GetActiveScene().buildIndex + 1, true, 0);

            }
            
           
        }
    }

   

    
    
}
