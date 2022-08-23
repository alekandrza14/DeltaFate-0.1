using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;

public class SPRITERS1 : MonoBehaviour
{
    public VideoClip[] sp;
    public VideoClip[] sp2;
    void Update()
    {
        if (PlayerPrefs.GetInt("dif", 0) == 3)
        {

            if (sp2.Length != 0)
            {


                sp = sp2;
            }
        }
        if (sp.Length != 0)
        {
            if (File.Exists(@"DELTAFATE/unauticna/seed.un"))
            {
                int i = int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un"));
                if (i > 0)
                {
                    gameObject.GetComponent<VideoPlayer>().clip = sp[0];
                }
                if (i < 0)
                {
                    gameObject.GetComponent<VideoPlayer>().clip = sp[1];
                }
            }
            else
            {

                gameObject.GetComponent<VideoPlayer>().clip = sp[0];


            }

        }
    }
}
