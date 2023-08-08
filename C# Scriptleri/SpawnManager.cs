using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /*public float maxTime = 1;
    public float timer = 0;
    */
    public float konum;
    public float konumGem;
    public float yukseklik;
    public GameObject engel;
    public GameObject engel2;
    public GameObject engel3;
    public GameObject ScoreArea;
    public GameObject ScoreArea1;
    public KarakterHareketi playerScript;
    public float time;
    void Start()
    {
     StartCoroutine(SpawnObject(time));
    }

    void Update()
   {
     
   }
   public IEnumerator SpawnObject(float time)
   {
    while (!playerScript.isDead)
    {
        Instantiate(engel, new Vector3(Random.Range(-konum, konum), -1 , 0), Quaternion.identity);
         Instantiate(engel2, new Vector3(5, Random.Range(0,3), 0), Quaternion.identity);
          Instantiate(engel3, new Vector3(Random.Range(10,15), Random.Range(0,3), 0), Quaternion.identity);
          Instantiate(ScoreArea, new Vector3(0 , -1 , 0), Quaternion.identity);
          Instantiate(ScoreArea1, new Vector3(15 , -1 , 0), Quaternion.identity);

        yield return new  WaitForSeconds(time);
    }
   }

}
