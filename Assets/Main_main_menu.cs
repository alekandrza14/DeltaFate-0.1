using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;






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
        
        
    }
    public void shop1()
    {
        Debug.Log("open options");
     //   startinput2 = !startinput2;
    }
    public void input1()
    {
        

      
        
       
        
            tic += 1; if (tic > 1)
            {
                
                if (DuoInput.right())
                {
                    if (cur > -1 && cur < txt.Length - 1)
                    {
                        cur++;
                    }
                }
                if (DuoInput.left())
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
                    if (DuoInput.Enter())
                    {
                        play();
                    }
                }

                if (cur == 1)
                {
                    if (DuoInput.Enter())
                    {
                        Application.Quit();
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
    public static bool startinput;

    public void delete()
    {
        

    
            Directory.Delete("save", true);
            
           
        
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

        if (!File.Exists("save/data"))
        {


            SceneManager.LoadScene("level-1");
        }else if (File.Exists("save/data"))
        {
            SceneManager.LoadScene(File.ReadAllText("save/data"));
        }


    }
    public void close()
    {
        startinput = true;
    }
    void Start()
    {
        GameJolt.UI.GameJoltUI.Instance.ShowSignIn();

        GameJolt.UI.GameJoltUI.Instance.ShowSignIn(
        (bool signInSuccess) => {
            
                                },
        (bool userFetchedSuccess) => {
           
                                     }
                                                  );

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.X))
        {
            Directory.CreateDirectory(@"DELTAFATE");
            SceneManager.LoadScene(92);
        }
        var isSignedIn = GameJolt.API.GameJoltAPI.Instance.CurrentUser != null;
        if (isSignedIn)
        {

            input1();
        }
        if (startinput)
        {
            input1();
        }
        


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
