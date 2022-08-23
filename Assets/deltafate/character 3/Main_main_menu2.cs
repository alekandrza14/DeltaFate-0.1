using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Main_main_menu2 : MonoBehaviour
{
    public int cur;
    public int cur1;
    public Text[] txt; 
    public Color[] cl;
    
    
    public GameObject[] player;
    public bool fight;


    // Start is called before the first frame update


    // Start is called before the first frame update

    public string varible;
    public int voule;
    public igrok2 i;
    public int i2;
    
        
    
    void Start()
    {
        for (int i = 0; i < player.Length && timeset.batleintrig == 1; i++)
        {
            
            player[i].GetComponent<igrok2>().hp = timeset.hp[i];
        }
            i = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)].GetComponent<igrok2>();
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
        if (Input.GetKeyDown(KeyCode.Q))
        {


            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
            {
                i2 = 0;
            }
            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();

            i.fight = true;
        }

        for (int i = 0; i < player.Length; i++) 
        {
            
            if (player[i].GetComponent<igrok2>().ss == true)
            {


                player[i].GetComponent<SpriteRenderer>().color = new Color (0,0,0,0);
            }
        }


        if (player.Length != 4)
        {
            if (player[0].GetComponent<igrok2>().fight && player[1].GetComponent<igrok2>().fight && player[2].GetComponent<igrok2>().fight)
            {
                fight = true;
            }
            if (!player[0].GetComponent<igrok2>().fight || !player[1].GetComponent<igrok2>().fight || !player[2].GetComponent<igrok2>().fight)
            {
                fight = false;
            }
        }
        if (player.Length == 4)
        {
            if (player[0].GetComponent<igrok2>().fight && player[1].GetComponent<igrok2>().fight && player[2].GetComponent<igrok2>().fight && player[3].GetComponent<igrok2>().fight)
            {
                fight = true;
            }
            if (!player[0].GetComponent<igrok2>().fight || !player[1].GetComponent<igrok2>().fight || !player[2].GetComponent<igrok2>().fight || !player[3].GetComponent<igrok2>().fight)
            {
                fight = false;
            }
        }

        if (fight == false)
        {
            


            if (fight == false)
            {
                if (PlayerPrefs.GetInt("command", 0) != 3)
                {





                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        if (cur > -1 && cur < txt.Length - 1)
                        {
                            cur++;
                        }
                    }
                    if (PlayerPrefs.GetInt("r1", 0) == 1)
                    {
                        if (Input.GetKeyDown(KeyCode.Q))
                        {


                            if (cur1 > -1 && cur < player.Length - 1)
                            {
                                cur1++;
                                swap();
                            }
                            if (cur1 < -1 && cur > player.Length - 1)
                            {
                                cur1 = 0;
                                swap();
                            }
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
                            i2++;

                            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
                            {
                                i2 = 0;
                            }
                            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();
                            if (player[i2].gameObject.GetComponent<igrok2>().fight != true)
                            {


                                PlayerPrefs.SetInt("command", 1);
                            }
                            i = player[i2].gameObject.GetComponent<igrok2>();
                                i.fight = true;
                                
                            
                           


                            


                        }
                    }
                    if (cur == 1)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            isanimend.attack = 1;
                            if (player[i2].gameObject.GetComponent<igrok2>().fight != true)
                            {
                                PlayerPrefs.SetInt("command", 2);
                            }
                            i = player[i2].gameObject.GetComponent<igrok2>();
                            i.fight = true;
                            

                            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();
                            

                            i2++;

                            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
                            {
                                i2 = 0;
                            }


                            

                        }
                    }


                    if (cur == 2)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {

                            PlayerPrefs.SetInt("command", 3);


                        }
                    }

                    if (cur == 3)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            i2++;

                            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
                            {
                                i2 = 0;
                            }
                            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();
                            if (player[i2].gameObject.GetComponent<igrok2>().fight != true)
                            {
                                PlayerPrefs.SetInt("command", 4);
                            }

                            

                            i = player[i2].gameObject.GetComponent<igrok2>();

                            i.fight = true;

                            


                        }
                    }
                    if (cur == 4)
                    {
                        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                        {
                            if (player[i2].gameObject.GetComponent<igrok2>().fight != true)
                            {
                                PlayerPrefs.SetInt("command", 5);
                            }
                            i = player[i2].gameObject.GetComponent<igrok2>();
                            i.fight = true;



                            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();
                            

                            i2++;

                            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
                            {
                                i2 = 0;
                            }


                        }

                    }
                
                   

                }
            }
        }
        else
        {
            for (int i = 0; i < txt.Length; i++)
            {

                txt[i].color = new Color(0, 0, 0, 0);
                
            }
        }
    }
    public void swap()
    {

        if (cur1 == 0)
        {
            player[cur1].GetComponent<igrok>().playcharacter = 0;

        }
        
        if (cur1 == 1)
        {
            player[cur1].GetComponent<igrok>().playcharacter = 1;

        }
        if (cur1 == 2)
        {
            player[cur1].GetComponent<igrok>().playcharacter = 2;

        }

    }
}
