using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class god : MonoBehaviour
{


    public modefikatoreffects effect = new modefikatoreffects();
    public GameObject playerilst;
    public Transform[] position;
    public GameObject obj;
    public Transform[] position3;
    public GameObject obj3;
    public Transform[] position4;
    public GameObject obj4;
    public Transform[] position5;
    public GameObject obj5;
    public Transform[] position6;
    public GameObject obj6;
    public Transform[] position1;
    public Transform[] position2;
    public GameObject[] obj1;

    public float tic;
    public float tic2;
    public int time = 20;
    public int time2 = 800; 
    public int time3 = 400;
    public int hp = 1000000;
    public int mp = int.MaxValue;
    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public save s = new save();
    public save s1 = new save();
    public items s2 = new items();
    public items s3 = new items();
    public int rand = 0;
    public bool random = false;
    public string charakter;
    public Sprite sp;
    public Sprite sp2;
    public Sprite[] sp3;
    public ATTACK attack_1;
    public bool isfell;
    public bool rescord;
    public debugEncouter sf;
    
    void Start()
    {
        if (File.Exists(@"DELTAFATE/unauticna/seed.un"))
        {
            if (int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) >= -10)
            {


                hp += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) / 20;
            }
        }
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));
            Debug.Log("1");


        }
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
        {
            s3 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));
            Debug.Log("2");


        }
        PlayerPrefs.SetInt("TTN", 0);
        PlayerPrefs.SetInt("teni", 0);
        PlayerPrefs.SetInt("t44", 0);
        if (PlayerPrefs.GetInt("dif", 0) >= 1)
        {
            time /= 2;
            time2 *= 2;
        }
        if (PlayerPrefs.GetInt("dif", 0) >= 2)
        {
            time /= 5;
            time2 *= 5;
        }
        if (File.Exists(@"mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

        }
        if (PlayerPrefs.GetInt("dif", 0) >= 3)
        {
            if (attack1 == 2)
            {


                isfell = true;

            }
            hp *= 2;
            time *= 5;
            time2 /= 5;
        }
        
            if (File.Exists("res/god.un"))
            {
                sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/god.un"));
                hp = sf.hp;
                mp = int.MaxValue;
                time = Mathf.FloorToInt(sf.tic);
                time2 = Mathf.FloorToInt(sf.tic2);
            }
        
    }
    public debugEncouter d = new debugEncouter();
    // Update is called once per frame
    void Update()
    {

        if (isfell)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sp3[2];
            sp = sp3[0];
            sp2 = sp3[1];
        }
        if (Directory.Exists("debug"))
        {

            

        }
        if (Directory.Exists("debug"))
        {

            

        }
        if (Directory.Exists("debug"))
        {

            
        }
        debugEncouter.updata(hp, mp, tic, tic2, attack, d);
        if (Type == 2)
        {
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                {
                    
                }
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                {
                    
                }
            }
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                {
                    
                }
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                {
                    
                }
            }
        }
        if (PlayerPrefs.GetInt("command1", 0) == 1)
        {



            mp -= 10;
            PlayerPrefs.SetInt("command", 0);
            PlayerPrefs.SetInt("command1", 0);
            playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
            playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
            playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



        }
        if (Type == 2)
        {
            if (PlayerPrefs.GetInt("command1", 0) == 2)
            {



                mp += 10;
                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



            }
            if (PlayerPrefs.GetInt("command1", 0) == 3)
            {
                if (PlayerPrefs.GetInt("dif", 0) <= 1)
                {
                    
                    playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().hp += 10;
                }

                mp -= 100;
                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



            }
        }
        if (PlayerPrefs.GetInt("command", 0) == 1)
        {

            for (int i = 0; i < effect.ideffect.Count; i++)
            {



                if (effect.ideffect[i] == "damage")
                {
                    hp -= effect.power[i];
                }
                if (effect.ideffect[i] == "hill")
                {
                    hp -= effect.power[i];
                }


            }


        }
        if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            hp -= 8;
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (Type == 2)
                {
                   
                }

            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                if (Type == 2)
                {
                    
                }

            }
            Debug.Log("s");
            if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s2.itemid.Count; i++)
                {
                    if (s2.itemid[i] >= f)
                    {
                        f = s2.itemid[i];
                        hp -= guns.IDdamage[f] * Random.Range(1, 2);
                        Debug.Log("damage " + guns.IDdamage[f].ToString());
                    }
                }


                
                
                

            }
            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s3.itemid.Count; i++)
                {
                    if (s3.itemid[i] >= f)
                    {
                        f = s3.itemid[i];
                        hp -= guns33.IDdamage[f] * Random.Range(1, 2);
                        Debug.Log("damage " + guns33.IDdamage[f].ToString());
                    }
                }


                
                
                

            }
            
            PlayerPrefs.SetInt("command", 0);
            
        }
        if (Type == 1)
        {
            Time.timeScale = 2;


        }

        if (playerilst.GetComponent<Main_main_menu2>().fight == true)
        {
            if (PlayerPrefs.GetInt("command", 0) == 2)
            {
                hp -= 8;
                if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
                {
                    Debug.Log("1");
                    int f = 0;

                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f)
                        {
                            f = s2.itemid[i];
                            hp -= guns.IDdamage[f] * Random.Range(1, 2);
                            Debug.Log("damage " + guns.IDdamage[f].ToString());
                        }
                    }



                    PlayerPrefs.SetInt("command", 0);


                }
                if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
                {
                    Debug.Log("1");
                    int f = 0;

                    for (int i = 0; i < s3.itemid.Count; i++)
                    {
                        if (s3.itemid[i] >= f)
                        {
                            f = s3.itemid[i];
                            hp -= guns33.IDdamage[f] * Random.Range(1, 2);
                            Debug.Log("damage " + guns33.IDdamage[f].ToString());
                        }
                    }



                    PlayerPrefs.SetInt("command", 0);


                }
                hp -= 5;
            }
            if (PlayerPrefs.GetInt("command", 0) == 4)
            {

                if (PlayerPrefs.GetString("ch", "henry") == "henry")
                {
                    if (File.Exists(@"DELTAFATE/henry1/position.un"))
                    {

                        
                        
                        s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));
                        s.enter[s.idscene] = false;
                        File.WriteAllText(@"DELTAFATE/henry1/position.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetInt("command", 0);
                        SceneManager.LoadScene(s.idscene);
                    }
                }
                if (PlayerPrefs.GetString("ch", "henry") == "siji")
                {
                    if (File.Exists(@"DELTAFATE/siji0/position.un"))
                    {
                        
                        
                        s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji0/position.un"));
                        s.enter[s.idscene] = false;
                        File.WriteAllText(@"DELTAFATE/siji0/position.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetInt("command", 0);
                        SceneManager.LoadScene(s.idscene);
                    }
                }

            }



            if (PlayerPrefs.GetInt("command", 0) == 5)
            {
                hp -= 40;
                if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
                {
                    int f = 0;
                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f)
                        {
                            f = s2.itemid[i];
                            for (int x = 0; x < guns.IDcountdamage[f]; x++)
                            {
                                hp -= guns.IDdamagemagic[f] * Random.Range(1, 2);
                            }
                            Debug.Log("damage " + guns.IDdamagemagic[f].ToString());
                        }
                    }
                }
                if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
                {
                    int f = 0;
                    for (int i = 0; i < s3.itemid.Count; i++)
                    {
                        if (s3.itemid[i] >= f)
                        {
                            f = s3.itemid[i];
                            
                            hp -= guns33.IDdamagemagic[f] * Random.Range(1, 2);
                            
                            Debug.Log("damage " + guns33.IDdamagemagic[f].ToString());
                        }
                    }
                }
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;
                PlayerPrefs.SetInt("command", 0);
            }
            if (PlayerPrefs.GetInt("command1", 0) == 1)
            {



                mp -= 10;
                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;
                if (PlayerPrefs.GetInt("r1", 0) != 1)
                {
                    playerilst.GetComponent<Main_main_menu2>().fight = true;
                }



            }


            



            if (PlayerPrefs.GetInt("command", 0) == 1)
            {

               
            }
        }
        if (hp <= 0 && hp > -99999)
        {
           
            
            PlayerPrefs.SetFloat("attack", 0);
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (File.Exists(@"DELTAFATE/henry1/position.un"))
                {
                    
                    
                    s.level += 0;
                    s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));
                    PlayerPrefs.SetInt("command", 0);
                    File.WriteAllText(@"DELTAFATE/henry1/position.un", JsonUtility.ToJson(s));
                    SceneManager.LoadScene(s.idscene);
                }
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                if (File.Exists(@"DELTAFATE/siji0/position.un"))
                {
                    
                    s.level += 0;
                    s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji0/position.un"));
                    PlayerPrefs.SetInt("command", 0);
                    File.WriteAllText(@"DELTAFATE/siji0/position.un", JsonUtility.ToJson(s));
                    SceneManager.LoadScene(s.idscene);
                }
            }
            PlayerPrefs.SetFloat("attack", 0);

        }

        tic += 1 * 60 * Time.deltaTime;
            tic2 += 1 * 60 * Time.deltaTime;
        
            
            if (mp >= 1)
            {

                if (attack == 0)
                {
                    if (tic >= time)
                    {
                        if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                        {


                            if (tic >= time)
                            {
                                for (int i = 2; i > 0; i--)
                                {



                                    Instantiate(obj1[0], position[Random.Range(0, position.Length)]);
                                }
                                tic = 0;

                            }

                            random = true;
                            tic = 0;
                        }
                    }
                }
                if (Type == 1)
                {


                    if (attack == 1)
                    {
                        if (tic >= time)
                        {
                            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                            {


                                if (tic >= attack_1.speedphase1)
                                {
                                    for (int i = 2; i > 0; i--)
                                    {



                                        Instantiate(attack_1.gameobjphase1.gameObject, position[Random.Range(0, position.Length)]);
                                    }
                                    tic = 0;

                                }

                                random = true;
                                tic = 0;
                            }
                        }
                    }
                    if (attack == 2)
                    {
                        if (tic >= time)
                        {
                            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                            {


                                if (tic >= attack_1.speedphase2)
                                {
                                    for (int i = 2; i > 0; i--)
                                    {



                                        Instantiate(attack_1.gameobjphase2.gameObject, position[Random.Range(0, position.Length)]);
                                    }
                                    tic = 0;

                                }

                                random = true;
                                tic = 0;
                            }
                        }
                    }
                    if (attack == 3)
                    {
                        if (tic >= attack_1.speedphase3)
                        {
                            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                            {


                                if (tic >= time)
                                {
                                    for (int i = 2; i > 0; i--)
                                    {



                                        Instantiate(attack_1.gameobjphase3.gameObject, position[Random.Range(0, position.Length)]);
                                    }
                                    tic = 0;

                                }

                                random = true;
                                tic = 0;
                            }
                        }
                    }
                }




            }
        
        if (playerilst.GetComponent<Main_main_menu2>().fight == true)
        {
            if (PlayerPrefs.GetInt("command", 0) == 3)
            {
                PlayerPrefs.SetInt("command", 0);
            }
        }

        if (tic2 >= time2)
        {
            if (mp < 0)
            {
               
            }
            if (hp < -99999)
            {
                
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));
                s.level += 22400;
                File.WriteAllText(@"DELTAFATE/henry1/position.un", JsonUtility.ToJson(s));
                PlayerPrefs.SetFloat("attack", 0);
                SceneManager.LoadScene(s.idscene);
            }
            if (random == true)
            {

            }
                if (Type == 0)
                {
                    
                    
                }
                if (Type == 1)
                {
                    if (attack <= 3)
                    {
                        if (attack1 == 0)
                        {


                            attack += 1;

                        }
                        
                    }
                    if (attack > 3)
                    {

                        attack1 = 1;
                        
                    }
                if (attack1 == 1)
                {


                    attack = Random.Range(0, 4);
                }
            }

                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = false; 
            playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = false;
            playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = false;
            tic2 = 0;
            
            
            

        }
    }
    
}

