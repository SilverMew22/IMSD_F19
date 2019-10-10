using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_basket : MonoBehaviour
{
    public Transform destination;
    Vector3 playerPos;
    Rigidbody myRb;
    public float multiplier = 10f;
    public TextMesh playerText;
    public Transform hazard;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        playerPos = transform.position;
        startPos = playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = playerPos;

        if (Input.GetKeyDown(KeyCode.W))
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        if (Input.GetKeyDown(KeyCode.A))
            myRb.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
        if (Input.GetKeyDown(KeyCode.S))
            myRb.AddForce(new Vector3(0f, 0f, -1f) * multiplier);
        if (Input.GetKeyDown(KeyCode.D))
            myRb.AddForce(new Vector3(1f, 0f, 0f) * multiplier);


        if (playerPos.x == destination.position.x &&
        playerPos.z == destination.position.z)
        {
            playerText.text = "You win";
        }
        else
        {
            playerText.text = "keep going, you're doing fine";
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag.Contains("Hazard"))
        { playerText.text = "Don't touch the lava"; }
    }

}


