using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hizlanma : MonoBehaviour
{
    public float i;
    public float j;

    void Start()
    {
        
    }

    
    void Update()
    {
        i += j * Time.deltaTime;
        
    }
}
