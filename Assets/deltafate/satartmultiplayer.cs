using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public struct namey
{
    public static string uname = "0";

    public static string uroom;
    
}

public class satartmultiplayer : MonoBehaviour
{
    public InputField field; public InputField field2;
    private void Update()
    {
        if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
        {
            start();
        }
    }
    public void start()
    {
        namey.uname = field.text; 
        namey.uroom = field2.text;
        save s = new save();
        if (namey.uroom == "1")
        {
            if (File.Exists(@"DELTAFATE/henry/bposition.un"))
            {
                battlesave bs = new battlesave();
                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                SceneManager.LoadScene(bs.idscene[0]);
            }
            else
            {
                s.enter = new bool[1500];
                s.idscene = 1;
                s.v3 = new Vector3[1500];

                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/henry-2");


                File.WriteAllText(@"DELTAFATE/henry/position.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(1);
            }
        }
        
        if (namey.uroom == "2")
        {
            if (File.Exists(@"DELTAFATE/siji/bposition.un"))
            {
                battlesave bs = new battlesave();
                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));
                SceneManager.LoadScene(bs.idscene[0]);
            }
            else
            {
                s.enter = new bool[1500];
                s.idscene = 24;
                s.v3 = new Vector3[1500];

                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/siji");


                File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(24);
            }
        }
        if (namey.uroom == "3")
        {
            SceneManager.LoadScene(75);
        }
        if (namey.uroom == "4" && PlayerPrefs.GetInt("chapter3end", 0) == 1)
        {
            if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
            {


                battlesave bs = new battlesave();
                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry12/bposition.un"));
                SceneManager.LoadScene(bs.idscene[0]);

            }
            else
            {
                s.enter = new bool[1500];
                s.idscene = 104;
                s.v3 = new Vector3[1500];

                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/henry12");


                File.WriteAllText(@"DELTAFATE/henry12/position.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(104);
            }
        }
        if (namey.uroom == "5")
        {
            SceneManager.LoadScene(146);
        }
        if (namey.uroom == "6")
        {
            if (PlayerPrefs.GetInt("sas61", 0) == 2)
            {
                if (File.Exists(@"DELTAFATE/henry1standart/bposition.un"))
                {

                    battlesave bs = new battlesave();
                    bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                    SceneManager.LoadScene(bs.idscene[0]);

                }
                else if (!File.Exists(@"DELTAFATE/henry1standart/bposition.un"))
                {
                    s.idscene = 89;

                    Directory.CreateDirectory(@"DELTAFATE");
                    Directory.CreateDirectory(@"DELTAFATE/henry1standart");


                    File.WriteAllText(@"DELTAFATE/henry1standart/bposition.un", JsonUtility.ToJson(s));

                    SceneManager.LoadScene(89);
                }


            }
        }
        if (namey.uroom == "7")
        {
            if (File.Exists(@"DELTAFATE/siji3/bposition.un"))
            {
                battlesave bs = new battlesave();
                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji3/bposition.un"));
                SceneManager.LoadScene(bs.idscene[0]);
            }
            else
            {
                s.idscene = 24;

                Directory.CreateDirectory(@"DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/siji3");


                File.WriteAllText(@"DELTAFATE/siji3/bposition.un", JsonUtility.ToJson(s));

                SceneManager.LoadScene(244);
            }
        }
        if (namey.uroom == "666")
        {
            SceneManager.LoadScene(253);
        }
        if (namey.uroom == "3/2")
        {
            SceneManager.LoadScene(255);
        }
    }
}
