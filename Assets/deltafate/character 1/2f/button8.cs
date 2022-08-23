using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button8 : MonoBehaviour
{

    
    public string charakter;
    public string dialog;

    private void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
            {

                
                PlayerPrefs.SetString(charakter,dialog);
            }

        }
    }
}

