using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class le
{
    public static int s;
}

public class createtablrek : MonoBehaviour
{
    public GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
       DirectoryInfo di = new DirectoryInfo("records");
        for (int i = di.GetFiles().Length-1; i > -1; i--)
        {
            
           Text t = Instantiate(txt,txt.transform.position,Quaternion.identity,transform.parent).GetComponent<Text>();
            t.text = float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)).ToString("F2") + "min";
            if (float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) > 12.01f)
            {
                t.color = new Color(1, 0.8901961f, 0);
            }
            if (float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) < 5.4f && float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) > 1.2f)
            {
                t.color = new Color(0f, 0f, 0f);
            }
            if (float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) < 1.2f)
            {
                t.color = new Color(0f, 0f, 0f,0.2f);
            }
            if (float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) < 12.01 && float.Parse(File.ReadAllText(di.GetFiles()[i].FullName)) > 5.4f)
            {
                t.color = new Color(0.5568628f, 0.55686281f, 0.5568628f);
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
