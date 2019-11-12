using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement1 : MonoBehaviour
{Vector3 startPosition;
    
    void Start()
    {
        
    startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
transform.position = new Vector3(15 * Mathf.Cos(Time.time), 15 * Mathf.Cos(Time.time), 0);


    }
}


