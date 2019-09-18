using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        CapsuleZoomDownScreen();
    }

    // Update is called once per frame
    void CapsuleZoomDownScreen()
    {
        transform.position = new Vector3(2 * Mathf.Tan(Time.time), 0, 2 * Mathf.Tan(Time.time));
        
    }
}