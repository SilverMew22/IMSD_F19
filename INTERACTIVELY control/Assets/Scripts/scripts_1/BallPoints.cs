using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallPoints : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject Preditor;
    public Text Win;
    private int ballsCollected = 0;

    void Start()
    {
        Win = GameObject.Find("Win").GetComponent<Text>();
        Win.text = "";
        ballsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Ball" && ballsCollected == 2)
        { Win.text = "You Win"; }
    }

   void OnCollisionEnter(Collision col)
    {
        if (col.transform.name == "Bounce")
        { keepScore.Score += 1;
            Debug.Log("We got hit");
            Destroy(gameObject);
            collectSound.Play();
            ballsCollected++;
                               } 
    
    }
   

    }
