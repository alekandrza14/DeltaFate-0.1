using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class timeset
{
    public static int batleintrig = 0;
    public static int[] hp;
}
public class setupteam
{
   static teamsave ts = new teamsave();
    public static bool itsiji;
    public static bool itreynor;
    public static bool itsarux;
    public static bool ithenry;
    public static void start(){
    if (File.Exists("DELTAFATE/var/team.json"))
    {

            ts = JsonUtility.FromJson<teamsave>(File.ReadAllText("DELTAFATE/var/team.json"));
            for (int x = 0; x < ts.team.Count; x++)
            {
                if (ts.team[x] == "siji")
                {
                    itsiji = true;
                }
                if (ts.team[x] == "reynor")
                {
                    itreynor = true;
                }
                if (ts.team[x] == "sarux")
                {
                    itsarux = true;
                }
                if (ts.team[x] == "henry")
                {
                    ithenry = true;
                }

            }

           

    }
  }
}

public class Encouter7 : MonoBehaviour
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
    public int hp = 600;
    public int mp = 12;
    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public battlesave s = new battlesave();
    public save s1 = new save();
    public items s2 = new items();
    public items s3 = new items();
    public int rand = 0;
    public bool random = false;
    public string charakter;
    public string capter;
    public Sprite sp;
    public Sprite sp2;
    public Sprite[] sp3;
    public ATTACK attack_1;
    public bool isfell;
    public bool rescord;
    public int count = 1;
    public string sp4;
    public int index;
    public string[] sp2s;
    public int[] indexs;
    public debugEncouter sf;
    public int setscene = -1;
    
    public int idenc;
    void Start()
    {
        if (mp <= 0)
        {
            time2 = 200;
        }
        setupteam.start();
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
        if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
        {
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
            s1 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position" + s.idscene[0] / 150 + ".un"));
            hp += s1.hp / 20;

        }
        if (File.Exists("res/" + sp4 + "_" + index + ".un"))
        {
            records2.spritest(sp4, index, gameObject);
            sp3[0] = records2.spritest2(sp2s[0], indexs[0], sp3[0]);
            sp3[1] = records2.spritest2(sp2s[1], indexs[1], sp3[1]);
            sp = records2.spritest2(sp2s[3], indexs[3], sp);
            sp2 = records2.spritest2(sp2s[4], indexs[4], sp2);
            sp3[2] = records2.spritest2(sp2s[2], indexs[2], sp3[2]);
            debugEncouter sf = new debugEncouter();
            sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/" + sp4 + "_" + index + ".un"));
            hp = sf.hp;
            mp = sf.mp;
            time = Mathf.FloorToInt(sf.tic);
            time2 = Mathf.FloorToInt(sf.tic2);
            count = sf.count;
        }
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
            time /= 2;
            time2 *= 2;
        }
        if (File.Exists(@"DELTAFATE/mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

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
            
        }
        if (rescord)
        {
            if (File.Exists("res/rescord.un"))
            {
                sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/rescord.un"));
                hp = sf.hp;
                mp = sf.mp;
                time = Mathf.FloorToInt(sf.tic);
                time2 = Mathf.FloorToInt(sf.tic2);
            }
        }
        difficuteCustomEncouter customEncouter = new difficuteCustomEncouter();
        if (File.Exists("mods/dif/main"))
        {
            DirectoryInfo di = new DirectoryInfo("mods/difficute");
            FileInfo f;
            f = di.GetFiles()[int.Parse(File.ReadAllText("mods/dif/main"))];
            customEncouter = JsonUtility.FromJson<difficuteCustomEncouter>(File.ReadAllText(f.FullName));
            

                if (customEncouter.hp.Length >= idenc)
                {


                    hp = customEncouter.hp[idenc];
                }
                if (customEncouter.mp.Length >= idenc)
                {


                    mp = customEncouter.mp[idenc];
                }
                if (customEncouter.tic.Length >= idenc)
                {
                    time = Mathf.FloorToInt(customEncouter.tic[idenc]);
                }
                if (customEncouter.tic2.Length >= idenc)
                {
                    time2 = Mathf.FloorToInt(customEncouter.tic2[idenc]);
                }
                if (customEncouter.count.Length >= idenc)
                {
                    count = customEncouter.count[idenc];
                }
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

        }
    }
    public debugEncouter d = new debugEncouter();
    // Update is called once per frame
    void Update()
    {
        difficuteCustomEncouter customEncouter = new difficuteCustomEncouter();
        if (File.Exists("mods/dif/main") && File.Exists("debug"))
        {
            DirectoryInfo di = new DirectoryInfo("mods/difficute");
            FileInfo f;
            f = di.GetFiles()[int.Parse(File.ReadAllText("mods/dif/main"))];
            customEncouter = JsonUtility.FromJson<difficuteCustomEncouter>(File.ReadAllText(f.FullName));
            if (Input.GetKeyDown(customEncouter.key))
            {

                if (customEncouter.hp.Length >= idenc)
                {


                    hp = customEncouter.hp[idenc];
                }
                if (customEncouter.mp.Length >= idenc)
                {


                    mp = customEncouter.mp[idenc];
                }
                if (customEncouter.tic.Length >= idenc)
                {
                    time = Mathf.FloorToInt(customEncouter.tic[idenc]);
                }
                if (customEncouter.tic2.Length >= idenc)
                {
                    time2 = Mathf.FloorToInt(customEncouter.tic2[idenc]);
                }
                if (customEncouter.count.Length >= idenc)
                {
                    count = customEncouter.count[idenc];
                }
            }
        }
        if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.Z))
            {


                if (File.Exists("res/debug/debugEncouter.un"))
                {
                    records2.spritest("debug", 0, gameObject);
                    
                    debugEncouter sf = new debugEncouter();
                    sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/debug/debugEncouter.un"));
                    hp = sf.hp;
                    mp = sf.mp;
                    time = Mathf.FloorToInt(sf.tic);
                    time2 = Mathf.FloorToInt(sf.tic2);
                    count = sf.count;
                }





            }
            if (Input.GetKeyDown(KeyCode.X))
            {


                if (File.Exists("res/debug/debugEncouter2.un"))
                {
                    records2.spritest("debug", 0, gameObject);
                    
                    debugEncouter sf = new debugEncouter();
                    sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/debug/debugEncouter2.un"));
                    hp = sf.hp;
                    mp = sf.mp;
                    time = Mathf.FloorToInt(sf.tic);
                    time2 = Mathf.FloorToInt(sf.tic2);
                    count = sf.count;
                }





            }
        }
        if (isfell)
        {
            if (sp3.Length != 0)
            {


                gameObject.GetComponent<SpriteRenderer>().sprite = sp3[2];
                sp = sp3[0];
                sp2 = sp3[1];
            }
            }
            if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.R))
            {

                hp = 0;




            }
        }
        if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.T))
            {

                hp = -999999999;




            }
        }
        if (Directory.Exists("debug"))
        {

            if (Input.GetKeyDown(KeyCode.C))
            {

                mp = 0;




            }
        }
        debugEncouter.updata(hp, mp, tic, tic2, attack, d);
        if (Type == 2)
        {
            if (capter == "")
            {

                if (PlayerPrefs.GetString("ch", "henry") == "henry" && setupteam.ithenry)
                {
                    if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                    {
                        if (!isfell && sp != null)
                        {

                            gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                            hp -= 999999999;
                            time2 /= 20;
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));

                            PlayerPrefs.SetFloat("attack", 0);
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }
                if (PlayerPrefs.GetString("ch", "henry") == "siji" && setupteam.itsiji)
                {
                    if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                    {
                        if (!isfell && sp != null)
                        {

                            gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                            hp -= 999999999;
                            time2 /= 20;
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));

                            PlayerPrefs.SetFloat("attack", 0);
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }
                if (PlayerPrefs.GetString("ch", "henry") == "henry" && setupteam.ithenry)
                {
                    if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                    {
                        if (isfell && sp2 != null)
                        {

                            gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
                            hp -= 100;
                            time2 *= 2;
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));

                            PlayerPrefs.SetFloat("attack", 0);
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }
                if (PlayerPrefs.GetString("ch", "henry") == "siji" && setupteam.itsiji)
                {
                    if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                    {
                        if (isfell && sp2 != null)
                        {

                            gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
                            hp -= 100;
                            time2 *= 2;
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));

                            PlayerPrefs.SetFloat("attack", 0);
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }
            }

            if (capter == "5")
            {

                
                    if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
                    {
                        if (!isfell && sp != null)
                        {

                            gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                            hp -= 999999999;
                            time2 /= 20;
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));

                            PlayerPrefs.SetFloat("attack", 0);
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                    }
                }

            
        }
        if (Type == 7)
        {
            if (PlayerPrefs.GetInt("command1", 0) == 2)
            {




                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



            }
            if (PlayerPrefs.GetInt("command1", 0) == 3)
            {



                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



            }
            if (PlayerPrefs.GetInt("command1", 0) == 4)
            {

                if (Type == 7)
                {


                    PlayerPrefs.SetInt(charakter, 1);
                    PlayerPrefs.SetInt(charakter + "1", 1);

                }
                mp -= 1000;
                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;



            }
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
                    playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().hp += 10;
                    playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().hp += 10;
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
                    for (int x = 0; x < playerilst.GetComponent<Main_main_menu2>().player.Length; x++)
                    {
                        playerilst.GetComponent<Main_main_menu2>().player[x].GetComponent<igrok2>().hp += effect.power[i];
                    }
                }
            }
            if (hp <= 0 || mp <= 0)
            {
                if (charakter != "")
                {
                    if (Type == 1 && charakter == "au" && timeset.batleintrig == 1 && SceneManager.GetActiveScene().buildIndex != setscene)
                    {

                        PlayerPrefs.SetInt(charakter, 1);
                        timeset.batleintrig = -1;

                    }
                    if (Type == 1 && charakter != "au")
                    {


                        PlayerPrefs.SetInt(charakter, 1);

                    }
                    if (Type == 2 && charakter != "")
                    {


                        PlayerPrefs.SetInt(charakter, 1);

                    }
                    if (Type == 1 && charakter == "au" && timeset.batleintrig == 0)
                    {

                        timeset.hp = new int[playerilst.GetComponent<Main_main_menu2>().player.Length];
                        for (int i = 0; i < playerilst.GetComponent<Main_main_menu2>().player.Length; i++)
                        {
                            timeset.hp[i] = playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().hp;
                        }
                        timeset.batleintrig = 1;
                        

                    }
                }
                if (timeset.batleintrig == 0 || timeset.batleintrig == -1)
                {


                    PlayerPrefs.SetFloat("attack", 0);
                    if (capter == "")
                    {
                        Debug.Log("save");

                        if (PlayerPrefs.GetString("ch", "henry") == "henry" && setupteam.ithenry)
                        {
                            if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
                            {
                                PlayerPrefs.SetFloat("attack", 0);

                                s.level += 200;
                                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));

                                File.WriteAllText(@"DELTAFATE/henry1/bposition.un", JsonUtility.ToJson(s));
                                SceneManager.LoadScene(s.idscene[0]);
                            }
                        }
                        if (PlayerPrefs.GetString("ch", "henry") == "siji" && File.Exists(@"DELTAFATE/siji0/bposition.un") && setupteam.itsiji)
                        {
                            if (File.Exists(@"DELTAFATE/siji0/bposition.un"))
                            {
                                PlayerPrefs.SetFloat("attack", 0);
                                s.level += 200;
                                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));

                                File.WriteAllText(@"DELTAFATE/siji0/bposition.un", JsonUtility.ToJson(s));
                                SceneManager.LoadScene(s.idscene[0]);
                            }
                        }

                        PlayerPrefs.SetFloat("attack", 0);

                    }



                    if (capter == "5")
                    {


                        for (int i = 0; i < playerilst.GetComponent<Main_main_menu2>().player.Length; i++)
                        {
                            if (File.Exists(@"DELTAFATE/" + playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().nameing + "/bposition.un"))
                            {
                                if (File.Exists(@"DELTAFATE/" + playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().nameing + "/bposition.un"))
                                {
                                    PlayerPrefs.SetFloat("attack", 0);
                                    s.level += 200;
                                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().nameing + "/bposition.un"));

                                    File.WriteAllText(@"DELTAFATE/" + playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().nameing + "/bposition.un", JsonUtility.ToJson(s));
                                    SceneManager.LoadScene(s.idscene[0]);
                                }
                            }
                        }

                        PlayerPrefs.SetFloat("attack", 0);


                    }

                }
                if (timeset.batleintrig == 1)
                {
                    if (setscene != -1)
                    {


                        SceneManager.LoadScene(setscene);
                    }
                }


                    PlayerPrefs.SetInt("command", 0);



            }

        }
            if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            hp -= 8;
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (Type == 2)
                {
                    if (File.Exists(@"DELTAFATE/" + "henry1" + @"/bposition.un") && setupteam.ithenry)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
                    }
                    if (File.Exists(@"DELTAFATE/" + "henry1standart" + @"/bposition.un") && setupteam.ithenry)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                    }
                    if (s.level > 99999)
                    {
                        if (sp != null)
                        {


                            gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                        }
                        hp -= 999999999;
                        time2 /= 20;
                    }
                }
                if (Type == 3)
                {
                    if (sp2 != null)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
                    }
                        hp -= 9;
                }

            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                if (Type == 2)
                {
                    if (sp2 != null)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
                        hp -= 9;
                    }


                }
                if (Type == 3)
                {
                    if (sp2  != null)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
                        hp -= 9;



                    }
                }

            }
                    Debug.Log("s");
            if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && setupteam.ithenry)
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s2.itemid.Count; i++)
                {
                    if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                    {
                        f = s2.itemid[i];
                        s2.patrons[f] -= 1;
                        if (f == 10 || f == 6)
                        {
                            s2.patrons[f] -= 20;
                        }
                        hp -= guns.IDdamage[f] * Random.Range(1, 2);
                        Debug.Log("damage " + guns.IDdamage[f].ToString());
                    }
                }


                
                
                

            }
            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un") && setupteam.itsiji)
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
        if (PlayerPrefs.GetInt("command1", 0) == 1)
        {



            mp -= 10;
            PlayerPrefs.SetInt("command", 0);
            PlayerPrefs.SetInt("command1", 0);
            playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
            playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
            playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;

            playerilst.GetComponent<Main_main_menu2>().fight = true;




        }
        if (playerilst.GetComponent<Main_main_menu2>().fight == true)
        {
            if (PlayerPrefs.GetInt("command", 0) == 2)
            {
                hp -= 8;
                if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && setupteam.ithenry)
                {
                    Debug.Log("1");
                    int f = 0;

                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                        {
                            f = s2.itemid[i];
                            s2.patrons[f] -= 1;
                            hp -= guns.IDdamage[f] * Random.Range(1, 2);
                            Debug.Log("damage " + guns.IDdamage[f].ToString());
                        }
                    }



                    PlayerPrefs.SetInt("command", 0);


                }
                if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un") && setupteam.itsiji)
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

                battlesave bs = new battlesave();






                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/position.un"));
                bs.isdead = true;
                File.WriteAllText(@"DELTAFATE/position.un", JsonUtility.ToJson(bs));
                PlayerPrefs.SetInt("command", 0);
                SceneManager.LoadScene(bs.idscene[0]);

            }



            if (PlayerPrefs.GetInt("command", 0) == 5)
            {
                hp -= 40;
                if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && setupteam.ithenry)
                {
                    int f = 0;
                    for (int i = 0; i < s2.itemid.Count; i++)
                    {
                        if (guns.IDdamagemagic[i] >= f)
                        {
                            f = guns.IDdamagemagic[i];
                            for (int x = 0; x < guns.IDcountdamage[f]; x++)
                            {
                                mp -= guns.IDdamagemagic[f] * Random.Range(1, 2);
                                hp -= guns.IDdamagemagic[f] * Random.Range(1, 2);
                            }
                            Debug.Log("damage " + guns.IDdamagemagic[f].ToString());
                        }
                    }
                }
                if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un") && setupteam.itsiji)
                {
                    int f = 0;
                    for (int i = 0; i < s3.itemid.Count; i++)
                    {
                        if (guns33.IDdamagemagic[i] >= f)
                        {
                            f = guns33.IDdamagemagic[i];
                            
                            mp -= guns33.IDdamagemagic[f] * Random.Range(1, 2);
                            hp -= guns.IDdamagemagic[f] * Random.Range(1, 2);

                            Debug.Log("damage " + guns33.IDdamagemagic[f].ToString());
                        }
                    }
                }
                playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = true;
                playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = true;
                PlayerPrefs.SetInt("command", 0);
            }
            


            



            
            
            if (PlayerPrefs.GetInt("command", 0) == 1)
            {

                if (hp <= 0 || mp <= 0)
                {
                    if (timeset.batleintrig == 0 || timeset.batleintrig == -1)
                    {

                        if (charakter != "")
                        {
                            if (Type == 2)
                            {


                                PlayerPrefs.SetInt(charakter, 1);

                            }
                        }

                    }
                    PlayerPrefs.SetFloat("attack", 0);

                    PlayerPrefs.SetFloat("attack", 0);

                }
                PlayerPrefs.SetInt("command", 0);

            }
        }
        if (hp <= 0 && hp > -99999)
        {
            if (Type == 1 && charakter == "au" && timeset.batleintrig == 1 && SceneManager.GetActiveScene().buildIndex != setscene)
            {

                PlayerPrefs.SetInt(charakter, 1);
                timeset.batleintrig = -1;

            }
            if (Type == 1 && charakter == "au" && timeset.batleintrig == 0)
            {

                timeset.hp = new int[playerilst.GetComponent<Main_main_menu2>().player.Length];
                for (int i = 0; i < playerilst.GetComponent<Main_main_menu2>().player.Length; i++)
                {
                    timeset.hp[i] = playerilst.GetComponent<Main_main_menu2>().player[i].GetComponent<igrok2>().hp;
                }
                timeset.batleintrig = 1;


            }
            if (timeset.batleintrig == 1)
            {
                if (setscene != -1)
                {


                    SceneManager.LoadScene(setscene);
                }
            }
            if (timeset.batleintrig == 0 || timeset.batleintrig == -1)
            {

                if (File.Exists(@"DELTAFATE/siji/inventory.un") && setupteam.itsiji)
                {


                    File.WriteAllText(@"DELTAFATE/siji/inventory.un", JsonUtility.ToJson(s3));

                }
                if (File.Exists(@"DELTAFATE/henry/inventory.un") && setupteam.ithenry)
                {


                    File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(s2));

                }
                if (charakter != "")
                {


                    PlayerPrefs.SetInt(charakter + "1", 2);
                    PlayerPrefs.SetInt(charakter + "2", 2);
                }
                if (charakter == "au")
                {

                    if (PlayerPrefs.GetInt("dif", 0) == 3)
                    {
                        savevartous.setusvar(@"DELTAFATE/var/fellmodactive.int", false, 1);
                    }
                    PlayerPrefs.SetInt("chapter3end", 1);
                }

                PlayerPrefs.SetFloat("attack", 0);
                if (PlayerPrefs.GetString("ch", "henry") == "henry" && setupteam.ithenry)
                {
                    if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
                    {


                        s.level += 2000;
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
                        PlayerPrefs.SetInt("command", 0);
                        File.WriteAllText(@"DELTAFATE/henry1/bposition.un", JsonUtility.ToJson(s));
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }
                if (PlayerPrefs.GetString("ch", "henry") == "siji" && setupteam.itsiji)
                {
                    if (File.Exists(@"DELTAFATE/siji0/bposition.un"))
                    {

                        s.level += 2000;
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));
                        PlayerPrefs.SetInt("command", 0);
                        File.WriteAllText(@"DELTAFATE/siji0/bposition.un", JsonUtility.ToJson(s));
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }
                if (playerilst.GetComponent<Main_main_menu2>().i.GetComponent<igrok2>().chapter5 == 1)
                {
                    if (Type == 2)
                    {


                        PlayerPrefs.SetInt(charakter, 1);
                        PlayerPrefs.SetInt(charakter + "1", 1);

                    }
                    if (Type == 5)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                        s.level += 22400;
                        File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetFloat("attack", 0);
                        SceneManager.LoadScene(s.idscene[0]);
                    }

                    if (Type == 6)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                        s.level += 22400;
                        File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetFloat("attack", 0);
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                    if (Type == 0)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                        s.level += 22400;
                        File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetFloat("attack", 0);
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }
                    PlayerPrefs.SetFloat("attack", 0);

            }

        }

            tic += 1 * 60 * Time.deltaTime;
            tic2 += 1 * 60 * Time.deltaTime;
        if (hp > -99999)
        {
            
            if (mp >= 1)
            {

                if (attack == 0)
                {
                    if (charakter != "end")
                    {


                        if (tic >= time)
                        {
                            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                            {


                                if (tic >= time)
                                {
                                    for (int i = count; i > 0; i--)
                                    {



                                        Instantiate(obj1[Random.Range(0, obj1.Length)], position[Random.Range(0, position.Length)]);
                                    }
                                    tic = 0;

                                }

                                random = true;
                                tic = 0;
                            }
                        }

                    }
                    else
                    {


                        if (tic >= time)
                        {
                            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
                            {


                                if (tic >= time)
                                {
                                    for (int i = count; i > 0; i--)
                                    {



                                        Instantiate(obj1[0], position[Random.Range(0, position.Length)].position,Quaternion.identity);
                                    }
                                    tic = 0;

                                }

                                random = true;
                                tic = 0;
                            }
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
            if (timeset.batleintrig == 0 || timeset.batleintrig == -1)
            {
                if (sp != null)
                {


                    gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                }
                    if (mp < 0)
                {
                    if (Type == 3)
                    {


                        PlayerPrefs.SetInt(charakter, 1);
                        PlayerPrefs.SetInt(charakter + "2", 1);

                    }
                }
                if (hp < -99999 && playerilst.GetComponent<Main_main_menu2>().i.GetComponent<igrok2>().chapter5 != 1)
                {
                    if (Type == 2)
                    {


                        PlayerPrefs.SetInt(charakter, 1);
                        PlayerPrefs.SetInt(charakter + "1", 1);

                    }

                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
                    s.level += 22400;
                    File.WriteAllText(@"DELTAFATE/henry1/bposition.un", JsonUtility.ToJson(s));
                    PlayerPrefs.SetFloat("attack", 0);
                    SceneManager.LoadScene(s.idscene[0]);
                }
                if (hp < -99999 && playerilst.GetComponent<Main_main_menu2>().i.GetComponent<igrok2>().chapter5 == 1)
                {
                    if (Type == 2)
                    {


                        PlayerPrefs.SetInt(charakter, 1);
                        PlayerPrefs.SetInt(charakter + "1", 1);

                    }
                    if (Type == 5)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                        s.level += 22400;
                        File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetFloat("attack", 0);
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                    if (Type == 6)
                    {


                        PlayerPrefs.SetInt(charakter, 1);
                        PlayerPrefs.SetInt(charakter + "1", 1);

                    }
                    if (Type == 6)
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                        s.level += 22400;
                        File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));
                        PlayerPrefs.SetFloat("attack", 0);
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }
            }
            if (random == true)
            {

            }
            if (Type == 3)
            {
                PlayerPrefs.GetInt("rs", 1);
                    
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

