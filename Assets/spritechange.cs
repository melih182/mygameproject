using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite sol, orta, sag;
    void Start()
    {
        spriterenderer = this.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
       
    }
}
