using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSubject : MonoBehaviour
{
    public GameObject ToSize;
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
            ToSize.transform.localScale -= new Vector3(.4f, .4f, .4f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);

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

    }
}
