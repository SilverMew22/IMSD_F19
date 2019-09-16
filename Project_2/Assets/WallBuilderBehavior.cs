using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilderBehavior : MonoBehaviour
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

        BuildAWallAtZ(-1);
        BuildAWallAtZ(3);
    }

    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 10; xPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(SteveTheCube, new Vector3(xPos * 2 - 10, yPos * 1.5f, z), Quaternion.identity);
            }
        }
    }
}
