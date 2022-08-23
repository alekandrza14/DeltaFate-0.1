using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timesound : MonoBehaviour
{
   
    void Update()
    {
        if (GetComponent<AudioSource>())
        {
            if (GetComponent<AudioSource>().isPlaying == false)
            {
                Destroy(gameObject);
                
            }
        }
        
    }
}
