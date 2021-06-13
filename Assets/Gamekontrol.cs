using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamekontrol : MonoBehaviour
{

    [Header("TOP AYARLARI VE ÝSLEMLERÝ")]
    public GameObject topyokolmaefekt;
    public AudioSource yokolmasesi;

    [Header("ORTADAKÝ KUTULARIN AYARLARI VE ÝSLEMLERÝ")]
    public GameObject kutuyokolmaefekt;
    public AudioSource kutuyokolmasesi;
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
}
