using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    float darbegucu;
    
    GameObject Gamekontrol;
    GameObject Oyuncu;

    
    void Start()
    {
        darbegucu = 20;
        Gamekontrol = GameObject.FindWithTag("Gamekontrol");
        Oyuncu = GameObject.FindWithTag("oyuncu1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ortadakikutular"))
        {
            collision.gameObject.GetComponent<ortadakikutular>().darbeal(darbegucu);
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            Oyuncu.GetComponent<soloyuncuatýs>().poweroynasin();
            Destroy(gameObject);
           // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("oyuncu2kule") || collision.gameObject.CompareTag("oyuncu2"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            Gamekontrol.GetComponent<Gamekontrol>().darbevur(2, darbegucu);
            Oyuncu.GetComponent<soloyuncuatýs>().poweroynasin();
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("oyuncu1kule") || collision.gameObject.CompareTag("oyuncu1"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            Gamekontrol.GetComponent<Gamekontrol>().darbevur(1, darbegucu);
            Oyuncu.GetComponent<soloyuncuatýs>().poweroynasin();
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("zemin"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);

            Oyuncu.GetComponent<soloyuncuatýs>().poweroynasin();
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }

    }
    void Update()
    {

    }

}





