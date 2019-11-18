using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Big_Small : MonoBehaviour
{
    Transform[] boxes = new Transform[3];
    public bool large;
    public GameObject prefabOfSphere;
    public int x = 1;
    public int y = 1;
    public int z = 1;
    
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject g = Instantiate(prefabOfSphere, new Vector3(-8 + 2 * i, 0, 0), Quaternion.identity);
            boxes[i] = g.transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        BigOrSmall(boxes[0], Input.GetKey(KeyCode.A));
        BigOrSmall(boxes[1], Input.GetKey(KeyCode.S));
        BigOrSmall(boxes[2], Input.GetKey(KeyCode.D));
       
    }
    void BigOrSmall(Transform box, bool large)
    {
        Vector3 hold = box.transform.localScale;
        if (large)
             transform.localScale += new Vector3(x,y,z);
        else
             transform.localScale -= new Vector3(x,y,z); 
        box.transform.localScale = hold;
    }
}