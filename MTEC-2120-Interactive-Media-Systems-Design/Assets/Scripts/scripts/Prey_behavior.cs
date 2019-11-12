using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey_behavior : MonoBehaviour
{
    Rigidbody preyRB;
    public Transform pred;
    public float forceAmt;


    // Start is called before the first frame update
    void Start()
    {
        preyRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 preyDirection = Vector3.Normalize
            (transform.position - pred.position);
        preyRB.AddForce(preyDirection * forceAmt);

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform == pred)
        {
            Debug.Log("The preditor hit you.");

        }
        else
        {


        }
    }

}






