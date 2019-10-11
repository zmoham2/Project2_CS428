using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvactive : MonoBehaviour
{

    public GameObject batmantas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void tvOnOff()
    {

        if (!batmantas.activeInHierarchy)
        {
            batmantas.SetActive(true);
        }



        else if (batmantas.activeInHierarchy)
        {
            batmantas.SetActive(false);
        }


    }
}
