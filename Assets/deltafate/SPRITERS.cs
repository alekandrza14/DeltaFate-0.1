using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SPRITERS : MonoBehaviour
{
    public Sprite[] sp;
    public Sprite[] sp2;
    public string sp4;
    public int index;
    public string[] sp2s;
    public int[] indexs;
    private void Start()
    {
        if (File.Exists("res/" + sp4 + "_" + index + ".un"))
        {
            sp = new Sprite[2];
            sp[0] = records2.spritest2(sp2s[0], indexs[0], sp[0]);
            sp[1] = records2.spritest2(sp2s[1], indexs[1], sp[1]);
            sp2[0] = records2.spritest2(sp2s[2], indexs[2], sp2[0]);
            sp2[1] = records2.spritest2(sp2s[3], indexs[3], sp2[1]);




        }
    }
    void Update()
    {
        if (sp.Length != 0)
        {
            sp[0] = records2.spritest2(gameObject.name, 0, sp[0]);
            sp[1] = records2.spritest2(gameObject.name, 1, sp[1]);
        }
        if (sp2.Length != 0)
        {
            sp2[0] = records2.spritest2(gameObject.name, 2, sp2[0]);
            sp2[1] = records2.spritest2(gameObject.name, 3, sp2[1]);
        }

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
                if (i >= 0)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = sp[0];
                }
                if (i < 0)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = sp[1];
                }
            }
            else
            {

                gameObject.GetComponent<SpriteRenderer>().sprite = sp[0];


            }
        }


    }
}
