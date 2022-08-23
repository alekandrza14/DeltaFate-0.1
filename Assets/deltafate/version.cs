using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class version : MonoBehaviour
{
    public RawImage r;
    private void Start()
    {
        if (File.Exists(@"res/version.png"))
        {


            WWW www = new WWW("file:///res/version.png");
            r.texture = www.texture;
            r.texture.filterMode = FilterMode.Point;
            if (r.texture != null)
            {
                r.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
