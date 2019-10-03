using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DayNight : MonoBehaviour
{
    public float time;
    public TimeSpan CurrentTime;
    public Transform SunTransform;
    public Light sun;
    public Text timetext;
    public int days;
    public float Intensity;
    public Color fogday = Color.grey;
    public Color fognight = Color.black;
    public int speed;

   

    // Update is called once per frame
    void Update()
    {
        ChangeTime();
    }
    public void ChangeTime()
    {
        time += Time.deltaTime * speed;
        if(time> 86400) { days += 1;
            time = 0;
        }
        CurrentTime = TimeSpan.FromSeconds(time);
        string[] temptime = CurrentTime.ToString().Split(":"[0]);
        timetext.text = temptime[0] + ":" + temptime[1];
        SunTransform.rotation = Quaternion.Euler (new Vector3 ((time - 21600)/86400*360,0,0));
        if (time < 43200) Intensity = 1 - (43200 - time) / 43200;
        else Intensity = 1 - ((43200 - time) / 43200 * -1);
        RenderSettings.fogColor = Color.Lerp(fognight,fogday,Intensity*Intensity);
        sun.intensity = Intensity;

    }

}
