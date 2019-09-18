using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {       
                CubeSwingBackAndFourth();        
    }

    void CubeSwingBackAndFourth()
    {
        
        transform.position = new Vector3(2 * Mathf.Cos(Time.time), 2 * Mathf.Cos(Time.time), 2 * Mathf.Cos(Time.time));
    }
   
}