/*
 *  Touch Toggle for TV
 *
 *      When you touch the TV it will toggle the display
 *  from on and to off.
 *
 *  Update:
 *      This this the newest way to use touch. Have been
 *  making intactable using the collider notifier and freezing
 *  the model. this new way is much simplier.
 *
 *
 * 
 *  Code Source:
 *
 *  stackoverflow
 *  https://answers.unity.com/questions/1286555/checking-a-gameobject-active-in-hierarchy-not-work.html
 *
 *  unity docs
 *  https://docs.unity3d.com/ScriptReference/GameObject-activeInHierarchy.html
 *
 */


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
