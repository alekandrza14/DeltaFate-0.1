using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public string varible;
    public int voule;
    public igrok i;
    public void Start()
    {
        i = GameObject.FindObjectOfType<igrok>();
    }
    public void buttton()
    {
        
        if (i.fight == false)
        {


            PlayerPrefs.SetInt(varible, voule);
        }
    }
}
