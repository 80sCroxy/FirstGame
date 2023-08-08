using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketi : MonoBehaviour
{
    public bool isDead;
    public GameManager managerGame;
    public GameObject DeathScreen;
    private Rigidbody2D rgb;
   
   AudioSource[] Sesler;

    Vector3 velocity ;

   public float ziplamaKontrol =8f;
     Animator animator;

private bool kay;
    private void Start()
    {
        Time.timeScale= 1;
        rgb = GetComponent<Rigidbody2D>();
        animator =GetComponent<Animator>();
        Sesler = GetComponents<AudioSource>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //&& Mathf.Approximately(rgb.velocity.y.0))
        {
            Debug.Log("zıplandı");
            Sesler[0].Play();
          animator.SetTrigger("ZiplamaAnimasyonu");
         rgb.AddForce(Vector3.up * ziplamaKontrol, ForceMode2D.Impulse);
        
        }
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
              Debug.Log("Kaydı");
           animator.SetTrigger("KaymaAnimasyonu");
        } 
    }
    private void OnTriggerEnter2D(Collider2D collision)        
     {
        if(collision.gameObject.name == "ScoreArea(Clone)")
        {
            managerGame.puanArti();
            Sesler[3].Play();
        }      
     }
      private void OnCollisionEnter2D(Collision2D collision) 
     { 

         if(collision.gameObject.tag=="OlumAlanı")
         {
            isDead = true;
            Sesler[2].Play();
            Sesler[1].Play();
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
         }

     } 
}
