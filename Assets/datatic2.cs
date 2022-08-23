using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Tilemaps;
using System.IO;

public class datatic2 : MonoBehaviour
{
    public int time;
    public byte[] s; public byte[] s32;
    public string delux = "0";
    public GameObject gt;
    // Start is called before the first frame update
    private void Awake()
    {
        if (DateTime.Now.Hour == 8 || Directory.Exists("debug/light"))
        {
            if (delux == "4")
            {


                Instantiate(gt.gameObject, transform);
            }

        }
    }
    void Start()
    {
        if (File.Exists("res/list"))
        {
            s32 = File.ReadAllBytes("res/list");
            del.delux = s32[9]; del.delux2 = s32[11];

        }
        if (File.Exists("license.t"))
        {
            s = File.ReadAllBytes("license.t");
            Debug.Log(File.ReadAllBytes("license.t"));

            if (s[9] == del.delux && s[10] == del.delux2
            )
            {
                if (delux == "1")
                {
                    if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour < 12)
                    {
                        Debug.Log("выстурпление начато");

                    }

                }

            }
            else if (delux == "1" && s[9] != del.delux || delux == "1" && s[10] != del.delux2)
            {
                Destroy(gameObject);
            }
            if (s[9] == del.delux && s[10] == del.delux2
           )
            {
                if (delux == "2")
                {
                    if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour < 12)
                    {


                    }
                    else
                    {
                        Destroy(gameObject);
                    }

                }
            }
            else if (delux == "1" && s[9] != del.delux || delux == "1" && s[10] != del.delux2
            )
            {
                Destroy(gameObject);
            }
        }


        else if (delux == "1")
        {

            Destroy(gameObject);
        }


        if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 3 || Directory.Exists("debug/hight"))
        {
            if (gameObject.GetComponent<Tilemap>())
            {
                gameObject.GetComponent<Tilemap>().color = new Color(gameObject.GetComponent<Tilemap>().color.r / 2, gameObject.GetComponent<Tilemap>().color.g / 2, gameObject.GetComponent<Tilemap>().color.b / 2);
            }
            if (gameObject.GetComponent<HardLight2D>())
            {
                gameObject.GetComponent<HardLight2D>().Intensity = 2;
            }
            if (gameObject.GetComponent<zombie>())
            {
                gameObject.GetComponent<zombie>().hight();
            }



        }
        
        if (gameObject.GetComponent<datatic2>() && DateTime.Now.Hour != 1)
        {
            if (gameObject.GetComponent<datatic2>().delux == "3")
            {
                Destroy(gameObject);
            }
        }
        time = DateTime.Now.Hour;
    }

    // Update is called once per frame
    void Update()
    {
        if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 3 || Directory.Exists("debug/hight"))
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>().Length != 0)
            {
                for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
                {


                    GameObject.FindObjectsOfType<PlayerAnime>()[i].s33s();
                }
            }
        }
    }
}
