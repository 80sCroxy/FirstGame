using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemmove : MonoBehaviour
{
    public float hiz;
    void Start()
    {
        
    }
    void Update()
    {
          transform.position += Vector3.left * hiz * Time.deltaTime;
    }
  /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            GameManager player = collision.gameObject.GetComponent<GameManager>();
            gameObject.SetActive(false);
        }
        
    }*/
    private void OnCollisionEnter2D(Collision2D collision) 
     { 

         if(collision.gameObject.tag.Equals("Player"))
        {
            GameManager player = collision.gameObject.GetComponent<GameManager>();
            gameObject.SetActive(false);
        }
     }
}
