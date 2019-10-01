using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody mushroom;
    Animator myAnim;
    GameObject[] mushMens;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        mushroom = GetComponent<Rigidbody>();

        mushMens = GameObject.FindGameObjectsWithTag("mushMen");
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
        if (Input.GetKey(KeyCode.Space))
        { myAnim.SetInteger("state", 9); }

        //left
        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetInteger("state", 24);
        }

        //right
        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetInteger("state", 23);
        }

        //walk_walkbackwards
        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetInteger("state", 17);
        }
    }
}

