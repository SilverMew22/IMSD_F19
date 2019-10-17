using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5;

    public Vector3 lookAngles;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetAxis("Mouse X") != 0)
        {
            lookAngles.y += Input.GetAxis("Mouse X");
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            lookAngles.x += Input.GetAxis("Mouse Y");
        }

        transform.rotation = Quaternion.Euler(lookAngles);
    }
}
