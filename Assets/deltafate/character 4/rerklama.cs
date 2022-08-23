using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class rerklama : MonoBehaviour
{
    public GameObject txt;
    public string res;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"res/" + res + ".txt") && txt.GetComponent<Text>())
        {
            txt.GetComponent<Text>().text = File.ReadAllText(@"res/" + res + ".txt");
        }
        if (File.Exists(@"res/" + res + ".txt") && txt.GetComponent<TextMesh>())
        {
            txt.GetComponent<TextMesh>().text = File.ReadAllText(@"res/" + res + ".txt");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
