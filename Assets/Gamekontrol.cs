using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamekontrol : MonoBehaviour
{

    public static Gamekontrol Instance { get { return _instance; } }
    public static Gamekontrol _instance;
    [Header("TOP AYARLARI VE ISLEMLER?")]
    public GameObject topyokolmaefekt;
    public AudioSource yokolmasesi;

    [Header("ORTADAK? KUTULARIN AYARLARI VE ISLEMLERI")]
    public GameObject kutuyokolmaefekt;
    public AudioSource kutuyokolmasesi;
    [Header("OYUNCU SAGLIK AYARLARI")]
    public Image oyuncusaglik1bar;
    float oyuncusaglik1=100;
    public Image oyuncusaglik2bar;
    float oyuncusaglik2=100;
    [SerializeField] GameObject OyunSonuCanvas;
    [SerializeField] GameObject Kazanma;
    [SerializeField] GameObject Kaybetme;

    [HideInInspector] public bool oyunDevamEdiyor;

    private void Awake()
    {
        _instance = this;
        oyunDevamEdiyor = true;

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
                    oyunDevamEdiyor = false;
                    OyunSonuCanvas.SetActive(true);
                    Kaybetme.SetActive(true);
                }
                break;
            case 2:
                oyuncusaglik2 -= darbegucu/20;
                oyuncusaglik2bar.fillAmount = oyuncusaglik2 / 100;
                if (oyuncusaglik2 <= 0)
                {
                    oyunDevamEdiyor = false;
                    OyunSonuCanvas.SetActive(true);
                    Kazanma.SetActive(true);

                }
                break;




        }
    }
}
