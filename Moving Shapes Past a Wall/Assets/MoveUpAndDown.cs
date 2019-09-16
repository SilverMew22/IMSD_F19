using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    //output = A * Sin (frequencey*time+0(up/down))+0A(left and right)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==false)
        {
            Debug.Log("I stopped moving for one frame");
            Vector3 theNextPosition = transform.position;
            theNextPosition.y = Mathf.Sin(Time.time) * 3;
            transform.position = theNextPosition;
        }
        else { }


    }
}

