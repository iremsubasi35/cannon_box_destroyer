using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ortadakikutular : MonoBehaviour
{
    float saglik=100;
    public GameObject SaglikCanvasi;
    public Image HealthBar;
    GameObject Gamekontrol;
    [SerializeField] bool beyazmi;
    private void Start()
    {
        Gamekontrol = GameObject.FindWithTag("Gamekontrol");
    }


    public void darbeal(float darbegucu)
    {
        saglik -= darbegucu;
        if (beyazmi)
        {
            HealthBar.fillAmount = saglik / 200;
        }
        else
        {
            HealthBar.fillAmount = saglik / 100;

        }
        if (saglik <= 0)
        {
            Gamekontrol.GetComponent<Gamekontrol>().ses_ve_efekt_olustur2(gameObject);
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(CanvasCikar());
        }
    }
       IEnumerator CanvasCikar()
    {
        if (!SaglikCanvasi.activeInHierarchy)
        {
            SaglikCanvasi.SetActive(true);
            yield return new WaitForSeconds(2);
            SaglikCanvasi.SetActive(false);


        }

    }

    

}
