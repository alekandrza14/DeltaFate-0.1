using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryperPlayer : MonoBehaviour
{
    public float hpos; public float hwpos; public float hzpos; public float hypos; public float hxpos;
    public float shpos; public float swpos; public float szpos; public float sypos; public float sxpos;
    public float sizecell; public float sizecellw; public float sizecellz; public float sizecelly; public float sizecellx;
    public Scrollbar[] scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists("DELTAFATE/var/" + SceneManager.GetActiveScene().buildIndex + "SCENE.V5"))
        {


            Vector5 v5 = new Vector5();
            v5 = v5json.stringtov5(File.ReadAllText("DELTAFATE/var/" + SceneManager.GetActiveScene().buildIndex + "SCENE.V5"));
            scrollbar[0].value = (float)v5.h;
            scrollbar[1].value = (float)v5.w;
            scrollbar[2].value = (float)v5.z;
            scrollbar[3].value = (float)v5.y;
            scrollbar[4].value = (float)v5.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hpos = shpos; hwpos = swpos; hzpos = szpos; hypos = sypos; hxpos = sxpos;
        hpos += scrollbar[0].value * sizecell;
        hwpos += scrollbar[1].value * sizecellw; 
        hzpos += scrollbar[2].value * sizecellz;
        hypos += scrollbar[3].value * sizecelly;
        hxpos += scrollbar[4].value * sizecellx;
        Vector5 v5 = new Vector5();
        v5.x = scrollbar[4].value; v5.y = scrollbar[3].value; v5.z = scrollbar[2].value; v5.w = scrollbar[1].value; v5.h = scrollbar[0].value;
        Directory.CreateDirectory("DELTAFATE/var");
        File.WriteAllText("DELTAFATE/var/" + SceneManager.GetActiveScene().buildIndex + "SCENE.V5", v5json.v5tostring(v5));
    }
}
