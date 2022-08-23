using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class igrok : MonoBehaviour
{
    public int hp = 10;
    public int hp_reynor = 10;
    public bool fight;
    public bool reynor;
    public Text txt;
    public Text txt2;
    public battlesave s = new battlesave();
    public int playcharacter;
    public int level;
    public int c2;
    public bool sheldac;
    public int sheld = 100;
    public int typedeatrh;

    public SpriteRenderer renderer1;
    public Sprite[] sp;
    public float tic3;
    public bool vaule;
    public Sprite[] ss2;
    float tic = 0; int tir = 0;
    private void Start()
    {
        ss2 = Resources.LoadAll<Sprite>("anims/henry attack");
        if (c2 == 0)
        {


            if (File.Exists(@"DELTAFATE/henry/bposition.un"))
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                level = s.level;
            }
        }
        if (c2 == 1)
        {

            sheldac = true;
            if (File.Exists(@"DELTAFATE/siji/bposition.un"))
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));
                level = s.level;
            }
        }
        if (c2 == 0)
        {
            hp = level / 110;
            hp += 11;
        }
        if (c2 == 1)
        {
            if (PlayerPrefs.GetInt("1", 0) != -1)
            {
                if (PlayerPrefs.GetInt("r1", 0) != 0)
                {
                    GetComponent<SpriteRenderer>().sprite = sp[PlayerPrefs.GetInt("1", 0)];
                }
            }
                hp = level / 110;
            hp += 30;
            
        }
        hp_reynor = level / 110;
        hp_reynor += 11;
        if (PlayerPrefs.GetString("ch1", "") == "reynor")
        {
            reynor = true;
        }
        if (PlayerPrefs.GetString("ch1", "") != "reynor")
        {
            reynor = false;
        }
        if (PlayerPrefs.GetInt("dif",0) == 2)
        {
            hp /= 10;
            hp_reynor /= 10;
        }
        if (PlayerPrefs.GetInt("dif", 0) == 1)
        {
            hp /= 2;
            hp_reynor /= 2;
        }
        if (PlayerPrefs.GetInt("dif", 0) == 3)
        {
            hp *= 5;
            hp_reynor *= 5;
        }
    }
    void Update()
    {
        tic += Time.deltaTime;
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
        
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move2>().Length == 0 && typedeatrh == 0)
        {
            SceneManager.LoadScene(31);
        }
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move2>().Length == 0 && typedeatrh == 1)
        {
            SceneManager.LoadScene(203);
        }
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length == 0 && GameObject.FindObjectsOfType<Sanc_soul_move2>().Length == 0 && typedeatrh == 2)
        {
            SceneManager.LoadScene(244);
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
        if (PlayerPrefs.GetInt("command", 0) == 2)
        {
            vaule = true;
            fight1();
            Debug.Log("attack");

        }
        if (c2 == 0)
        {
            if (isanimend.attack == 1)
            {


                isanimend.animenable = 1;

                Debug.Log("attack");


            }
        }
        if (isanimend.animenable == 1)
        {
            animhenry();
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
            fight1();

        }
        if (PlayerPrefs.GetInt("command", 0) == 0)
        {
            isanimend.attack = 0;

        }
        txt.text = hp.ToString();

        if (reynor == false || sheldac == false)
        {
            txt2.text = "";

        }
        if (reynor == true)
        {
            txt2.text = hp_reynor.ToString();

        }
        if (sheldac == true)
        {
            txt2.text = sheld.ToString();

        }
    }
    public void animhenry()
    {
        if (tir > ss2.Length - 1)
        {
            GetComponent<SpriteRenderer>().sprite = ss2[0];
            tir = 0;
            isanimend.animenable = 0;
        }
        if (tic >= 0.15)
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
