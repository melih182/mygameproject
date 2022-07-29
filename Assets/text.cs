using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text : MonoBehaviour
{
    public GameObject deadscreen;


    public bool isdeath;

    public Text sayac;
    public float sayi;
    public float hiz;
    void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    {
        sayi += hiz * Time.deltaTime;
        //sayac.text = sayi.ToString();
        sayac.text = Mathf.RoundToInt(sayi).ToString();






    }

    public void restartgame()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatharea")
        {
            isdeath = true;
            Time.timeScale = 0;

            deadscreen.SetActive(true);
            hiz = 0;
            sayi = 0;


        }
    }
}
