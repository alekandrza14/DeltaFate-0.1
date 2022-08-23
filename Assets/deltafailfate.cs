using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class deltafailfate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!File.Exists("sins/UNDERFAIL.txt"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
