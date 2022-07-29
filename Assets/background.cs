using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    Material material;
    public float xv, yv;
    Vector2 offset;
   
    private void Awake()
    {
       material = GetComponent<Renderer>().material;
    }


    void Update()
    {
        offset = new Vector2(xv,yv);

        

        material.mainTextureOffset += offset * Time.deltaTime;
    }
   
    }
