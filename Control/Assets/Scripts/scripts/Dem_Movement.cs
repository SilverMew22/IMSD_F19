using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dem_Movement : MonoBehaviour
{
    Animator myAnim;
    AudioSource aud;
    public AudioClip moveClip;
    Vector3 playerPos;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        myAnim.SetInteger("state", 0);

        //walking
        if (Input.GetKey(KeyCode.W) && !Input.GetMouseButton(0))
        {
            myAnim.SetInteger("state", 1);

        }
        //jump
        if (Input.GetKey(KeyCode.Space) && !Input.GetMouseButton(0))
        { myAnim.SetInteger("state", 9); }

        //left
        if (Input.GetKey(KeyCode.A) && !Input.GetMouseButton(0))
        {
            myAnim.SetInteger("state", 24);
        }

        //right
        if (Input.GetKey(KeyCode.D) && !Input.GetMouseButton(0))
        {
            myAnim.SetInteger("state", 23);
        }

        //walk_walkbackwards
        if (Input.GetKey(KeyCode.S) && !Input.GetMouseButton(0))
        {
            myAnim.SetInteger("state", 17);
        }

        //run
        //if (Input.GetKey(KeyCode.LeftShift))
        //{ myAnim.SetInteger("state", 9); }

        //attack
        //if (Input.GetMouseButton(0))
        //{ myAnim.SetInteger("state", 10); }

        //right_run
        //if (Input.GetKey(KeyCode.LeftShift))
        //{ myAnim.SetInteger("state", 13); }

        //run_walkbackwards
        //if (Input.GetKey(KeyCode.LeftShift))
        // { myAnim.SetInteger("state", 18); }

        //flex
        //if (Input.GetKey(KeyCode.E))
        //{ myAnim.SetInteger("state", 19); }

        //roar
        //if (Input.GetKey(KeyCode.R))
        // { myAnim.SetInteger("state", 20);
        // aud.PlayOneShot(moveClip);}
    }
}


