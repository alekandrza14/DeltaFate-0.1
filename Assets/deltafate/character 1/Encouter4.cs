using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Encouter4 : MonoBehaviour
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
    public int time3 = 50; 
    public int time4 = 100;
    public int hp = 600;
    public int mp = 12;
    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public battlesave s = new battlesave();
    public save s11 = new save();
    public battlesave s3 = new battlesave();
    public items s2 = new items();
    public int rand = 0;
    public bool random = false;
    public GameObject ps;
    public SpriteRenderer renderer1;
    public Sprite[] sp;
    public Sprite[] sph;
    public Sprite sph2;

    public float tic3;
    public float tic4;
    public bool vaule;
    public int idenc;
    public int specattack;
    void Start()
    {
        if (Type == 0)
        {
            specattack = -1;
        }
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
        if (int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) >= -10)
        {
            hp += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un")) / 20;
        }
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));
            Debug.Log("1");


        }
        PlayerPrefs.SetInt("TTN", 0);
        PlayerPrefs.SetInt("teni", 0);
        PlayerPrefs.SetInt("t44", 1);
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
    public debugEncouter d = new debugEncouter();
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

                    PlayerPrefs.SetInt("command", 0);
                }


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
        if (random == true)
        {
            rand = Random.Range(0, 2);
        }
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

        if (PlayerPrefs.GetInt("command", 0) == 4)
        {
            PlayerPrefs.SetInt("command", 0);
            player.GetComponent<igrok>().fight = true;
        }
        if (PlayerPrefs.GetInt("command", 0) == 5 && hp <= 40)
        {
            if (player.GetComponent<igrok>().playcharacter == 1)
            {


                hp -= 13;
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
            Debug.Log("1");
            int f = 0;

            for (int i = 0; i < s2.itemid.Count; i++)
            {
                if (s2.itemid[i] >= f && s2.patrons[i] >= 1)
                {
                    f = s2.itemid[i];
                    s2.patrons[i] -= 1;
                    hp -= guns.IDdamage[f];
                    Debug.Log("damage " + guns.IDdamage[f].ToString());
                    PlayerPrefs.SetInt("command", 0);
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
                PlayerPrefs.SetFloat("attack", 0);
                if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                {
                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                    SceneManager.LoadScene(s.idscene[0]);
                }
                PlayerPrefs.SetFloat("attack", 0);
            }
        }

        if (player.GetComponent<igrok>().reynor == true)
        {


            if (hp <= 0)
            {
                File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(s2));
                if (Type == 1)
                {


                    PlayerPrefs.SetInt("c", 4);
                }
                PlayerPrefs.SetFloat("attack", 0);
                if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                {
                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                    s.level += 2000;
                    if (s.level < 0)
                    {
                        s.level += 200;
                    }
                    File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));

                }
                if (File.Exists(@"DELTAFATE/reynor6edru/bposition.un"))
                {
                    s3 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/reynor6edru/bposition.un"));
                    s3.level += 2000;
                    if (s3.level < 0)
                    {
                        s3.level += 200;
                    }
                    File.WriteAllText(@"DELTAFATE/reynor6edru/bposition.un", JsonUtility.ToJson(s3));
                    SceneManager.LoadScene(s.idscene[0]);
                }

            }

        }
        if (player.GetComponent<igrok>().reynor == false)
        {
            if (hp <= 0)
            {
                if (specattack == -1)
                {


                    if (Type == 1)
                    {


                        PlayerPrefs.SetInt("c", 4);
                    }

                    if (Type == 0)
                    {
                        if (PlayerPrefs.GetInt("dif", 0) == 2)
                        {
                            savevartous.setusvar(@"DELTAFATE/var/hell.int", false, 1);
                        }
                    }
                    PlayerPrefs.SetFloat("attack", 0);
                    if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                    {
                        s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                        s.level += 2000;
                        if (s.level < 0)
                        {
                            s.level += 200;
                        }
                        File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));
                        SceneManager.LoadScene(s.idscene[0]);
                    }
                }
            }

        }
        tic += 1 * 60 * Time.deltaTime;
        tic2 += 1 * 60 * Time.deltaTime;
        tic3 += 1 * 60 * Time.deltaTime;
        tic4 += 1 * 60 * Time.deltaTime;
        if (hp <= 0 && specattack == 1)
        {
            if (tic3 >= time3)
            {
                if (player.GetComponent<igrok>().fight == true)
                {


                    if (tic3 >= time3)
                    {



                        Instantiate(obj1[3], position3[Random.Range(0, position3.Length)]);
                        tic3 = 0;

                    }

                    random = true;
                    tic3 = 0;
                }
            }
        }
        if (hp <= 0 && specattack == 2)
        {
            if (tic4 >= time4)
            {
                if (player.GetComponent<igrok>().fight == true)
                {


                    if (tic4 >= time4)
                    {



                        Instantiate(obj1[4], position4[Random.Range(0, position4.Length)]);
                        tic4 = 0;

                    }

                    random = true;
                    tic4 = 0;
                }
            }
        }
        if (mp >= 1 && hp >0)
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
            if (attack == 1)
            {
                if (tic >= time)
                {
                    if (player.GetComponent<igrok>().fight == true)
                    {


                        if (tic >= time)
                        {



                            Instantiate(obj1[1], position2[Random.Range(0, position2.Length)]);
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
                    if (player.GetComponent<igrok>().fight == true)
                    {


                        if (tic >= time)
                        {



                            Instantiate(obj1[Random.Range(1, 3)], position2[Random.Range(0, position2.Length)]);
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
            player.GetComponent<igrok>().fight = false;
            if (hp <= 0 && specattack == 2)
            {
                tic2 = time2;
                player.GetComponent<igrok>().fight = true;
                specattack = -1;

            }
            if (hp <= 0 && specattack == 1)
            {
                tic2 = -2500;
                player.GetComponent<igrok>().fight = true;
                specattack = 2;

            }
            if (hp <= 0 && specattack == 0)
            {


                tic2 = -2000;
                player.GetComponent<igrok>().fight = true;
                specattack = 1;
                
            }
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
            if (specattack == 0 && specattack == -1)
            {


                player.GetComponent<igrok>().fight = false;
            }
            if (specattack == 0 || specattack == -1)
            {
                tic2 = 0;
            }
            else if (specattack == 1 && tic2 == time2)
            {
                tic2 = 0;
            }
            else if (specattack == 2 && tic2 == time2)
            {
                tic2 = 0;
            }

            if (specattack == 0 && specattack == -1)
            {
                player.GetComponent<igrok>().fight = false;

            }

        }
    }
}
