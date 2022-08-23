using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class getpp : MonoBehaviour
{
    
    public save saves;
    public string int2;
    [SerializeField]private int int1;
    void Start()
    {
        if (File.Exists(@"DELTAFATE/var/" + int2 + ".int"))
        {
            int1 = savevartous.usvar(@"DELTAFATE/var/" + int2 + ".int", 0);
        }
        if (int1 == 0) 
        {
            Destroy(gameObject);
        }
    }


    
    void Update()
    {
        
    }
}
