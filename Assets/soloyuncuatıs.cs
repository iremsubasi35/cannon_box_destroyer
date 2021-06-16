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
    Coroutine powerDongu;
    void Start()
    {
       powerDongu= StartCoroutine(powerbarcalistir());
    }
    IEnumerator powerbarcalistir()
    {
        powerbar.fillAmount = 0;
        sonageldimi = false;
        while (true)
        {
            if (powerbar.fillAmount < 1 && !sonageldimi)
            {
				yield return new WaitForSeconds(0.001f * Time.deltaTime);
                powerbar.fillAmount += powersayi;

            }
            else
            {
                sonageldimi = true;
				powerbar.fillAmount -= 0.01f;
				Debug.Log(powerbar.fillAmount);
                yield return new WaitForSeconds(0.001f * Time.deltaTime);
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
            rg.AddForce(new Vector2(2f, 0f) * powerbar.fillAmount *  12f, ForceMode2D.Impulse);
            StopCoroutine(powerDongu);
        }
    }
    public void poweroynasin()
    {
        
       powerDongu= StartCoroutine(powerbarcalistir());
    }
}
