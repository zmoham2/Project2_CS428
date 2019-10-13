using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalizeSize : MonoBehaviour
{
    
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
            transform.localScale = new Vector3(1, 1, 1);
            // Widen the object by x, y, and z values
            transform.position = transform.position + new Vector3(0, 0, 0);

            counter++;
        }
    }
}
