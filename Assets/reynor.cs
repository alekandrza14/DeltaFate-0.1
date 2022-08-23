using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class reynor : MonoBehaviour
{
    public Sprite reynorsp;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists("DELTAFATE/var/curretchar.string"))
        {


            if (File.ReadAllText("DELTAFATE/var/curretchar.string") == "reynor")
            {
                GetComponent<SpriteRenderer>().sprite = reynorsp;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
