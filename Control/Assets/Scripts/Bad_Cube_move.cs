using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_Cube_move : MonoBehaviour
{
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 2 * Mathf.Cos(Time.timeSinceLevelLoad) + startPosition.y;
        float y = 2 * Mathf.Cos(Time.timeSinceLevelLoad) + startPosition.y;
        //float z = startPosition.z;
        float z = 2 * Mathf.Cos(Time.timeSinceLevelLoad) + startPosition.y;
        transform.position = new Vector3(x, y, z);
    }
}


