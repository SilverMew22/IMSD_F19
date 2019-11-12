using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBalls : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Preditor"))
        {
            collectSound.Play();
            //theScore +=1;
            //scoreText.GetComponent<Text>().text = "SCORE" + theScore;
            Destroy(gameObject);
        }
    }

}

