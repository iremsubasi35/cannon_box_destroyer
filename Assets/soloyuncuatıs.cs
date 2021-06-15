using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soloyuncuatıs : MonoBehaviour
{
    public GameObject top;
    public GameObject topcikisnoktasi;
    public ParticleSystem topatisefekt;
    public AudioSource topatmasesi;
    public Image powerbar;
    float powersayi;
    bool sonageldimi = false;
    public bool poweroynasinmi = true;
    void Start()
    {
        StartCoroutine(powerbarcalistir());
    }
    IEnumerator powerbarcalistir()
    {
        while (true && poweroynasinmi)
        {
            if (powerbar.fillAmount < 1 && !sonageldimi)
            {
                powersayi = 0.01f;
                powerbar.fillAmount += powersayi;
                yield return new WaitForSeconds(0.001f);

            }
            else
            {
                sonageldimi = true;
                powersayi = 0.01f;
                powerbar.fillAmount -= powersayi;
                yield return new WaitForSeconds(0.001f);
                if (powerbar.fillAmount == 0)
                {
                    sonageldimi = false;
                }
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            poweroynasin();
            Instantiate(topatisefekt, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
            topatmasesi.Play();
            GameObject topobjem = Instantiate(top, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
            Rigidbody2D rg = topobjem.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * 10f, ForceMode2D.Impulse);
            poweroynasinmi = false;

        }



    }
    public void poweroynasin()
    {
        poweroynasinmi = true;
        StartCoroutine(powerbarcalistir());
    }
}
