using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour

{
  public float destroyTime;
    public void Start()
    {
      Destroy (gameObject, destroyTime) ;
    }
    public float hiz;
    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }
}
