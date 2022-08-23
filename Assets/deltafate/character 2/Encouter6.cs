using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Encouter6 : MonoBehaviour
{

    public modefikatoreffects effect = new modefikatoreffects();
    public GameObject player;

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
    public int hp = 600;
    public int mp = 12;
    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public battlesave s = new battlesave();
    public save s1 = new save();
    public save s3 = new save();
    public items s2 = new items();
    public items s4 = new items();
    public int rand = 0;
    public bool random = false;
    public GameObject player2;
    public string sp2;
    public int index;
    public string[] sp2s;
    public int[] indexs;
    void Start()
    {
        if (Directory.Exists("debug"))
        {
            Vector5 n = new Vector5();
            n.x = hp;
            n.y = mp;
            n.w = tic2;
            n.z = time2;
            n.h = tic;
            Vector5 n2 = new Vector5();
            n2.x = Type;
            n2.y = time;




            File.WriteAllText("debug" + gameObject.name, v5json.v5tostring(n));
            File.WriteAllText("debug" + gameObject.name + "887", v5json.v5tostring(n2));
        }
        if (File.Exists(@"DELTAFATE/mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

        }
        if (File.Exists(@"mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

        }
        if (File.Exists("res/" + sp2 + "_" + index + ".un"))
        {



            GetComponent<SpriteRenderer>().sprite = records2.spritest2(sp2s[0], indexs[0], GetComponent<SpriteRenderer>().sprite);

            debugEncouter sf = new debugEncouter();
            sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/" + sp2 + "_" + index + ".un"));
            hp = sf.hp;
            mp = sf.mp;
            time = Mathf.FloorToInt(sf.tic);
            time2 = Mathf.FloorToInt(sf.tic2);

        }
        if (int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) >= -10)
        {


            hp += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) / 20;
        }
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
        {
            s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));
            Debug.Log("1");


        }
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s4 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));
            Debug.Log("1");


        }
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s3 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/position.un"));
            Debug.Log("1");


        }
        PlayerPrefs.SetInt("TTN", 0);
        PlayerPrefs.SetInt("teni", 0);
        PlayerPrefs.SetInt("t44", 0);
        hp = s3.level/ 5;
        hp += 110;
        mp = s3.level / 110;
        mp += 11;
        int f = 0;
        for (int i = 0; i< s4.itemid.Count;i++)
        {
            //  s4.itemid[i]
            if (guns.IDdamage[s4.itemid[i]] > f)
            {
                f = guns.IDdamage[s4.itemid[i]];
            }
        }
        time -= f * 10;
        time2 += f / 200;
        if (PlayerPrefs.GetInt("dif", 0) >= 1)
        {
            time /= 2;
            time2 *= 2;
        }
        if (PlayerPrefs.GetInt("dif", 0) >= 2)
        {
            time /= 2;
            time2 *= 2;
        }
        if (PlayerPrefs.GetInt("dif", 0) >= 3)
        {
            hp *= 2;
            
        }
    }
    public debugEncouter d = new debugEncouter();
    // Update is called once per frame
    void Update()
    {
        if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.Z))
            {


                if (File.Exists("res/debug/debugEncouter.un"))
                {
                    records2.spritest("debug", 0, gameObject);
                    GetComponent<SpriteRenderer>().sprite = records2.spritest2(sp2s[0], indexs[0], GetComponent<SpriteRenderer>().sprite);
                    debugEncouter sf = new debugEncouter();
                    sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/debug/debugEncouter.un"));
                    hp = sf.hp;
                    mp = sf.mp;
                    time = Mathf.FloorToInt(sf.tic);
                    time2 = Mathf.FloorToInt(sf.tic2);

                }





            }
            if (Input.GetKeyDown(KeyCode.X))
            {


                if (File.Exists("res/debug/debugEncouter2.un"))
                {
                    records2.spritest("debug", 0, gameObject);
                    GetComponent<SpriteRenderer>().sprite = records2.spritest2(sp2s[0], indexs[0], GetComponent<SpriteRenderer>().sprite);
                    debugEncouter sf = new debugEncouter();
                    sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/debug/debugEncouter2.un"));
                    hp = sf.hp;
                    mp = sf.mp;
                    time = Mathf.FloorToInt(sf.tic);
                    time2 = Mathf.FloorToInt(sf.tic2);

                }





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
                    
                    player.GetComponent<igrok>().hp += effect.power[i];
                    if (player2)
                    {
                        player2.GetComponent<igrok1>().hp += effect.power[i];
                    }

                }
                if (PlayerPrefs.GetInt("command", 0) == 1)
                {
                   


                    if (hp <= 0 || mp <= 0)
                    {
                        if (Type == 1)
                        {
                            PlayerPrefs.SetInt("r1", 1);

                            PlayerPrefs.SetInt("c222", 1);
                        }
                        PlayerPrefs.SetFloat("attack", 0);
                        if (File.Exists(@"DELTAFATE/siji/bposition.un"))
                        {
                            
                                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));
                             
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                        PlayerPrefs.SetFloat("attack", 0);
                        player.GetComponent<igrok>().sheld -= 10;
                    }

                }
                player.GetComponent<igrok>().fight = true;
                PlayerPrefs.SetInt("command", 0);
            }

        }

        if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.R))
            {

                hp = 0;




            }
        }
        debugEncouter.updata(hp, mp, tic, tic2, attack, d);
        if (GameObject.FindObjectOfType<igrok1>())
        {
            player2 = GameObject.FindObjectOfType<igrok1>().gameObject;
        }
        if (player2)
        {


            if (player2.GetComponent<igrok1>().sheld <= 0)
            {
                player2.GetComponent<igrok1>().hp -= 30;
                player2.GetComponent<igrok1>().sheld = 100;
            }
        }
        if (player.GetComponent<igrok>().sheld <= 0)
        {
            player.GetComponent<igrok>().hp -= 30;
            player.GetComponent<igrok>().sheld = 100;
        }
        if (Type == 1)
        {
            Time.timeScale = 2;


        }
        if (random == true)
        {
            rand = Random.Range(0, 2);
        }


        
                    if (PlayerPrefs.GetInt("command", 0) == 4)
                    {

                        battlesave bs = new battlesave();






                        bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/bposition.un"));
                        bs.isdead = true;
                        File.WriteAllText(@"DELTAFATE/bposition.un", JsonUtility.ToJson(bs));
                        PlayerPrefs.SetInt("command", 0);
                        SceneManager.LoadScene(bs.idscene[0]);

                    }
                


        if (PlayerPrefs.GetInt("command", 0) == 5 && hp <= 40)
        {
            if (player2)
            {
                player2.GetComponent<igrok1>().sheld -= 10;
            }
            if (player.GetComponent<igrok>().playcharacter == 1)
            {


                hp -= 3;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
            if (player.GetComponent<igrok>().playcharacter == 0)
            {

                hp -= 1;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
        }
        if (PlayerPrefs.GetInt("command1", 0) == 1)
        {
            player.GetComponent<igrok>().sheld -= 10; 
            if (player2)
            {
                player2.GetComponent<igrok1>().sheld -= 10;
            }
            player.GetComponent<igrok>().fight = true;

            mp -= 10;
            PlayerPrefs.SetInt("command", 0); 
            PlayerPrefs.SetInt("command1", 0);
            player.GetComponent<igrok>().fight = true;
            

            
        }

        if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            if (player2)
            {
                player2.GetComponent<igrok1>().sheld -= 10;
            }
            player.GetComponent<igrok>().sheld -= 10;
            Debug.Log("1");
            int f = 0;
            if (PlayerPrefs.GetInt("1", 0) == 0)
            {
                if (PlayerPrefs.GetInt("r1", 0) == 1)
                {
                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                        {
                            f = s2.itemid[i];
                            s2.patrons[f] -= 1;
                            f = s2.itemid[i];
                            hp -= guns33.IDdamage[f] * Random.Range(1, 2);
                            Debug.Log("damage " + guns33.IDdamage[f].ToString());
                        }
                    }
                }
            }
            if (PlayerPrefs.GetInt("1", 0) == 0)
            {
                if (PlayerPrefs.GetInt("r1", 0) == 0)
                {
                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                        {
                            f = s2.itemid[i];
                            s2.patrons[f] -= 1;
                            f = s2.itemid[i];
                            hp -= guns33.IDdamage[f] * Random.Range(1, 2);
                            Debug.Log("damage " + guns33.IDdamage[f].ToString());
                        }
                    }
                }
            }
            if (PlayerPrefs.GetInt("1", 0) == 1)
            {
                if (PlayerPrefs.GetInt("r1", 0) == 1)
                {
                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                        {
                            f = s2.itemid[i];
                            s2.patrons[f] -= 1;
                            f = s2.itemid[i];
                            hp -= guns33.IDdamage[f] * Random.Range(2, 4);
                            Debug.Log("damage " + guns33.IDdamage[f].ToString());
                        }
                    }
                }
            }
            if (player.GetComponent<igrok>().playcharacter == 1)
            {


                hp -= 8;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
            if (player.GetComponent<igrok>().playcharacter == 0)
            {
                hp -= 5;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
        }



        if (PlayerPrefs.GetInt("command", 0) == 1)
        {
            if (hp <= 0 || mp <= 0)
            {
                if (Type == 1)
                {
                    PlayerPrefs.SetInt("r1", 1);

                    PlayerPrefs.SetInt("c222", 1);
                }
                PlayerPrefs.SetFloat("attack", 0);
                if (File.Exists(@"DELTAFATE/siji/bposition.un"))
                {

                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));

                    SceneManager.LoadScene(s.idscene[0]);
                }
                PlayerPrefs.SetFloat("attack", 0);
                player.GetComponent<igrok>().sheld -= 10;
            }
        }

        
        if (player.GetComponent<igrok>().reynor == false)
        {
            if (hp <= 0 || mp <= 0)
            {
                if (Type == 1)
                {
                    PlayerPrefs.SetInt("r1", 1);


                    if (PlayerPrefs.GetInt("r1", 0)== 1)
                    {

                        PlayerPrefs.SetInt("c222", 1);
                        PlayerPrefs.SetFloat("attack", 0);
                        if (File.Exists(@"DELTAFATE/siji/inventory.un"))
                        {
                            s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/siji/inventory.un"));
                            s2.itemid.Add(3);
                            File.WriteAllText(@"DELTAFATE/siji/inventory.un", JsonUtility.ToJson(s2));

                        }
                        if (File.Exists(@"DELTAFATE/siji/bposition.un"))
                        {

                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));

                            
                        
                        s.level += 224;
                            File.WriteAllText(@"DELTAFATE/siji/bposition.un", JsonUtility.ToJson(s));
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }
                if (Type == 0)
                {


                    PlayerPrefs.SetInt("c222", 1);

                    PlayerPrefs.SetFloat("attack", 0);
                    if (File.Exists(@"DELTAFATE/siji/inventory.un"))
                    {
                        s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/siji/inventory.un"));
                        s2.itemid.Add(3);
                        File.WriteAllText(@"DELTAFATE/siji/inventory.un", JsonUtility.ToJson(s2));

                    }
                    if (File.Exists(@"DELTAFATE/siji/bposition.un"))
                    {
                        
                                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));
                         
                        s.level += 224;
                        File.WriteAllText(@"DELTAFATE/siji/bposition.un", JsonUtility.ToJson(s));
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }

            }
        }        
            tic += 1 * 60 * Time.deltaTime;
            tic2 += 1 * 60 * Time.deltaTime;

        if (mp >= 1)
        {

            if (attack >= 0)
            {
                if (tic >= time)
                {
                    if (player.GetComponent<igrok>().fight == true)
                    {


                        if (tic >= time)
                        {



                            Instantiate(obj1[0], position[Random.Range(0, position.Length)]);
                            tic = 0;

                        }

                        random = true;
                        tic = 0;
                    }
                }
            }
           
            if (attack >= 3)
            {
                attack = 0;
                attack1 = 1;
            }

        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (PlayerPrefs.GetInt("command", 0) == 3)
            {
                PlayerPrefs.SetInt("command", 0);
            }
        }

        if (tic2 >= time2)
        {
            if (attack <= 2)
            {
                if (attack1 == 0)
                {


                    attack += 1;
                }
                if (attack1 == 1)
                {


                    attack = Random.Range(0, 3);
                }
            }
            PlayerPrefs.SetInt("command", 0);
            PlayerPrefs.SetInt("command1", 0);
            player.GetComponent<igrok>().fight = false;
            tic2 = 0;
            
            player.GetComponent<igrok>().fight = false;
            

        }
    }
}
