using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokeden : MonoBehaviour
{
    


    void Start()
    {
        
        
        
        
    }

   
    void Update()
    {


        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yokolma")
        {
            Debug.Log("carpti");

            Destroy(gameObject);


        }
    }


}
