using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;




namespace deltacontrols 
{
    
public class getcontrols
{
    public static string filestat = "sins/controls";
    public static string[] s12 = new string[5]
    {"Escape",
     "g",
     "f",
     "e",
     "4"
    }; 
        
    public static string[] s13 = new string[5]
    {"Escape",
     "g",
     "f",
     "e",
     "4"
    };
    public static void Getkeycode()
    {
            s12 = setcontrols.Getkeycode();
            
    }


}
public class setcontrols
{
    
    public string[] s12 = new string[5]
    {"Escape",
     "g",
     "f",
     "e",
     "4"
    };

        public static string[] Getkeycode()
        {
            deltacontrols.setcontrols sc = new deltacontrols.setcontrols();
            if (File.Exists(deltacontrols.getcontrols.filestat+"/kc.un"))
            {
                sc.s12 = JsonUtility.FromJson<deltacontrols.setcontrols>(File.ReadAllText(deltacontrols.getcontrols.filestat + "/kc.un")).s12;
            }
            return sc.s12;
        }
        public void Setkeycode(string[] ss)
        {
            deltacontrols.setcontrols sc = new deltacontrols.setcontrols();
            for (int i = 0; i<ss.Length;i++)
            {
                if (ss[i] != "")
                {
                    s12[i] = ss[i];
                }
                else
                {
                    s12[i] = deltacontrols.getcontrols.s13[i]; 
                }
            }
                sc.s12 = s12;
            Directory.CreateDirectory(deltacontrols.getcontrols.filestat);
            File.WriteAllText(deltacontrols.getcontrols.filestat + "/kc.un",JsonUtility.ToJson(sc));
        }


    }
}

public class Main_main_menu : MonoBehaviour
{
    public int cur;
    public Text[] txt;
    public Text[] othions;
    public Text[] othions2;
    public Text[] shop;
    public Color[] cl;
    public int cur2;
    public int cur3; 
    public int cur4;
    public Text[] txt2;
    public Color cl1;
    public Color cl2; public Color cl22;
    public Color cl3;
    public Color cl4;
    public Color cl5;
    public int id;
    public string slot;
    public battlesave s = new battlesave();
    public battlesave s2 = new battlesave();
    public battlesave s3 = new battlesave();
    public saveload s34 = new saveload();
    public items s1 = new items();
    public items s12 = new items();
    public Canvas[] canvass;
    public int dificul;
    public string[] dificulname;
    public string[] dificulengname;
    public string[] dificulunname;
    public string[] linguace; public int linguace2;
    public string[] dificulopisanie;
    public string[] dificulengopisanie;
    public string[] dificulunopisanie;
    public int tic = 0;
    public int sale;
    public int idmenu;
    public bool contactInDeltarune;
    public string dr;
    public bool a2;

