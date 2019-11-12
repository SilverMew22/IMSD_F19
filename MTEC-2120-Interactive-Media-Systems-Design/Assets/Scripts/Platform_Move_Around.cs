
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Move_Around : MonoBehaviour
{
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = startPosition.x;
        float y = 1 * Mathf.Sin(Time.timeSinceLevelLoad) + startPosition.y;
        float z = startPosition.z;
        transform.position = new Vector3(x, y, z);
    }
}


