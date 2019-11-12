using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferToOtherStuff : MonoBehaviour
{
    public GameObject putAgameObjectHere;
    //public GameObject OtherStuff;
    public bool stuff;
    private Vector3 offset;
    public float startTimer;
    private float timer;
    public AudioSource Sound_1;
    public AudioSource Sound_2;
    public AudioSource Sound_3;
    public AudioSource Sound_4;
    public Rigidbody myRb;
    public Rigidbody myRb_2;
    public float multiplier = 10f;
    public Light colorChange;
    public Renderer rend;
 
   

    // Start is called before the first frame update
    void Start()
    {
        offset = putAgameObjectHere.transform.position;
        timer += Time.deltaTime;
        colorChange.color = new Color(1, .5f, 0);
        //ScaleMode = putAgameObjectHere.transform.localScale;
        rend = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        //startTimer += Time.deltaTime;

       // if (startTimer >= 3) timer += Time.deltaTime;

        //if (stuff) putAgameObjectHere.transform.position = new Vector3(Mathf.Sin(timer), 0, 0) + offset;
        //else putAgameObjectHere.transform.position = new Vector3(0, Mathf.Sin(timer), 0) + offset;

        if (Input.GetKey(KeyCode.W))
        {
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
            Sound_1.Play();
            Sound_2.Stop();
            Sound_3.Stop();
            Sound_4.Stop();
            colorChange.color = new Color(0, 50, 10);
            rend.material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myRb.AddForce(new Vector3(0f, 0f, -1f) * multiplier);
            Sound_2.Play();
            Sound_1.Stop();
            Sound_3.Stop();
            Sound_4.Stop();
            colorChange.color = new Color(0, 40, 10);
            rend.material.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRb_2.AddForce(new Vector3(1f, 0f, 0f) * multiplier);
            Sound_3.Play();
            Sound_1.Stop();
            Sound_2.Stop();
            Sound_4.Stop();
            colorChange.color = new Color(0, 10, 50);
            rend.material.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRb_2.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
            Sound_4.Play();
            Sound_1.Stop();
            Sound_2.Stop();
            Sound_3.Stop();
            colorChange.color = new Color(0, 10, 40);
            rend.material.color = Color.red;
        }

    }
}
