using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical_MoveMush : MonoBehaviour
{
    Rigidbody myRb;
    public float multiplier = 10f;
    int Prey_Eaten;
    public int eatThresh = 3;
    private Renderer rend;
    //Vector3 playerPos;
    //Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        //playerPos = transform.position;
        //startPos = playerPos;

    }

    // Update is called once per frame
    void Update()
    {


        // Vector3 newPos = playerPos;

        //bool noMove = false;

        //if (!noMove)
        //  { playerPos = newPos; }

        if (Input.GetKeyDown(KeyCode.W) && !Input.GetMouseButton(0))
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        else { myRb.AddForce(new Vector3(0f, 0f, 0f) * multiplier); }

        if (Input.GetKeyDown(KeyCode.A) && !Input.GetMouseButton(0))
            myRb.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
        else { myRb.AddForce(new Vector3(0f, 0f, 0f) * multiplier); }

        if (Input.GetKeyDown(KeyCode.S) && !Input.GetMouseButton(0))
            myRb.AddForce(new Vector3(0f, 0f, -1f) * multiplier);
        else { myRb.AddForce(new Vector3(0f, 0f, 0f) * multiplier); }

        if (Input.GetKeyDown(KeyCode.D) && !Input.GetMouseButton(0))
            myRb.AddForce(new Vector3(1f, 0f, 0f) * multiplier);
        else { myRb.AddForce(new Vector3(0f, 0f, 0f) * multiplier); }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Prey"))
        {
            //Debug.Log("The preditor hit you.");
            Destroy(col.gameObject);
            Prey_Eaten++;
        }

        if (col.gameObject.CompareTag("mushMan"))
        {
            //Debug.Log("The mushroom hit you.");

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

