using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borugenerator : MonoBehaviour
{
    public float time;
    public bird Birdscript;

    public GameObject borular;

    public float heigth;
     void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
         while (!Birdscript.isdead)
        {            
            Instantiate(borular, new Vector3(3, Random.Range(-heigth, heigth), 0), Quaternion.identity);
            
            yield return new WaitForSeconds(time);            
        }
    }
   

    
    
}
