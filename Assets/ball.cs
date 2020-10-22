using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    bool canspeed = false;
    public bool finish=false;
    public bool fire = false;

    public cameraShake cameraShake;
    public GameObject f1, f2;
    bool once = false;
    public GameObject ch;
    bool up = false;

    bool on = false;

    Vector2 mouseStartPos;
    Vector2 mouseEndPos;

   
   

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);
        rb = GetComponent<Rigidbody>();
        GameObject.FindGameObjectWithTag("an").GetComponent<Analytics>().LogLevelStartEvent(SceneManager.GetActiveScene().buildIndex + 1, true, 0);


    }
    IEnumerator CHECK()
    {
        yield return new WaitForSeconds(0.5f);
        if (rb.velocity.x < 1f)
        {
            print("OLUMLUUUUUUUUUUUUUU");
            rb.angularDrag = 1000;

            ch.SetActive(true);
            ch.GetComponent<check>().chh();
            
        }
        else
        {
            on = false;
            print("OLUMSUZZZZ");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        //print(rb.velocity.x);
        if (finish == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                up = false;
                mouseStartPos = Input.mousePosition.normalized;
                print(mouseStartPos);
            }
            if (Input.GetMouseButton(0))
            {
                mouseEndPos = Input.mousePosition.normalized;
                if (mouseEndPos.y - mouseStartPos.y>0)
                {
                    addUp();
                }
                else
                {
                    addSmall();
                }
               
            }
            if (Input.GetMouseButtonUp(0))
            {
                up = true;
               
            }





            if (rb.velocity.x>35)
        {
            rb.AddForce((Vector3.left * 5) / (transform.localScale.x * 3));
        }
        else
        {
            rb.AddForce((Vector3.right * 80) / (transform.localScale.x * 3));
        }
        if (transform.localScale.x<7)
        {
            if (rb.velocity.x < 0f)
            {
                canspeed = true;
            }
            if (canspeed)
            {
                rb.AddForce((Vector3.right * 400) / (transform.localScale.x * 2));
                if (rb.velocity.x >10)
                {
                    canspeed = false;
                }
            }
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.localScale.x < 12f)
            {
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            }
           
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.localScale.x>3f)
            {
                transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
               
            }
            
        }
        }
        else
        {
            if (rb.velocity.x<1f)
            {
                if (on==false)
                {
                    on = true;
                    StartCoroutine(CHECK());
                }
               
                
            }
            if (fire)
            {
                if (once == false)
                {
                    once = true;
                    f1.SetActive(true);
                    f2.SetActive(true);
                }
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "broke")
        {
            
            StartCoroutine(cameraShake.Shake(.3f, .3f));
            Vibration.Vibrate(50);
            
        }
        
      
    }
    

    void addUp()
    {
        if (transform.localScale.x < 12f)
        {
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
        }
    }
    void addSmall()
    {
        if (transform.localScale.x > 3f)
        {
            transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);

        }
    }

}
