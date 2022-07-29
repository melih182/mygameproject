using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    float horizontal;
    Rigidbody2D rg2;
    public float hizi = 1f;
    public bool isdeath;
    public GameObject deadscreen;
    
    

    public SpriteRenderer spriterenderer;
    public Sprite sagyon;
    public Sprite solyon;
    public Sprite orta;

    

    

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");

        //transform.rotation = Quaternion.Euler(0,0,0);

        //rg2.AddForce(new Vector3(horizontal * hizi * Time.deltaTime, 0, 0));
        transform.Translate(horizontal * hizi * Time.deltaTime, 0, 0);
        
    }


    void Start()
    {
        

        spriterenderer = this.GetComponent<SpriteRenderer>();

        Time.timeScale = 1;
        rg2 = GetComponent<Rigidbody2D>();

    }
    
    void Update()
    {
        /*if (Input.GetAxis("Horizontal") > 0 )
        {
            spriterenderer.sprite = sagyon;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            spriterenderer.sprite = solyon;
        }
        else
        {
            spriterenderer.sprite = orta;
        }*/

        if (Input.acceleration.x > 0.035)
        {
            spriterenderer.sprite = sagyon;
        }
        else if (Input.acceleration.x < -0.035)
        {
            spriterenderer.sprite = solyon;
        }
        else
        {
            spriterenderer.sprite = orta;
        }

        /*if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            spriterenderer.sprite = sagyon;
        }
        else if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            spriterenderer.sprite = solyon;
        }
        else
        {
            spriterenderer.sprite = orta;
        }*/




    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatharea")
        {
            isdeath = true;
            //Time.timeScale = 0;

            deadscreen.SetActive(true);
            
            

        }
    }
}
