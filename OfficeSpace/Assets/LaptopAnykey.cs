using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopAnykey : MonoBehaviour
{
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
            laptop_toggle.SetActive(true);
            monitor_toggle.SetActive(true);
            powerUpSong.Play();

        }

        else if (laptop_toggle.activeInHierarchy)
        {
            laptop_toggle.SetActive(false);
            monitor_toggle.SetActive(false);
            powerUpSong.Stop();
        }


    }
}
