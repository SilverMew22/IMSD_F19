using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land_Builder : MonoBehaviour
{
    public GameObject SteveTheCube;



    void Start()
    {

        //Instantiate(SteveTheCube, new Vector3(0, 5, 9), Quaternion.identity);

        //for (int i = 0; i < 10; i++)
        //{
        //    Instantiate(SteveTheCube, new Vector3(i * 2 - 10, 0, 0), Quaternion.identity);
        //}

        //for (int xPos = 0; xPos < 10; xPos++)
        //{
        //    for (int yPos = 0; yPos < 5; yPos++)
        //    {
        //        Instantiate(SteveTheCube, new Vector3(xPos * 2 - 10, yPos * 1.5f, 0), Quaternion.identity);
        //    }
        //}

        //BuildAWallAtZ(-1);
        //BuildAWallAtZ(10);
        //BuildAWallAtX(1);
        //BuildAWallAtX(-8);

        //BuildAWallAtY(0);
        //BuildAWallAtY2(0);
        //BuildAWallAtY(10);
        BuildAWallAtY2(-8);


    }


    /*void BuildAWallAtZ(float z)//left and right wall
    {
        for (int xPos = 0; xPos < 10; xPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(SteveTheCube, new Vector3(xPos * 1 - 10, yPos * 1f, z), Quaternion.identity);
            }
        }
    }
    void BuildAWallAtX(float x)//front and back wall
    {
        for (int zPos = 0; zPos < 10; zPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(SteveTheCube, new Vector3(x + -2, yPos, zPos), Quaternion.identity);
            }
        }
    }
    void BuildAWallAtY(float y)//make a wall at the top
    {
        for (int xPos = 0; xPos < 5; xPos++)
        {
            for (int zPos = 0; zPos < 5; zPos++)
            {
                Instantiate(SteveTheCube, new Vector3(xPos - 10, 4, zPos), Quaternion.identity);
            }
        }
    }*/
    void BuildAWallAtY2(float y)//make a wall at the bottom
    {
        for (int xPos = 0; xPos < 4; xPos++)
        {
            for (int zPos = 0; zPos < 4; zPos++)
            {
                Instantiate(SteveTheCube, new Vector3(xPos *2, 0, zPos*2), Quaternion.identity);
            }
        }
    }

}
