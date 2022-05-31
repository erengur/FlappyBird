using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borular : MonoBehaviour
{
    public float velocity;

    void Start()
    {
        Destroy(gameObject, 7);
    }

    
    void FixedUpdate()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
