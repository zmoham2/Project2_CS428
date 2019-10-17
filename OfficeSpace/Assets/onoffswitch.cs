using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffswitch : MonoBehaviour
{
    public GameObject myobject, object2;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (myobject.activeSelf == true && object2.activeSelf == true)
            {
                myobject.SetActive(false);
                object2.SetActive(false);
            }
            else
            {
                myobject.SetActive(true);
                object2.SetActive(true);
            }
        

    }

    
    
}
