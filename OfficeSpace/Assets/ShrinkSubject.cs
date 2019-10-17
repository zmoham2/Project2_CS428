using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSubject : MonoBehaviour
{
    public GameObject ToSize;
    public GameObject Shrink, Normalize, PositionTest;

    public GameObject mModels;

    // Start is called before the first frame update
    void Start()
    {
        //float initialHorizontal = Input.GetAxis("Horizontal");
        //float initialVertical = Input.GetAxis("Vertical");

      //  mModels = GameObject.Find("scaled");
        //mModels.SetActive(false);
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
    }

    public void ScaleDown()
    {

        
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");

            ToSize.transform.position = PositionTest.transform.position;
            //update the position
            ToSize.transform.localScale -= new Vector3(0.7f, 0.7f, 0.7f);
            

        Shrink.SetActive(false);
        Normalize.SetActive(true);
        mModels.SetActive(true);


    }
    /*public void ScaleBig()
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


    }*/

    public void ScaleNormal()
    {

        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        //Debug.Log("Old: " + horizontalInput);
        //Debug.Log("Old: " + verticalInput);

        //update the position

        //ToSize.transform.position = ToSize.transform.position - new Vector3(horizontalInput, verticalInput, 0);
        
        ToSize.transform.localScale = new Vector3(1f, 1f, 1f);
        ///ToSize.transform.position = new Vector3(horizontalInput, verticalInput, 0);

        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("New: " + horizontalInput);
        //Debug.Log("New: " + verticalInput);

        //ToSize.transform.position = PositionTest.transform.position;
        // Widen the object by x, y, and z values
        //ToSize.transform.position = ToSize.transform.position + new Vector3(horizontalInput, verticalInput, 0);
        Shrink.SetActive(true);
        Normalize.SetActive(false);
        mModels.SetActive(false);

    }
}
