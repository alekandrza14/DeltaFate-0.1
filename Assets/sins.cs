using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class sins : MonoBehaviour
{
    // Start is called before the first frame update
    public string file;
    void Start()
    {
        if (!File.Exists("sins/"+file))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
