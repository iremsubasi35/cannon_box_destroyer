using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamekontrol : MonoBehaviour
{

    [Header("TOP AYARLARI VE ÝSLEMLERÝ")]
    public GameObject topyokolmaefekt;
    public AudioSource yokolmasesi;

    [Header("ORTADAKÝ KUTULARIN AYARLARI VE ÝSLEMLERÝ")]
    public GameObject kutuyokolmaefekt;
    public AudioSource kutuyokolmasesi;
    [Header("OYUNCU SAGLÝK AYARLARI")]
    public Image oyuncusaglik1bar;
    float oyuncusaglik1=100;
    public Image oyuncusaglik2bar;
    float oyuncusaglik2=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ses_ve_efekt_olustur(GameObject objetransformu)
    {
        
        Instantiate(topyokolmaefekt,objetransformu.gameObject.transform.position,objetransformu.gameObject.transform.rotation);
        yokolmasesi.Play();
    }

    public void ses_ve_efekt_olustur2(GameObject objetransformu)
    {

        Instantiate(kutuyokolmaefekt, objetransformu.gameObject.transform.position, objetransformu.gameObject.transform.rotation);
        kutuyokolmasesi.Play();
    }
    public void darbevur(int kriter,float darbegucu)
    {
        switch (kriter)
        {
            case 1:
                oyuncusaglik1 -= darbegucu / 20;
                oyuncusaglik1bar.fillAmount = oyuncusaglik1 / 100;
                if (oyuncusaglik1 <= 0)
                {
                    Debug.Log("oyuncu 1 yenildi");
                }
                break;
            case 2:
                oyuncusaglik2 -= darbegucu/20;
                oyuncusaglik2bar.fillAmount = oyuncusaglik2 / 100;
                if (oyuncusaglik2 <= 0)
                {
                    Debug.Log("oyuncu 2 yenildi");
                }
                break;




        }
    }
}
