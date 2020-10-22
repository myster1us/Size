using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyer : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag=="P1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        Destroy(other.gameObject);



    }
}
