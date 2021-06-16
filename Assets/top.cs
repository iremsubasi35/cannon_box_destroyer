using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    float darbegucu;
    
    GameObject Gamekontrol;
    
    void Start()
    {
        darbegucu = 20;
        Gamekontrol = GameObject.FindWithTag("Gamekontrol");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ortadakikutular"))
        {
            collision.gameObject.GetComponent<ortadakikutular>().darbeal(darbegucu);
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
                        soloyuncuatıs.Instance.poweroynasin();

            Destroy(gameObject);
           // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("oyuncu2kule") && transform.gameObject.CompareTag("oyuncu1kule"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            Gamekontrol.GetComponent<Gamekontrol>().darbevur(2, darbegucu);
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("oyuncu1kule") && transform.gameObject.CompareTag("oyuncu2kule"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            Gamekontrol.GetComponent<Gamekontrol>().darbevur(1, darbegucu);
            soloyuncuatıs.Instance.poweroynasin();
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("zemin"))
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur(collision.gameObject);
            soloyuncuatıs.Instance.poweroynasin();
            Destroy(gameObject);
            // GetComponent<CircleCollider2D>().isTrigger = false;
        }

    }
    void Update()
    {

    }

}





