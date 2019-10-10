using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BounceNoise : MonoBehaviour
{
    
    
    public AudioSource bounceSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Preditor"))
        {
            bounceSound.Play();
           
            
        }
    }

}


