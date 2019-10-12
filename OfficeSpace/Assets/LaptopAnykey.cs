/*
 *  Touch toggle Laptop and under cabinet light 
 *
 *      When the laptop is touched laptop, monitor
 *  screen with display code and arduino schemetic.
 *  Sound will be triggered to play a 3 second audio
 *  tone. Under cabinet lights will turn on.
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
 *
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopAnykey : MonoBehaviour
{

    public GameObject awake;
    public GameObject laptop_toggle;
    public GameObject monitor_toggle;
    public AudioSource powerUpSong;

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
            // turn on laptop, monitor, desk light
            // and play start up music.
            laptop_toggle.SetActive(true);
            monitor_toggle.SetActive(true);
            awake.SetActive(true);
            powerUpSong.Play();
        }

        else if (laptop_toggle.activeInHierarchy)
        {
            // turn off everything
            laptop_toggle.SetActive(false);
            monitor_toggle.SetActive(false);
            awake.SetActive(false);
            // shouldnt need this part but let it
            // in just in case.
            powerUpSong.Stop();
        }
    }// End laptopOnOff()
}// End Class
