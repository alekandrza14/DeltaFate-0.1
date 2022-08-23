using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Main_main_menu1 : MonoBehaviour
{
    public int cur;
    public int cur1;
    public Text[] txt; 
    public Color[] cl;
    public int id;
    public string slot;
    public GameObject player;
    public bool sans;

    // Start is called before the first frame update
    

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("ling", 0) == 1)
        {

            txt[0].text = "spare";

            txt[1].text = "attack";

            txt[2].text = "act";

            txt[3].text = "flee";

            txt[4].text = "magick";
        }
        if (PlayerPrefs.GetInt("ling", 0) == 2)
        {

            txt[0].text = "АААГОНЬ";

            txt[1].text = "miggh";

            txt[2].text = "<<ня";

            txt[3].text = "flee-бля";

            txt[4].text = "vv^^xx█-<<ня";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("end_dialog",0) != 1)
        {
            


            if (player.GetComponent<igrok>().fight == false)
            {
                if (PlayerPrefs.GetInt("command", 0) != 3)
                {





                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        if (cur > -1 && cur < txt.Length -1)
                        {
                            cur++;
                        }
                    }
                    if (PlayerPrefs.GetInt("r", 0) == 1)
                    {
                        if (Input.GetKeyDown(KeyCode.Q))
                        {
                            swap();
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
                    
                    if (cur == 0 && cur1 == 0)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 1);
                        }
                    }
                    if (cur == 1 && cur1 == 0)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 2);
                            isanimend.attack = 1;
                        }
                    }
                    if (cur == 1 && cur1 == 1)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 2);
                            PlayerPrefs.SetInt("r69", 3);
                            isanimend.attack = 1;
                        }
                    }
                    if (cur == 2 && cur1 == 0)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 3);
                        }
                    }
                    if (cur == 2 && cur1 == 1)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            PlayerPrefs.SetInt("command", 3);
                        }
                    }
                    if (cur == 3 && cur1 == 0)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 4);
                        }
                    }
                    if (cur == 3 && cur1 == 1)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 4);
                        }
                    }
                    if (cur == 4 && cur1 == 1)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 5);
                        }
                    }
                    if (cur == 4 && cur1 == 0)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            PlayerPrefs.SetInt("command", 5);
                        }
                    }

                }
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {

                txt[i].color = new Color(0, 0, 0, 0);
                
            }
        }
    }
    public void swap()
    {
        if (sans == false)
        {


            bool g = false;
            if (cur1 == 0 || cur1 < 1)
            {
                cur1++;
                g = true;
            }
            if (!g)
            {



                cur1 = 0;

            }
            if (cur1 == 0)
            {
                player.GetComponent<igrok>().playcharacter = 0;

            }
            if (cur1 == 1)
            {
                player.GetComponent<igrok>().playcharacter = 1;

            }
        }
    }
}
