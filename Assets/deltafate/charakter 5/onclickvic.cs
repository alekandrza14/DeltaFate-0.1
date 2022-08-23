using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class onclickvic : MonoBehaviour
{
    public GameObject[] g;
    public string s;
    void Start()
    {
        if (!Directory.Exists("debug"))
        {
            g[0].SetActive(false);
            g[1].SetActive(false);
            g[2].SetActive(false);
            g[3].SetActive(false);
            
            
        }
    }

    
    void Update()
    {
        if(Directory.Exists("debug"))
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                PlayerPrefs.SetInt("rs",0);
            }
        }
    }
    public void ss()
    {
        PlayerPrefs.SetString("rejim",s);
        g[0].SetActive(false);
        g[1].SetActive(false);
        g[2].SetActive(false);
        g[3].SetActive(false);
        
    }
}
