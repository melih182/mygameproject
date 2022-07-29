using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiroskop : MonoBehaviour
{
    public bool isdeath;
    public GameObject deadscreen;
    public float speed = 1f;
    Rigidbody2D rg2;

    float dirx;
    float movespeed =20f;


    public SpriteRenderer spriterenderer;
    public Sprite sagyon;
    public Sprite solyon;
    public Sprite orta;

    float c;
    public GameObject patlama;



    void Start()
    {
        Time.timeScale = 1;


        spriterenderer = this.GetComponent<SpriteRenderer>();
        rg2 = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //Input.gyro.enabled = true;
        //c = Input.gyro.rotationRateUnbiased.y * speed;
        //this.transform.Translate(Input.gyro.rotationRateUnbiased.y * speed * Time.deltaTime,0, 0);




        dirx = Input.acceleration.x * movespeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.3f, 2.3f), transform.position.y);

        


    }


    private void FixedUpdate()
    {
        




        rg2.velocity = new Vector2(dirx, 0f);
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatharea")
        {
            Instantiate(patlama, transform.position, Quaternion.identity);
            isdeath = true;
            //Time.timeScale = 0;

         

            deadscreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
