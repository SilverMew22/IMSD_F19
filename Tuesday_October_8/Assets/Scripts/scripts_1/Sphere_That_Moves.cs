using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_That_Moves : MonoBehaviour
{
    Vector3 positionOffset;
    // Start is called before the first frame update
    void Start()
    {
        positionOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time) * 5, 0) + positionOffset;
    }
}
