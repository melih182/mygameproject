using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle1 : MonoBehaviour
{
    float horizontal;
    Rigidbody2D rg2;
    public float hizi;
    public bool isdeath;
    public GameObject deadscreen;
    private Transform target;



   


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Time.timeScale = 1;
        rg2 = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        //rg2.AddForce(new Vector3(horizontal * hizi * Time.deltaTime, 0, 0));

        //transform.Translate(horizontal * hizi * Time.deltaTime, 0, 0);

        transform.position = Vector2.MoveTowards(transform.position, target.position, hizi * Time.deltaTime);



    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "sol duvar")
        {
            hizi = 0;
        }
       
        
            if (col.gameObject.name == "sag duvar")
            {
                hizi = 0;
            }
        
    }
        /*private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "deatharea")
            {
                isdeath = true;
                Time.timeScale = 0;

                deadscreen.SetActive(true);

            }
        }*/
    }
