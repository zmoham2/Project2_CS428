using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSubject : MonoBehaviour
{
    public GameObject ToSize;
    public GameObject Shrink, Enlarge, Normalize, Ceiling;
    
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ScaleDown();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            ScaleNormal();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ScaleBig();
        }
        if (Input.GetKey(KeyCode.JoystickButton9))
        {
            ScaleNormal();
        }
        if (Input.GetKey(KeyCode.JoystickButton17))
        {
            ScaleDown();
        }

    }

    public void ScaleDown()
    {
        
        if (Enlarge.activeSelf == false)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");
            //update the position
            ToSize.transform.localScale -= new Vector3(4.4f, 4.4f, 4.4f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
            Debug.Log("We came from big state");

        }
        else if (Enlarge.activeSelf == true)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");
            //update the position
            ToSize.transform.localScale -= new Vector3(0.7f, 0.7f, 0.7f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
            Debug.Log("We came from normal state");
        }

        Shrink.SetActive(false);
        Normalize.SetActive(true);
        Enlarge.SetActive(true);
        Ceiling.SetActive(true);


    }
    public void ScaleBig()
    {
        

        if (Shrink.activeSelf == false)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");
            //update the position
            ToSize.transform.localScale += new Vector3(4.4f, 4.4f, 4.4f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);

        }
        else if (Shrink.activeSelf == true)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");
            //update the position
            ToSize.transform.localScale += new Vector3(2f, 2f, 2f);
            // Widen the object by x, y, and z values
            ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
        }
        


        Shrink.SetActive(true);
        Normalize.SetActive(true);
        Enlarge.SetActive(false);
        Ceiling.SetActive(false);


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
        Ceiling.SetActive(true);

    }
}
