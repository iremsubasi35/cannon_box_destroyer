using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SagOyuncuAtis : MonoBehaviour
{
    public GameObject top;
    public GameObject topcikisnoktasi;
    public ParticleSystem topatisefekt;
    public AudioSource topatmasesi;
    float powersayi = 0.01f;
    bool sonageldimi = false;

    float powerBarOran=0f;
    [SerializeField] float beklemeSuresi;
    bool atis =false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!atis && Gamekontrol.Instance.oyunDevamEdiyor)
        {
            atis = true ;
            StartCoroutine(AtesEt());
        }
    }

    IEnumerator AtesEt()
    {
        yield return new WaitForSeconds(beklemeSuresi);
        Instantiate(topatisefekt, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
        topatmasesi.Play();
        GameObject topobjem = Instantiate(top, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
        topobjem.tag = "oyuncu2kule";
        Rigidbody2D rg = topobjem.GetComponent<Rigidbody2D>();
        
        powerBarOran = Random.Range(0.4f,1f);
        rg.AddForce(new Vector2(-2f, 0f) * 15f * powerBarOran, ForceMode2D.Impulse);
        atis =false;

    }
}
