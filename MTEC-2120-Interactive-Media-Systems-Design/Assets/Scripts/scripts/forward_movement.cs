using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward_movement : MonoBehaviour
{
    Vector3 playerPos;
    Vector3 startPos;
    public Transform destination;
    GameObject[] orbs;
    GameObject[] hazards;
    GameObject[] blocks;
    GameObject[] walls;
    GameObject[] doors;
    public TextMesh playerMessage;
    private Renderer rend;
    AudioSource aud;
    public AudioClip moveClip;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = transform.position;
        startPos = playerPos;
        playerMessage.text = "^_^";
        hazards = GameObject.FindGameObjectsWithTag("Hazard");
        blocks = GameObject.FindGameObjectsWithTag("Block");
        orbs = GameObject.FindGameObjectsWithTag("Orb");
        walls = GameObject.FindGameObjectsWithTag("Wall");
        doors = GameObject.FindGameObjectsWithTag("Door");
        rend = GetComponent<Renderer>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 newPos = playerPos;

        if (Input.GetKeyDown(KeyCode.W))
        {
            newPos = playerPos + transform.forward;
            aud.PlayOneShot(moveClip);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            newPos = playerPos - transform.forward;
            aud.PlayOneShot(moveClip);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newPos = playerPos + transform.right;
            aud.PlayOneShot(moveClip);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            newPos = playerPos - transform.right;
            aud.PlayOneShot(moveClip);
        }

        bool inABlock = false;


        for (int i = 0; i < blocks.Length; i++)
        {

            if (newPos.x == blocks[i].transform.position.x &&
                newPos.z == blocks[i].transform.position.z)
            {

                inABlock = true;
            }
        }

        if (!inABlock)
        { playerPos = newPos; }


        for (int i = 0; i < walls.Length; i++)
        {

            if (newPos.x == walls[i].transform.position.x &&
                newPos.z == walls[i].transform.position.z)
            {

                inABlock = true;
            }
        }

        if (!inABlock)
        { playerPos = newPos; }

        for (int i = 0; i < doors.Length; i++)
        {

            if (newPos.x == doors[i].transform.position.x &&
                newPos.z == doors[i].transform.position.z)
            { inABlock = true; }
        }

        if (!inABlock)
        { playerPos = newPos; }

        for (int i = 0; i < hazards.Length; i++)
        {

            if (playerPos.x == hazards[i].transform.position.x &&
                playerPos.z == hazards[i].transform.position.z)
            {
                playerPos = startPos;
                playerMessage.text = "-_-";

            }
            else { playerMessage.text = "^_^"; }
        }
        if (playerPos.x == destination.position.x &&
            playerPos.z == destination.position.z)
        {
            //playerPos += transform.up;
            rend.material.color = Color.blue;
            playerMessage.text = "Yay";

        }
        else
        {
            playerMessage.text = "^_^";
            rend.material.color = Color.red;
        }
        transform.position = playerPos;
    }
}
