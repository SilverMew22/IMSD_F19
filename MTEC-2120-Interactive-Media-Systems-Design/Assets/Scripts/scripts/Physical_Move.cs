using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical_Move : MonoBehaviour
{
    Rigidbody myRb;
    public float multiplier = 10f;
    int Prey_Eaten;
    public int eatThresh = 3;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        if (Input.GetKeyDown(KeyCode.A))
            myRb.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
        if (Input.GetKeyDown(KeyCode.S))
            myRb.AddForce(new Vector3(0f, 0f, -1f) * multiplier);
        if (Input.GetKeyDown(KeyCode.D))
            myRb.AddForce(new Vector3(1f, 0f, 0f) * multiplier);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Prey"))
        {
            //Debug.Log("The preditor hit you.");
            Destroy(col.gameObject);
            Prey_Eaten++;

        }

        if (col.gameObject.CompareTag("Preditor"))
        {
            if (Prey_Eaten < eatThresh)
            {
                Destroy(gameObject);
                rend.material.color = Color.red;
            }
        }
    }
}
