using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Main_main_menu6 : MonoBehaviour
{
    public int cur;
    public Text[] txt;

    public Color[] cl;


   
    public int id;
    public string slot;
    public save s = new save();
    public save s2 = new save();



    public void input()
    {
        

        
                

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
              
                
                
                    if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
                    {
                        play();
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
   
    public void exit()
    {
        Application.Quit();
    }


    public void cur1()
    {
        cur = 0;

    }
    public void cur11()
    {
        cur = 1;

    }

    public void play()
    {


        if (cur == 0)
        {

            PlayerPrefs.SetString("ch", "henry");

            if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
            {
                

                    battlesave bs = new battlesave();
                    bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
                    SceneManager.LoadScene(bs.idscene[0]);
                
            }
            else
            {
                if (File.Exists(@"DELTAFATE/henry/position0.un"))
                {
                    s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position0.un"));

                }
                s.enter = new bool[1500];
                s.idscene = 52;
                s.v3 = new Vector3[1500];
                s.level = s2.level;
                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/henry1");


                File.WriteAllText(@"DELTAFATE/henry1/position.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(52);
            }
        }
        if (cur == 1)
        {

            PlayerPrefs.SetString("ch", "siji");
            
            if (File.Exists(@"DELTAFATE/siji0/bposition.un"))
            {
               

                    battlesave bs = new battlesave();
                    bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));
                    SceneManager.LoadScene(bs.idscene[0]);
               
            }
            else
            {
                if (File.Exists(@"DELTAFATE/siji/position0.un"))
                {
                    s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position0.un"));

                }
                s.enter = new bool[1500];
                s.idscene = 52;
                s.v3 = new Vector3[1500];
                s.level = s2.level;
                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/siji0");


                File.WriteAllText(@"DELTAFATE/siji0/position.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(52);
            }
        }
       

    }  
    void Start()
    {


    }
    void Update()
    {
        input();



    }
}
