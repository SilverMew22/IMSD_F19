using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
  
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Bounce"))
        {
            collectSound.Play();
            keepScore.Score += 100;
            Destroy(gameObject);
        }
    }
}
