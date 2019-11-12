using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pred_behavior : MonoBehaviour
{
    Rigidbody predRB;
    public Transform prey;
    public float forceAmt;
    public float distThrest;


    // Start is called before the first frame update
    void Start()
    {
        predRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 preyDirection = Vector3.Normalize
        (prey.position - transform.position);


        if (Vector3.Distance(prey.position, transform.position) <= distThrest)
        { predRB.AddForce(preyDirection * forceAmt); }
    }
}
