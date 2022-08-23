using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textys : MonoBehaviour
{
    public TextMesh txt;
    public TextMesh txt2;

    // Update is called once per frame
    void Update()
    {
        txt.text = PlayerPrefs.GetString("text", "");
        if (txt2 != null)
        {


            txt2.text = PlayerPrefs.GetString("text2", "");
            
        }
    }
}
