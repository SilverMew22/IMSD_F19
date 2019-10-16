using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferToOtherStuff : MonoBehaviour
{
    public GameObject putAgameObjectHere;
    public GameObject OtherStuff;
    public bool stuff;
    private Vector3 offset;
    public float startTimer;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        offset = putAgameObjectHere.transform.position;
        timer += Time.deltaTime;
        //ScaleMode = putAgameObjectHere.transform.localScale;
            
        
    }

    // Update is called once per frame
    void Update()
    {
        startTimer += Time.deltaTime;

        if (startTimer >= 3) timer += Time.deltaTime;

        if (OtherStuff) putAgameObjectHere.transform.position = new Vector3(Mathf.Sin(timer), 0, 0) + offset;
        else putAgameObjectHere.transform.position = new Vector3(0, Mathf.Sin(timer), 0) + offset;
        
    }
}
