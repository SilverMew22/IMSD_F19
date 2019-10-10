using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //myText.text = "" + Time.time;

    }
    public void ChangeText()
    {
        Debug.Log("You pressed the buttom");
    }
}
