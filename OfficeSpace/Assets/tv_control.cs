using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv_control : MonoBehaviour
{

   public GameObject tv_toggle;

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

        if(!tv_toggle.activeInHierarchy)
        {
            tv_toggle.SetActive(true);
        }



        else if(tv_toggle.activeInHierarchy)
        {
            tv_toggle.SetActive(false);
        }


    }
}
