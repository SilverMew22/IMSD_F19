﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepScore : MonoBehaviour
{
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.Box(new Rect(100,100,100,100), Score.ToString());
    }
}
