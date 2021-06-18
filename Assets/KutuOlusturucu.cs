using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KutuOlusturucu : MonoBehaviour
{
    [SerializeField] int maxKutu;

    [SerializeField] List<Transform> kutuPozisyonlar;


    [SerializeField] GameObject KutuCesit1;
    [SerializeField] GameObject KutuCesit2;
    void Start()
    {
         for(int i = 0; i < 4; i++)
        {
            int randomKutuSayisi = Random.Range(3,maxKutu);
            for(int j = 0; j < randomKutuSayisi; j++)
            {
                int kutuTip = Random.Range(0, 100);
                if (kutuTip % 2 == 1){
                    Instantiate(KutuCesit1,kutuPozisyonlar[i].position + new Vector3(0,2*j,0),Quaternion.identity);
                }
                else
                {
                    Instantiate(KutuCesit2, kutuPozisyonlar[i].position + new Vector3(0, 2 * j, 0), Quaternion.identity);

                }
            }
        } 
    }

}
