using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColorChanger : MonoBehaviour
{
    public Light colorChange;
    // Start is called before the first frame update
    void Start()
    {
        colorChange.color = new Color(1,.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
