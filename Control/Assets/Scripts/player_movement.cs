using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
    public float mSpeed;
    
    // Use this for initialization
    void Start () {
        mSpeed = 7f;
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(mSpeed * Input.GetAxis
            ("Horizontal") * Time.deltaTime, 0f, mSpeed * 
            Input.GetAxis ("Vertical") * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1 * Time.deltaTime * mSpeed, 0);

        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.position += new Vector3(0, -1 * Time.deltaTime * mSpeed, 0);
        }
        
    }
}
