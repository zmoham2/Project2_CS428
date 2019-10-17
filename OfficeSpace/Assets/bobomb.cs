using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobomb : MonoBehaviour
{
    public float timer = 10f;
    float countdown;
    static bool hasExploded = false;

    public GameObject explosionEffect;
    public GameObject soundEffect;
    public GameObject fuseEffect;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
        fuseEffect.SetActive(true);
        soundEffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            fuseEffect.SetActive(false);
            soundEffect.SetActive(true);
            hasExploded = true;
            //Debug.Log("TEST ");
        }
        
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
    }
}
