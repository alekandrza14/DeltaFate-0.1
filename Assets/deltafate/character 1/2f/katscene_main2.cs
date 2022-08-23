using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class katscene_main2 : MonoBehaviour
{
    public string charakter;
    public AudioClip[] c;
    public AudioSource audioSource1;
    public items s = new items();
    public bool s1;
    
    
    void Update()
    {



        
        if (audioSource1.isPlaying == true)
        {
            s1 = true;
        }
        if (!s1)
        {
            if (audioSource1.isPlaying == false)
            {
                if (PlayerPrefs.GetString(charakter, "") == "done")
                {

                    audioSource1.clip = c[0];
                    audioSource1.Play();
                    //PlayerPrefs.SetInt("c", 1);

                    // Destroy(gameObject);



                }
            }
        }
        
        
        if (audioSource1.isPlaying == false)
        {
            if (s1)
            {
                if (PlayerPrefs.GetInt("c", 0) == 0)
                {

                    PlayerPrefs.SetString(charakter, "");
                    PlayerPrefs.SetInt("c", 1);

                    Destroy(gameObject);
                }
                if (PlayerPrefs.GetInt("c", 0) == 2)
                {

                    PlayerPrefs.SetString(charakter, "");
                    PlayerPrefs.SetInt("c", 3);

                    Destroy(gameObject);
                }
            }
        }
    }
        
                
                   
      
}

