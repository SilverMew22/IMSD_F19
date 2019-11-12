using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move_new_1 : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    Rigidbody myRb;

    // Start is called before the first frame update
    void Start()
    {      
        rb = GetComponent<Rigidbody>();}

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate(straffe, 0, translation);
   

        if (Input.GetKey(KeyCode.W))
        {
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            
        }
        if (Input.GetKey(KeyCode.D))
        {
           
        }

        


        
    }
}