    public void tutorial()
    {
        SceneManager.LoadScene(221);
    }
    public void options()
    {
        Debug.Log("open options");
     //   startinput = !startinput;
    }
    public void startarena()
    {
      //  SceneManager.LoadScene(144);
    }
    public void saves()
    {
        battlesave bs = new battlesave();
        if (File.Exists(@"DELTAFATE/unauticna/bposition.un"))
        {
            bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/unauticna/bposition.un"));
            s34 = JsonUtility.FromJson<saveload>(File.ReadAllText(@"DELTAFATE/unauticna/position"+ bs.idscene[0]/150+".un"));
            PlayerPrefs.SetInt("loadstart",1);
            SceneManager.LoadScene(s34.idscene);
        }
        
    }
    public void shop1()
    {
        Debug.Log("open options");
     //   startinput2 = !startinput2;
    }
    public void input()
    {
        if (Input.GetKeyDown(KeyCode.N) && Directory.Exists("debug")) 
        {
            PlayerPrefs.SetInt("chapter3end", 1);
            PlayerPrefs.SetInt("sas61", 2);
        }

        if (startinput == true && startinput2 == false)
        {
            tic = 0;






            if (linguace2 == 0)
            {

                if (dificulname.Length > dificul)
                {


                    othions[0].text = dificulname[dificul];
                    othions2[0].text = dificulopisanie[dificul];
                }
                else
                {
                    othions[0].text = "error";
                    othions2[0].text = "f0f0f0f";
                }
            }
            if (linguace2 == 1)
            {

                if (dificulname.Length > dificul)
                {


                    othions[0].text = dificulengname[dificul];
                    othions2[0].text = dificulengopisanie[dificul];
                }
                else
                {
                    othions[0].text = "error";
                    othions2[0].text = "f0f0f0f";
                }
            }
            if (linguace2 == 2)
            {

                if (dificulname.Length > dificul)
                {


                    othions[0].text = dificulunname[dificul];
                    othions2[0].text = dificulunopisanie[dificul];
                }
                else
                {
                    othions[0].text = "error";
                    othions2[0].text = "f0f0f0f";
                }
            }
            if (linguace.Length > linguace2)
            {


                othions[3].text = linguace[linguace2];
                
            }
            else
            {
                othions[3].text = "error";
                
            }
            canvass[0].enabled = false; 
            canvass[2].enabled = false;
            canvass[1].enabled = true;

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (cur3 > -1 && cur3 < othions.Length - 1)
                {
                    cur3++;
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (cur3 > 0 && cur3 < othions.Length)
                {
                    cur3--;
                }
            }
            for (int i = 0; i < othions.Length; i++)
            {
                if (i != cur3)
                {
                    othions[i].color = cl[0];
                }
                if (i == cur3)
                {
                    othions[i].color = cl[1];
                }
            }
            if (cur3 == 1)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    optionexit();
                }
            }
            if (cur3 == 2)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    startarena();
                }
            }
            if (cur3 == 3)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    langues();
                }
            }
            if (cur3 == 4)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    tutorial();
                }
            }
            if (cur3 == 0)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    dif();

                }
            }

        }
        if (startinput2 == true && startinput == false)
        {
            tic = 0;







            canvass[0].enabled = false;
            canvass[1].enabled = false;
            canvass[2].enabled = true;

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (cur3 > -1 && cur3 < shop.Length - 1)
                {
                    cur3++;
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (cur3 > 0 && cur3 < shop.Length)
                {
                    cur3--;
                }
            }
            for (int i = 0; i < shop.Length; i++)
            {
                if (i != cur3)
                {
                    shop[i].color = cl[0];
                }
                if (i == cur3)
                {
                    shop[i].color = cl[1];
                }
            }
            if (cur3 == 3)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                   saves();
                }
            }
            if (cur3 == 2)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    shopexit();
                }
            }
            if (cur3 == 1)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    byesecret();
                }
            }
            if (cur3 == 0)
            {
                if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                {
                    potrons();

                }
            }
           

        }
        if (startinput2 == false && startinput == false)
        {
            canvass[0].enabled = true;
            canvass[2].enabled = false; 
            canvass[1].enabled = false;
        }
        if (startinput == false && startinput2 == false)
        {
            tic += 1; if (tic > 1)
            {
                canvass[0].enabled = true;
                canvass[1].enabled = false;

                canvass[2].enabled = false;
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
                if (Input.GetKeyDown(KeyCode.S))
                {
                    if (cur2 > -1 && cur2 < txt2.Length - 1)
                    {
                        cur2++;
                    }
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (cur2 > 0 && cur2 < txt2.Length)
                    {
                        cur2--;
                    }
                }
                if (Input.GetKeyDown(KeyCode.Z) && a2)
                {
                    if (cur4 > 0 && cur4 < 2)
                    {
                        cur4--;
                    }
                }
                if (Input.GetKeyDown(KeyCode.X) && a2)
                {
                    if (cur4 > -1 && cur4 < 1)
                    {
                        cur4++;
                    }
                }
                for (int i = 0; i < txt2.Length; i++)
                {
                    if (i != cur2)
                    {
                        txt2[i].color = cl[0];
                    }
                    if (cur2 == 1 && cur4 != 1 && i == 5)
                    {
                        txt2[i].color = cl[0];
                    }
                    if (cur2 == 1 && cur4 != 0 && i == 1)
                    {
                        txt2[i].color = cl[0];
                    }
                    if (i == 0 && i == cur2)
                    {
                        txt2[i].color = cl1;
                    }
                    if (i == 1 && i == cur2 && cur4 != 1)
                    {
                        txt2[i].color = cl2;
                    }
                    if (i == 2 && i == cur2)
                    {
                        txt2[i].color = cl3;
                    }
                    if (i == 3 && i == cur2)
                    {
                        txt2[i].color = cl4;
                    }
                    if (i == 4 && i == cur2)
                    {
                        txt2[i].color = cl5;
                    }
                    if (cur2 == 1 && cur4 == 1 && i==5)
                    {
                        txt2[i].color = cl22;
                    }
                }
                if (cur == 0)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        play();
                    }
                }

                if (cur == 1)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        Application.Quit();
                    }
                }/*
                if (cur == 2)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        delete();
                    }
                }
                if (cur == 3)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        options();
                    }
                }
                if (cur == 4)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        shop1();
                    }
                }*/
                if (cur == 5)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        secret();
                    }
                }
                if (cur == 6)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
                    {
                        secret1control();
                    }
                }

            }
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Screen.SetResolution(1920, 1080, true);
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                Screen.SetResolution(4000, 2000, true);
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Screen.SetResolution(1024, 768, true);
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                Screen.SetResolution(1024, 768, false);
            }


        }
    }
    public static bool startinput; 
    public static bool startinput2;

    public void delete()
    {
        

        /*
            PlayerPrefs.DeleteAll();
            Directory.Delete("DELTAFATE", true);
            
            s.idscene[0] = 1;
            Directory.CreateDirectory(@"DELTAFATE");

            Directory.CreateDirectory(@"DELTAFATE/henry");


            File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));
        */
        
    }
    public void exit()
    {
        Application.Quit();
    }
    public void curs1()
    {
        cur2 = 0;
    }
    public void curs2()
    {
        cur2 = 1; cur4 = 0;
    }
    public void curs2a()
    {
        cur2 = 1; cur4 = 1;
    }
    public void curs3()
    {
        cur2 = 2;
    }
    public void curs4()
    {
        cur2 = 3;
    }
    public void curs5()
    {
        cur2 = 4;
    }
    public void dif()
    {
        Debug.Log("dificut swap");
        if (dificul < dificulname.Length)
        {
            dificul++;
        }
        if (dificul == dificulname.Length)
        {
            dificul = 0;
        }

    }
    public void langues()
    {

        Debug.Log("dificut swap");
        if (linguace2 < linguace.Length)
        {
            linguace2++;
        }
        if (linguace2 == linguace.Length)
        {
            linguace2 = 0;
        }

    }
    public void potrons()
    {
        Debug.Log("dificut swap");
        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
        {
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
        }
        if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
        {
            s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
        }
        int lvl;
        lvl = s.level + s2.level;
        if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
        {
            s3 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry12/bposition.un"));
        }
        lvl += s3.level;
        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
        {
            if (lvl > 100)
            {


                lvl -= sale;
                s.level = lvl - s2.level - s3.level;
               
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                for (int x = 0; x < 20; x++)
                {


                    s1.patrons[Random.Range(0, guns.IDdamage.Length)] += 10;
                }
                File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));
                
            }

        }
        if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
        {
            if (lvl > 100)
            {


                lvl -= sale;

                s2.level = lvl - s.level - s3.level;
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                for (int x = 0; x < 20; x++)
                {


                    s1.patrons[Random.Range(0, guns.IDdamage.Length)] += 10;
                }
                File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));

                File.WriteAllText(@"DELTAFATE/henry1/bposition.un", JsonUtility.ToJson(s2));
            }

        }
        if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
        {
            if (lvl > 100)
            {


                lvl -= sale;

                s3.level = lvl - s.level - s2.level;
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                for (int x = 0; x < 20; x++)
                {


                    s1.patrons[Random.Range(0, guns.IDdamage.Length)] += 10;
                }
                File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));

                File.WriteAllText(@"DELTAFATE/henry12/bposition.un", JsonUtility.ToJson(s3));
            }

        }

    }
    public void optionexit()
    {
        Debug.Log("open exit");
     //   startinput = !startinput;
    }
    public void shopexit()
    {
        Debug.Log("open exit");
     //   startinput2 = !startinput2;
    }
    public void play()
    {

        
                SceneManager.LoadScene("level-1");
        
        
    }  
    void Start()
    {
       // Cursor.SetCursor(records2.spritest3("Hero soul/курсор1", 0),-Vector2.one,new CursorMode());
        deltacontrols.getcontrols.Getkeycode();
        dificul = PlayerPrefs.GetInt("dif", 0); 
        linguace2 = PlayerPrefs.GetInt("ling", 1);
        if (PlayerPrefs.HasKey("ling"))
        {
            PlayerPrefs.SetInt("ling", 1);
        }
        dr = Path.Combine();
      /*  if (File.Exists("sins/DELTARUNE.exe"))
        {

            contactInDeltarune = true;
            


        }
      */

    }
        void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.X))
        {
            Directory.CreateDirectory(@"DELTAFATE");
            SceneManager.LoadScene(92);
        }
        input();
        PlayerPrefs.SetInt("dif", dificul);
        PlayerPrefs.SetInt("ling", linguace2);
        if (linguace2 == linguace.Length)
        {
            linguace2 = 0;
        }
        if (linguace2 == 2 && !Directory.Exists("debug"))
        {
            linguace2++;
        }
        if (linguace2 == linguace.Length)
        {
            linguace2 = 0;
        }

    }
    public void byesecret()
    {
        /*
        Debug.Log("dificut swap");
        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
        {
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
        }
        if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
        {
            s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
        }
        int lvl;
        lvl = s.level + s2.level;
        if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
        {
            s3 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry12/bposition.un"));
        }
        lvl += s3.level;
        if (File.Exists(@"DELTAFATE/henry/bposition.un"))
        {
            if (lvl > 1000)
            {


                lvl -= 1000;
                s.level = lvl -( s2.level + s3.level);

                
                File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s));
                PlayerPrefs.SetString("rejim", "neytral");
                SceneManager.LoadScene(82);
            }

        }
        if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
        {
            if (lvl > 1000)
            {


                lvl -= 1000;

                s2.level = lvl -( s.level + s3.level);
                

                File.WriteAllText(@"DELTAFATE/henry/bposition.un", JsonUtility.ToJson(s2));
                PlayerPrefs.SetString("rejim", "neytral");
                SceneManager.LoadScene(82);
            }

        }
        if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
        {
            if (lvl > 100)
            {


                lvl -= 100;

                s3.level = lvl -( s.level + s2.level);
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                for (int x = 0; x < 20; x++)
                {


                    s1.patrons[Random.Range(0, guns.IDdamage.Length)] += 10;
                }
                File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));

                File.WriteAllText(@"DELTAFATE/henry12/bposition.un", JsonUtility.ToJson(s3));
            }

        }
        */
    }

    public void secret()
    {


     //   SceneManager.LoadScene(107);

    }
    public void secret1control()
    {


       // SceneManager.LoadScene(194);

    }

}
