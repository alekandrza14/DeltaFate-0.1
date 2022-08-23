using bigdigital;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Encouter10 : MonoBehaviour
{
    protected infint hp = new infint();
    protected infint mp = new infint();
    [Header("1 = infhp, 2 = hp")]
    [Header("3 = infmp, 4 = mp")]
    public int[] varibles;

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
    public float tic3;
    public float tic2;
    public int time = 20;
    public int time2 = 800;
    public int time3 = 400;

    public int Type = 0;
    public int attack = 0;
    public int attack1 = 0;
    public battlesave s = new battlesave();
    public save s1 = new save();
    public items s2 = new items();
    public items s3 = new items();
    public items s4 = new items();
    public items s5 = new items();
    public int rand = 0;
    public bool random = false;
    public string charakter;
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
    public int idenc;
    public string namis = "henry12";
    teamsave ts = new teamsave();
    public bool itsiji;
    public bool itreynor;
    public bool itsarux;
    public bool ithenry;
    public Texture2D cursor; public Texture2D cursor2;


    // Start is called before the first frame update
    void Start()
    {
        cursor = records2.spritest3("Hero soul/курсор2", 0);
        cursor2 = records2.spritest3("Hero soul/курсор1", 0);
        Cursor.SetCursor(cursor, Vector2.one, new CursorMode());
        hp.digital1 = varibles[2];
        hp.digital2 = varibles[1];
        mp.digital1 = varibles[4];
        mp.digital2 = varibles[3];
        if (File.Exists("DELTAFATE/var/team.json"))
        {


            ts = JsonUtility.FromJson<teamsave>(File.ReadAllText("DELTAFATE/var/team.json"));

        }
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


        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && ithenry)
        {
            s2 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));
            Debug.Log("1");


        }
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un") && itsiji)
        {
            s3 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));
            Debug.Log("2");


        }
        if (File.Exists(@"DELTAFATE/" + "reynor" + @"/inventory.un") && itreynor)
        {
            s4 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "reynor" + @"/inventory.un"));
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

            hp.digital1 *= 2;

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

    // Update is called once per frame
    void Update()
    {
        varibles[2] = hp.digital1;
        varibles[1] = hp.digital2;
        varibles[4] = mp.digital1;
        varibles[3] = mp.digital2;
        tic += 1 * 60 * Time.deltaTime;
        tic2 += 1 * 60 * Time.deltaTime; tic3 += 1 * 60 * Time.deltaTime;
        if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            hp = infint.addint(hp, -8);

            Debug.Log("s");
            if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && ithenry)
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s2.itemid.Count; i++)
                {
                    if (s2.itemid[i] >= f && s2.patrons[i] <= 1)
                    {
                        f = s2.itemid[i];
                        s2.patrons[f] -= 1;
                        if (guns.IDcountdamage[f] > 1)
                        {
                            s2.patrons[f] -= 20;
                        }
                        hp = infint.addint(hp, -guns.IDdamage[f] * Random.Range(1, 2));
                        Debug.Log("damage " + guns.IDdamage[f].ToString());
                    }
                }






            }
            if (File.Exists(@"DELTAFATE/" + "reynor" + @"/inventory.un") && itreynor)
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s4.itemid.Count; i++)
                {
                    if (s4.itemid[i] >= f && s4.patrons[i] <= 1)
                    {
                        f = s4.itemid[i];
                        s4.patrons[f] -= 1;
                        if (guns.IDcountdamage[f] > 1)
                        {
                            s4.patrons[f] -= 20;
                        }
                        hp = infint.addint(hp, -guns.IDdamage[f] * Random.Range(1, 2));
                        Debug.Log("damage " + guns.IDdamage[f].ToString());
                    }
                }






            }
            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un") && itsiji)
            {
                Debug.Log("1");
                int f = 0;

                for (int i = 0; i < s3.itemid.Count; i++)
                {
                    if (s3.itemid[i] >= f)
                    {
                        f = s3.itemid[i];
                        hp = infint.addint(hp, -guns33.IDdamage[f] * Random.Range(1, 2));
                        Debug.Log("damage " + guns33.IDdamage[f].ToString());
                    }
                }






            }

            PlayerPrefs.SetInt("command", 0);

        }
        if (tic2 >= time2)
        {
            if (hp.digital2 <= 0 && hp.digital1 <= 0 || mp.digital2 <= 0)
            {
                if (File.Exists(@"DELTAFATE/" + namis + "/bposition.un"))
                {
                    PlayerPrefs.SetFloat("attack", 0);
                    Cursor.SetCursor(cursor2, Vector2.one, new CursorMode());
                    s.level += 200;
                    s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + namis + "/bposition.un"));
                    PlayerPrefs.SetInt("command", 0);
                    File.WriteAllText(@"DELTAFATE/" + namis + "/bposition.un", JsonUtility.ToJson(s));
                    SceneManager.LoadScene(s.idscene[0]);
                }
            }
            playerilst.GetComponent<Main_main_menu2>().player[3].GetComponent<igrok2>().fight = false;
            playerilst.GetComponent<Main_main_menu2>().player[0].GetComponent<igrok2>().fight = false;
            playerilst.GetComponent<Main_main_menu2>().player[1].GetComponent<igrok2>().fight = false;
            playerilst.GetComponent<Main_main_menu2>().player[2].GetComponent<igrok2>().fight = false;
            tic2 = 0;
        }
        if (PlayerPrefs.GetInt("command", 0) == 1)
        {

            for (int i = 0; i < effect.ideffect.Count; i++)
            {



                if (effect.ideffect[i] == "damage")
                {
                    hp = infint.addint(hp, -effect.power[i]);
                }
                if (effect.ideffect[i] == "hill")
                {
                    for (int x = 0; x < playerilst.GetComponent<Main_main_menu2>().player.Length; x++)
                    {
                        playerilst.GetComponent<Main_main_menu2>().player[x].GetComponent<igrok2>().hp += effect.power[i];
                    }
                }
            }
            PlayerPrefs.SetInt("command", 0);

        }
        if (PlayerPrefs.GetInt("command", 0) == 3)
        {
            if (PlayerPrefs.GetInt("command1", 0) == 2 && charakter == "spamvil")
            {

                obj1[1].SetActive(true);
                hp.digital1 = 0; hp.digital2 = 0;
                PlayerPrefs.SetInt("command", 0);
                PlayerPrefs.SetInt("command1", 0);

            }
        }
        if (tic >= time)
        {
            if (playerilst.GetComponent<Main_main_menu2>().fight == true)
            {



                for (int i = count; i > 0; i--)
                {



                    Instantiate(obj1[0], position[Random.Range(0, position.Length)]);
                }
                tic = 0;



                random = true;
                tic = 0;
            }
        }
    }
}
