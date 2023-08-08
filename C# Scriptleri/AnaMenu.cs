using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
     AudioSource[] Ses;
     private void Start()
     {
        Ses = GetComponents<AudioSource>();
     }
     public void PlaySound(){
        Ses[0].Play();
        Debug.Log("A");
     }
    public void PlayGame(){
         
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
 Debug.Log("A");

    }
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();//eğer oyun inşa edilirse çalışacaktır.
    }
}