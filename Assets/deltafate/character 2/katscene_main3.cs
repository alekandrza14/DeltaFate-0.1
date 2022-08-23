using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class katscene_main3 : MonoBehaviour
{

    public AudioClip[] c;
    public AudioSource audioSource1;
    
    
    
   
    public void Update()
    {



        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (audioSource1.isPlaying == false)
            {


                audioSource1.clip = c[0];
                audioSource1.Play();
            }
            
        }

    }
}
