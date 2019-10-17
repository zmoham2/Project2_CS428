using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enbiggen : MonoBehaviour
{
    public float x = 0.1f;
    public float y = 0.1f;
    public float z = 0.1f;
    //public float px = 0.1f;
    //public float py = 0.1f;
    //public float pz = 0.1f;
    float counter = 0;

    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        if (counter == 0)
        {
            //update the position
            transform.localScale += new Vector3(x, y, z);
            // Widen the object by x, y, and z values
            transform.position += transform.position + new Vector3(4f*horizontalInput, 4f*verticalInput, 0);

            counter++;
        }
    }
}
