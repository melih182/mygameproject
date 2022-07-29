using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   
    public Circle circlescript;
    

    public SpriteRenderer spriteRenderer;
    public float aralik;
    public float baslangic;


    public Sprite newSprite;


    

    public GameObject kutu;

    public float heigh, hsag;

   


    void Start()
    {
        StartCoroutine(Spawnobject());
        kutu.GetComponent<SpriteRenderer>().sprite = newSprite;

        

    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
       
        
    }
 

    void Update()
    {

       
       

    }

    private void FixedUpdate()
    {


        

    }



    public IEnumerator Spawnobject()
    {
        while (!circlescript.isdeath)
        {

            Instantiate(kutu, new Vector3(Random.Range(-heigh, hsag),baslangic, 0), Quaternion.identity);
            yield return new WaitForSeconds(aralik);
            
            
        }
       
    }




   





}
