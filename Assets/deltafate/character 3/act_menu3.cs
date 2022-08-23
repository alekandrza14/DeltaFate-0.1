using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class act_menu3 : MonoBehaviour
{
    public int cur;
    public Text[] txt; 
    public Color[] cl;
    public int id;
    public string slot;
    public GameObject player;
    public int t;

    // Start is called before the first frame update
    

    // Start is called before the first frame update
    void Start()
    {
        cur = 4;
        t = 2;
        if (PlayerPrefs.GetInt("ling", 0) == 1)
        {

            txt[4].text = "exit";
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("command", 0) != 3)
        {
            for (int i = 0; i < txt.Length; i++)
            {

                txt[i].color = Color.black;

            }
        }
        if (PlayerPrefs.GetInt("command", 0) == 3)
        {
            if (player.GetComponent<Main_main_menu2>().fight == false)
            {

                if (PlayerPrefs.GetInt("command", 0) != 3)
                {
                    for (int i = 0; i < txt.Length; i++)
                    {

                        txt[i].color = Color.black;

                    }
                }
                if (PlayerPrefs.GetInt("command", 0) == 3)
                {





                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        if (cur > -1 && cur < txt.Length - 1)
                        {
                            cur++;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        if (cur > 0 && cur < txt.Length)
                        {
                            cur--;
                        }
                    }
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (i != cur)
                        {
                            txt[i].color = cl[0];
                        }
                        if (i == cur)
                        {
                            txt[i].color = cl[1];
                        }
                    }

                    if (cur == 0)
                    {

                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            t++;
                            if (t > 1)
                            {
                                PlayerPrefs.SetInt("command1", 1);
                                t = 0;
                            }

                        }
                    }
                    if (cur == 1)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            t++;
                            if (t > 1)
                            {
                                PlayerPrefs.SetInt("command1", 2);
                                t = 0;
                            }

                        }
                    }
                    if (cur == 2)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            t++;
                            if (t > 1)
                            {
                                PlayerPrefs.SetInt("command1", 3);
                                t = 0;
                            }

                        }
                    }
                    if (cur == 3)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            t++;
                            if (t > 1)
                            {
                                PlayerPrefs.SetInt("command1", 4);
                                t = 0;
                            }
                        }
                    }
                    if (cur == 4)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            t++;
                            if (t > 1)
                            {

                                t = 0;
                                cur = 4;
                                PlayerPrefs.SetInt("command1", 0);
                                PlayerPrefs.SetInt("command", 0);
                            }

                        }
                    }
                }

            }




        }
    }
}
