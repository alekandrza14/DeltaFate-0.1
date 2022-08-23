using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class difficuteCustomEncouter
{
    public int[] count;
    public int[] hp;
    public int[] mp;
    public float[] tic;
    public float[] tic2;
    public int[] attack;
    public int[] playerhp;
    public string key;
}

public class debugEncouter 
{
    public int count;
    public int hp;
    public int mp;
    public float tic;
    public float tic2;
    public int attack;
    public static void updata(int hp, int mp, float tic, float tic2, int attack, debugEncouter d)
    {
        if (Directory.Exists("debug"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                d.hp = hp;
                d.mp = mp;
                d.tic = tic;
                d.tic2 = tic2;
                d.attack = attack;


                File.WriteAllText(debug.ptchfiles[1], JsonUtility.ToJson(d));
            }
            if (Input.GetKeyDown(KeyCode.R))
            {

                hp = 0;
                


                
            }
        }
    }
}

public class Encouter1 : MonoBehaviour
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
    public GameObject[] obj1h;

    public float tic;
    public float tic2;
    public int time = 20;
    public int time2 = 800; 
    public int time3 = 400;
    public int hp = 20;
    public int mp = 12;
    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public battlesave s = new battlesave();
    public save s11 = new save();
    public items s2 = new items();
    public int rand = 0;
    public bool random = false; 
    public GameObject ps;
   
    public SpriteRenderer renderer1;
    public Sprite[] sp;
    public Sprite[] sph; 
    public Sprite sph2;
    public float tic3;
    public bool vaule;
    public string sp2;
    public int index;
    public string[] sp2s;
    public int[] indexs;
    public int count = 1;
    public debugEncouter d = new debugEncouter();
    
    public int idenc;
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
        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
        {
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
            s11 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position" + s.idscene[0] / 150 + ".un"));
            hp += s11.hp / 20;

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
            
            records2.spritest(sp2, index, gameObject);
            if (sp.Length != 0)
            {
                sp[0] = records2.spritest2(sp2s[0], indexs[0], sp[0]);
                sp[1] = records2.spritest2(sp2s[1], indexs[1], sp[1]);
            }
            debugEncouter sf = new debugEncouter();
            sf = JsonUtility.FromJson<debugEncouter>(File.ReadAllText("res/" + sp2 + "_" + index + ".un"));
            hp = sf.hp;
            mp = sf.mp;
            time = Mathf.FloorToInt(sf.tic);
            time2 = Mathf.FloorToInt(sf.tic2);
            count = sf.count;
        }
        records2.spritest(sp2, index, gameObject);
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
        if (PlayerPrefs.GetInt("dif", 0) >= 3)
        {
            hp *= 2;
            
            sp = sph;
            GetComponent<SpriteRenderer>().sprite = sph2;
            obj1 = obj1h;
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

    // Update is called once per frame
    void Update()
    {
        if (mp <= 0)
        {
            time2 = 200;
        }
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

                    
                }
                if (PlayerPrefs.GetInt("command", 0) == 1)
                {



                    mp -= 10;
                    PlayerPrefs.SetInt("command", 0);
                    PlayerPrefs.SetInt("command1", 0);
                    player.GetComponent<igrok>().fight = true;

                    if (mp <= 0)
                    {
                        PlayerPrefs.SetFloat("attack", 0);
                        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                        {
                            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                            SceneManager.LoadScene(s.idscene[0]);
                        }
                        PlayerPrefs.SetFloat("attack", 0);
                    }
                }


            }
            PlayerPrefs.SetInt("command", 0);

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

            if (Input.GetKeyDown(KeyCode.Z))
            {


                if (File.Exists("res/debug/debugEncouter.un"))
                {
                    records2.spritest("debug", 0, gameObject);
                    if (sp.Length != 0)
                    {

                        sp[0] = records2.spritest2("debug", indexs[0], sp[0]);
                        sp[1] = records2.spritest2("debug", indexs[1], sp[1]);
                    }
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
                    if (sp.Length != 0)
                    {

                        sp[0] = records2.spritest2("debug", indexs[0], sp[0]);
                        sp[1] = records2.spritest2("debug", indexs[1], sp[1]);
                    }
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
        debugEncouter.updata(hp,mp,tic,tic2,attack,d);
        if (vaule == true)
        {
            
            tic3 += 1 * 60 * Time.deltaTime;
            s1.r(renderer1, sp, tic3, vaule);

            if (tic3 >= 200)
            {
                
                tic3 = 0;
                vaule = false;
            }
        }
        

        if (random == true)
        {
            rand = Random.Range(0, 2);
        }




        if (PlayerPrefs.GetInt("command", 0) == 5 && hp <= 40)
        {
            if (player.GetComponent<igrok>().playcharacter == 1)
            {


                hp -= 333;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
            if (player.GetComponent<igrok>().playcharacter == 0)
            {
                hp -= 10;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
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
        if (PlayerPrefs.GetInt("command1", 0) == 1)
        {

            player.GetComponent<igrok>().fight = true;

            mp -= 13;
            PlayerPrefs.SetInt("command", 0); 
            PlayerPrefs.SetInt("command1", 0);
            player.GetComponent<igrok>().fight = true;
            

            
        }

        if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            
            vaule = true;
                Instantiate(ps.gameObject, transform.position, transform.rotation);
            
            
            int f = 0;
            for (int i = 0; i < s2.itemid.Count; i++)
            {
                if (s2.itemid[i] >= f && s2.patrons[i] >= 1)
                {
                    f = s2.itemid[i];
                    s2.patrons[i] -= 1;
                    hp -= guns.IDdamage[f];
                    Debug.Log("damage " + guns.IDdamage[f].ToString());
                }
            }
            if (player.GetComponent<igrok>().playcharacter == 1)
            {
                
                for (int i = 0; i < s2.itemid.Count; i++)
                {
                    if (s2.itemid[i] >= f && s2.patrons[i] >= 1)
                    {
                        f = s2.itemid[i];
                        s2.patrons[i] -= 1;
                        hp -= guns.IDdamage[f] * 2;
                        Debug.Log("damage " + guns.IDdamage[f].ToString() + "х2");
                    }
                }
                hp -= 8;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
            }
            if (player.GetComponent<igrok>().playcharacter == 0)
            {
                hp -= 5;
                PlayerPrefs.SetInt("command", 0);
                player.GetComponent<igrok>().fight = true;
                player.GetComponent<igrok>().vaule = true;
            }
        }



        if (PlayerPrefs.GetInt("command", 0) == 1)
        {
            if (mp <= 0)
            {
                if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                {
                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                    SceneManager.LoadScene(s.idscene[0]);
                }
                PlayerPrefs.SetFloat("attack", 0);
            }
        }


        if (hp <= 0)
        {
            File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(s2));
            if (File.Exists(@"DELTAFATE/henry/bposition.un"))
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                s.level+=100;
                if (s.level < 0)
                {
                    s.level += 200;
                }
                File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));
                SceneManager.LoadScene(s.idscene[0]);
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
            if (attack >= 7)
            {
                
            }
            
            PlayerPrefs.SetInt("command", 0);
            PlayerPrefs.SetInt("command1", 0);
            player.GetComponent<igrok>().fight = false;
            tic2 = 0;
            
            player.GetComponent<igrok>().fight = false;
            

        }
    }
}
public class s1
{




    public static void r(SpriteRenderer renderer2, Sprite[] sp, float tic3, bool s33)
    {
        if (renderer2)
        {
            if (sp.Length != 0)
            {
                if (s33 == true)
                {
                    renderer2.sprite = sp[1];
                    if (tic3 >= 200)
                    {
                        renderer2.sprite = sp[0];

                    }



                }
            }
        }
    }
}
