using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColorChanger3 : MonoBehaviour
{
    public Light colorChange;
    
    public float startTimer;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        colorChange.color = new Color(1, .5f, 0);
        timer += Time.deltaTime;


    }

    // Update is called once per frame
    private void Update()
    {
        startTimer += Time.deltaTime;

       if (startTimer >= 5) timer += Time.deltaTime;

        float r = (Mathf.Sin(timer) / 2) + .5f;


        colorChange.color = new Color(r, 0, 0);
        

    }
}
