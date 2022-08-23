using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;
using UnityEngine.Networking;
using System;

public class SPRITERS4 : MonoBehaviour
{
    public AudioClip[] sp;
    public AudioClip[] sp2;
    public string path;
    void Start()
    {

        WWW www = new WWW("file:///res/"+path);




        gameObject.GetComponent<AudioSource>().clip = www.GetAudioClip(false,true,AudioType.WAV);
        gameObject.GetComponent<AudioSource>().Play();







    }
    
    
}
