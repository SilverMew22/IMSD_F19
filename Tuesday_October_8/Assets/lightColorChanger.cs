using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColorChanger : MonoBehaviour
{
    public Light colorChange;
    public Light colorChange2;
    public bool change;
    public float startTimer;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        colorChange.color = new Color(1,.5f,0);
        colorChange.color = new Color(1, .5f, 0);
        timer += Time.deltaTime;


    }

    // Update is called once per frame
    void Update()
    {
        startTimer += Time.deltaTime;

        if (startTimer >= 5) timer += Time.deltaTime;

        if (startTimer >= 5) colorChange.color = new Color (1, 0, 0);
        else colorChange.color=new Color (0,1,0);

    }
}
