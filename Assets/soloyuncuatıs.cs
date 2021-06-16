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
    float powersayi = 0.01f;
    bool sonageldimi = false;
    public bool poweroynasinmi = true;
    private static soloyuncuatıs _instance;
    public static soloyuncuatıs Instance{get{return _instance;}}
    void Start()
    {
        _instance =this;
        StartCoroutine(powerbarcalistir());
    }
    IEnumerator powerbarcalistir()
    {
        while (poweroynasinmi)
        {
            if (powerbar.fillAmount < 1 && !sonageldimi)
            {
				yield return new WaitForSeconds(0.001f);
                powerbar.fillAmount += powersayi;

            }
            else
            {
                sonageldimi = true;
				powerbar.fillAmount -= 0.01f;
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
			poweroynasinmi = false;
            Instantiate(topatisefekt, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
            topatmasesi.Play();
            GameObject topobjem = Instantiate(top, topcikisnoktasi.transform.position, topcikisnoktasi.transform.rotation);
            topobjem.tag = "oyuncu1kule";
            Rigidbody2D rg = topobjem.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * 20f * powerbar.fillAmount, ForceMode2D.Impulse);

        }
    }
    public void poweroynasin()
    {
        poweroynasinmi = true;
        StartCoroutine(powerbarcalistir());
    }
}
