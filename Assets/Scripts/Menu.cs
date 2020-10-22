using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public Transform s, f;
    float progress, progress2;
    public Scrollbar scrollbar, scrollbar2;
    public Transform ball,ai;
    int coin;
    public Text coinText;
    public Text EarnText;
    
    void Start()
    {
       
        coin = PlayerPrefs.GetInt("coin");
        if (coinText!=null)
        {
            coinText.text = coin.ToString();
        }
      
    }
    public void addCoin(int mik)
    {
        EarnText.text = mik.ToString();
        coin += mik;
        coinText.text = coin.ToString();
        PlayerPrefs.SetInt("coin",coin);
    }

   
    void Update()
    {
        progress =  ball.position.x/(f.position.x - s.position.x) ;
        scrollbar.value = progress;
        progress2 = ai.position.x / (f.position.x - s.position.x);
        scrollbar2.value = progress2;
    }
   
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next()
    {
       
        if (SceneManager.GetActiveScene().buildIndex==6)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
    public void StartGame()
    {
        if (PlayerPrefs.GetInt("level")==0)
        {
            SceneManager.LoadScene( 1);
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("level") + 1);
        }
       
    }
}
