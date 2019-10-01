
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat_Food : MonoBehaviour
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
