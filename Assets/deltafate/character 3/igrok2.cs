using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class igrok2 : MonoBehaviour
{
    public int hp = 10;
    
    public bool fight;
    
    public Text txt;
    
    public battlesave s = new battlesave();
    public int playcharacter;
    public int level = 11;
    public string nameing;
    public int d = 1;
    public bool ss;
    public int ps = 11;
    public int chapter5 = 0;
    public bool isinstialization;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite[] ss2;
    float tic = 0; int tir = 0;
    public teamsave ts = new teamsave();


    private void Start()
    {
        ss2 = Resources.LoadAll<Sprite>("anims/henry attack");
        if (File.Exists("DELTAFATE/var/team.json"))
        {


            ts = JsonUtility.FromJson<teamsave>(File.ReadAllText("DELTAFATE/var/team.json"));

        }
        if (chapter5 == 0)
        {
            
            


            if (nameing == "henry12")
            {
                ss = false;
                
            }
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                if (nameing == "siji0")
                {
                    ss = true;
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
            }
            if (!Directory.Exists("debug"))
            {
                if (nameing == "sarux")
                {
                    ss = true;
                    GetComponent<SpriteRenderer>().color = new Color(1,1, 1, 1);
                }
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji" && PlayerPrefs.GetString("ch1", "") != "0")
            {
                if (nameing == "henry1")
                {
                    ss = true;
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
            }
            if (PlayerPrefs.GetString("ch1", "") == "0")
            {
                if (nameing == "siji02")
                {
                    ss = false;
                    

                }
            }
            if (PlayerPrefs.GetString("ch1", "") == "1")
            {

                if (nameing == "siji02")
                {
                    ss = false;
                    
                }
                
                if (nameing == "reynor6edru")
                {

                    ss = false;
                    

                }
            }
            if (PlayerPrefs.GetString("ch1", "") == "reynor")
            {
                if (nameing == "reynor6edru")
                {
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                    ss = false;
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
            }

        }
        if (chapter5 == 1)
        {


            if (PlayerPrefs.GetString("rejim", "pacifist") != "genocide")
            {
                if (nameing == "evil")
                {
                    ss = true;
                    GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                }
            }
            if (PlayerPrefs.GetString("rejim", "pacifist") != "neytral")
            {
                if (PlayerPrefs.GetString("rejim", "pacifist") != "pacifist")
                {
                    if (nameing == "henry")
                    {
                        ss = true;
                        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                    }
                }
            }
            if (PlayerPrefs.GetString("rejim", "pacifist") != "hero")
            {
                if (nameing == "hero")
                {
                    ss = true;
                    GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                }
            }

        }
        if (File.Exists(@"DELTAFATE/"+nameing+"/bposition.un"))
        {
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + nameing + "/bposition.un"));
            level = s.level;
        }

        hp = level;
        hp += 10;
        hp /= d; 
        hp += ps;

        if (PlayerPrefs.GetInt("gender", 0) == 1 && nameing == "henry12")
        {
            hp /= 2;
        }
        if (PlayerPrefs.GetInt("gender", 0) == 1 && nameing == "henry1")
        {
            hp /= 2;
        }
        if (PlayerPrefs.GetInt("gender", 0) == 1 && nameing == "henry")
        {
            hp /= 2;
        }
        

        if (PlayerPrefs.GetInt("dif", 0) == 2)
        {
            hp /= 10;

        }
        if (PlayerPrefs.GetInt("dif", 0) == 3)
        {
            hp *= 5;

        }
        if (PlayerPrefs.GetInt("dif", 0) == 1)
        {
            hp /= 2;

        }
        if (PlayerPrefs.GetInt("dif", 0) == 4)
        {
            hp = 1;
        }
     
        isinstialization = true;
    }
    void Update()
    {
        tic += Time.deltaTime;
        if (ss == true && isinstialization == true)
        {
            
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);

            
            hp = 0;
            fight = true;
        }
        if (deltacontrols.getcontrols.s12[0] == "Escape")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (Input.GetKey(deltacontrols.getcontrols.s12[0]))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (GameObject.FindObjectsOfType<soul_move>().Length == 0 && GameObject.FindObjectsOfType<newpurpure>().Length == 0)
        {
            SceneManager.LoadScene(31);
        }
        else
        {
        }
        if (PlayerPrefs.GetInt("damage", 0) == 1)
        {
            hp -= 2;
            PlayerPrefs.SetInt("damage", 0);
        }
        if (PlayerPrefs.GetInt("command", 0) == 1)
        {
            Debug.Log("spare");

        }
        
        
        if (isanimend.attack == 1)
        {

            if (nameing == "henry12")
            {
                isanimend.animenable = 1;
            }
            if (nameing == "henry1")
            {
                isanimend.animenable = 1;
            }
            if (nameing == "henry2")
            {
                isanimend.animenable = 1;
            }
            if (nameing == "henry")
            {
                isanimend.animenable = 1;
            }
            if (nameing == "henry1standart")
            {
                isanimend.animenable = 1;
            }
            Debug.Log("attack");


        }
        if (isanimend.animenable == 1)
        {
            if (nameing == "henry12")
            {
                animhenry();
            }
            if (nameing == "henry1")
            {
                animhenry();
            }
            if (nameing == "henry2")
            {
                animhenry();
            }
            if (nameing == "henry")
            {
                animhenry();
            }
            if (nameing == "henry1standart")
            {
                animhenry();
            }
            
        }
        if (PlayerPrefs.GetInt("command", 0) == 3)
        {
            


        }
        if (PlayerPrefs.GetInt("command", 0) == 4)
        {
            Debug.Log("flee");
            
            
        }
        if (PlayerPrefs.GetInt("command", 0) == 5)
        {
            Debug.Log("magick");
            

        }
        if (PlayerPrefs.GetInt("command", 0) == 0 && gameObject == GameObject.FindObjectsOfType<igrok2>()[GameObject.FindObjectsOfType<igrok2>().Length-1].gameObject)
        {
            isanimend.attack = 0;

        }
        txt.text = hp.ToString();
        if (fight == true)
        {
            txt.text = hp.ToString() + "занят";
            
                if (ss == true)
                {
                    txt.text = hp.ToString() + "отсуствует";
                }
            

        }
        if (fight == false)
        {
            txt.text = hp.ToString() + "готов";
            
                if (ss == true)
                {
                    txt.text = hp.ToString() + "отсуствует";
                }
            

        }


    }
    public void animhenry()
    {
        if (tir > ss2.Length -1)
        {
            GetComponent<SpriteRenderer>().sprite = ss2[0];
            tir = 0;
            isanimend.animenable = 0;
        }
        if (tic>= 0.15)
        {
            tir++;
            tic = 0;
        }
        if (tir < ss2.Length)
        {
            GetComponent<SpriteRenderer>().sprite = ss2[tir];
        }
    }
    public void fight1()
    {
        fight = true;
    }
    
    
}
public class isanimend
{
    static public int animenable = 0; 
    static public int animenable1 = 0;
    static public int animenable2 = 0;
    static public int animenable3 = 0;
    static public int attack = 0;
}
