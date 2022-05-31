using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bird : MonoBehaviour
{
    public bool isdead;
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public gamemanager managergame;

    public GameObject Deathscreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "scorer") ;
        managergame.UpdateScore();
    }
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up*velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "altboru" || collision.gameObject.name == "ustboru" ) {
            isdead = true;
            Time.timeScale = 0;

            Deathscreen.SetActive(true);
        }
    }

}
