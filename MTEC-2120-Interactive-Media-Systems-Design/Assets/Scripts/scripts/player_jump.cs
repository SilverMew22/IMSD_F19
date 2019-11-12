using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jump : MonoBehaviour {
    public bool onGround;
    private Rigidbody rb;
 
    void Start() {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        if (onGround)
        { if (Input.GetButtonDown("Jump"))
            { rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false; } } } 
    
	void OnCollisionEnter(Collision other)
    { if (other.gameObject.CompareTag
    ("Ground")){onGround = true;} } }
