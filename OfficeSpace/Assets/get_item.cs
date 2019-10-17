using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_item : MonoBehaviour
{
    public GameObject key;
    public AudioSource getRubyFX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getItem()
    {
        if (!key.activeInHierarchy)
        {
            getRubyFX.Play();
        }


        if (key.activeInHierarchy)
        {

        }
    }


}
