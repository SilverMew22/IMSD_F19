using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeChange : MonoBehaviour
{
    public float x = 0.1f;
    public float y = 0.1f;
    public float z = 0.1f;
    bool large;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyPressed == true) { 
        transform.localScale += new Vector3(x, y, z); }
    }
}
