using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetaudio : MonoBehaviour
{
    public AudioClip[] cl;
    public AudioSource as1; public katscene_main as2;
    private void Start()
    {
        if(as1)
            as1.clip = cl[PlayerPrefs.GetInt("ling", 0)];



        if (as2)
            as2.c[0] = cl[PlayerPrefs.GetInt("ling", 0)];
    }
}
