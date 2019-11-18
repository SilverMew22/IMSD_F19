using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EightBoxes : MonoBehaviour
{
    Transform[] boxes = new Transform[8];
    public GameObject prefabOfBox;
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            GameObject g = Instantiate(prefabOfBox, new Vector3(-8 + 2 * i, 0, 0), Quaternion.identity);
            boxes[i] = g.transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveBoxUpOrDown(boxes[0], Input.GetKey(KeyCode.A));
        MoveBoxUpOrDown(boxes[1], Input.GetKey(KeyCode.S));
        MoveBoxUpOrDown(boxes[2], Input.GetKey(KeyCode.D));
        MoveBoxUpOrDown(boxes[3], Input.GetKey(KeyCode.F));
        MoveBoxUpOrDown(boxes[4], Input.GetKey(KeyCode.J));
        MoveBoxUpOrDown(boxes[5], Input.GetKey(KeyCode.K));
        MoveBoxUpOrDown(boxes[6], Input.GetKey(KeyCode.L));
        MoveBoxUpOrDown(boxes[7], Input.GetKey(KeyCode.Semicolon));
    }
    void MoveBoxUpOrDown(Transform box, bool upDown)
    {
        Vector3 hold = box.position;
        if (upDown)
            hold.y = 1;
        else
            hold.y = 0;
        box.position = hold;
    }
}