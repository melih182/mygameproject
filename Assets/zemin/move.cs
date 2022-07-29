using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private hizlanma a;
    public GameObject b;

    public int destroy;


    public Circle circlescript;
    public float speed;
    
   
    
   
    
    void Start()
    {
        b = GameObject.Find("hizlanma"); 
        a = b.GetComponent<hizlanma>();

       
        //Destroy(gameObject, destroy);


        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yokolma")
        {
            Debug.Log("carpti");

            Destroy(gameObject);


        }
    }





    void Update()
    {


       

        transform.position += Vector3.up * speed * Time.deltaTime * a.i;



       






    }

 


  

    IEnumerator routine()
   {
        while (!circlescript.isdeath)
       {
           yield return new WaitForSeconds(1.0f);
           speed *= 200;

       }
    }

}
