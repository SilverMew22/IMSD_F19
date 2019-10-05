using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_Lose : MonoBehaviour
{
    public Text Win;
    public int ballsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {
        Win = GameObject.Find("Win").GetComponent<Text>();
        Win.text = "";
        ballsCollected = 0;
    }

    void OnCollisionEnter(Collider col)
    {   if (col.gameObject.CompareTag("Ball"))
        { ballsCollected++; }
        if (col.gameObject.name == "Ball" && ballsCollected == 2)
        { Win.text = "You Win"; } }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
