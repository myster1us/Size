using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour
{
    GameObject go;
    public GameObject cam;
    bool once = false;
    public Menu menu;
    public GameObject next;
    public void chh()
    {

        StartCoroutine(Kont());
       
    }
    IEnumerator Kont()
    {
        print("obje bu he :" + go);
        if (go != null)
        {
            if (once == false)
            {
                once = true;
                menu.addCoin(go.GetComponent<point>().Coin);

                cam.GetComponent<cameraController>().offset = new Vector3(cam.GetComponent<cameraController>().offset.x - 15, cam.GetComponent<cameraController>().offset.y, cam.GetComponent<cameraController>().offset.z);

                next.SetActive(true);
                GameObject.FindGameObjectWithTag("an").GetComponent<Analytics>().LogLevelCompleteEvent(SceneManager.GetActiveScene().buildIndex+1,true,0);
            }

        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            chh();
        }
        yield return new WaitForSeconds(0f);
    }
   
    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="point")
        {
            go = other.gameObject;
        }
        
       
    }
}
