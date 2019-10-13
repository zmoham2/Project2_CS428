using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSubject : MonoBehaviour
{
    public GameObject ToSize;
    public GameObject Shrink, Enlarge, Normalize;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaleDown()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

            //update the position
            ToSize.transform.localScale -= new Vector3(0.7f, .7f, 0.7f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
        Shrink.SetActive(false);
        Normalize.SetActive(true);
        Enlarge.SetActive(true);


    }
    public void ScaleBig()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        ToSize.transform.localScale += new Vector3(4f, 4f, 4f);
        // Widen the object by x, y, and z values
        ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
        Shrink.SetActive(true);
        Normalize.SetActive(true);
        Enlarge.SetActive(false);


    }
    public void ScaleNormal()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        ToSize.transform.localScale = new Vector3(1f, 1f, 1f);
        // Widen the object by x, y, and z values
        ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
        Shrink.SetActive(true);
        Normalize.SetActive(false);
        Enlarge.SetActive(true);

    }
}
