using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningEffect : MonoBehaviour
{
    public GameObject myobject;
   


    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(lightitup());
    }

    IEnumerator lightitup()
    {
        myobject.SetActive(false);

        //Wait for 54 seconds
        yield return new WaitForSeconds(54);
        myobject.SetActive(true);
        yield return new WaitForSeconds(1);
        myobject.SetActive(false);
        yield return new WaitForSeconds(1 / 2);
        myobject.SetActive(true);
        yield return new WaitForSeconds(1 / 2);
        myobject.SetActive(false);
        yield return new WaitForSeconds(1 / 2);
        myobject.SetActive(true);
        yield return new WaitForSeconds(1 / 2);
        myobject.SetActive(false);
        

    }
}
