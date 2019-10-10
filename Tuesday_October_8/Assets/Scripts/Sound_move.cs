using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_move : MonoBehaviour

{
	
	public AudioSource Sound_1;
	public AudioSource Sound_2;
    public AudioSource Sound_3;
    public AudioSource Sound_4;

    //public GameObject up_down;
    //public GameObject left_right;
    public Rigidbody myRb;
    public Rigidbody myRb_2;
    public float multiplier = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.W))
		{
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
            Sound_1.Play();
            Sound_2.Stop();
            Sound_3.Stop();
            Sound_4.Stop();
		}
		if (Input.GetKey(KeyCode.S))
		{            
                myRb.AddForce(new Vector3(0f, 0f, -1f) * multiplier);
            Sound_2.Play();
            Sound_1.Stop();
            Sound_3.Stop();
            Sound_4.Stop();        }
		if (Input.GetKey(KeyCode.D))
		{
            myRb_2.AddForce(new Vector3(1f, 0f, 0f) * multiplier);
            Sound_3.Play();
            Sound_1.Stop();
            Sound_2.Stop();
            Sound_4.Stop();        }
		if (Input.GetKey(KeyCode.A))
		{
            myRb_2.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
            Sound_4.Play();
            Sound_1.Stop();
            Sound_2.Stop();
            Sound_3.Stop();     }
	}
}
