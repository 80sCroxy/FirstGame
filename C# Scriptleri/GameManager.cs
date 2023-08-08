using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
    public int Puan;
    public Text puanText;
    private void Start()
    {
        Puan = 0;
        puanText.text = Puan.ToString();  
    }
 void Update()
    {
        
    }
 public void puanArti()
  {
    Puan++;
    puanText.text = Puan.ToString();
  }
  public void RestartGame()
  {
    SceneManager.LoadScene("GameScene");
  }
  public void returnMenu()
  {
    SceneManager.LoadScene("AnaMenu");
  }
}
