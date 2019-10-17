using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laptopToogle : MonoBehaviour
{
    public GameObject laptop_toggle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void laptopOnOff()
    {

        if (!laptop_toggle.activeInHierarchy)
        {
            laptop_toggle.SetActive(true);
        }

        else if (laptop_toggle.activeInHierarchy)
        {
            laptop_toggle.SetActive(false);
        }


    }




}
