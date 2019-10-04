using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallPoints : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject Preditor;
    public UnityEngine.UI.Text Win;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Bounce")
        { keepScore.Score += 1;
            Debug.Log("We got hit");
            Destroy(gameObject);
            collectSound.Play();

            if (keepScore.Score == 2) {
                Win.text = "Win";

            }
        }        
        
    }
}