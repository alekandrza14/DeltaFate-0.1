using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class katscene_main77 : MonoBehaviour
{
    public string charakter;
    public AudioClip[] c;
    public AudioSource audioSource1;
    public items s = new items();
    public battlesave s1 = new battlesave();
    public string naming;
    public string naming2;
    public int patrons;
    public bool t;
    public int id;
    public int sale;
    public bool t1;
    public int id1; 
    public bool t2;
    public int id2;
    public bool t3;
    public int id3;
    public int s12;
    public int s2;
    public int s3;
    public int s33;
    public void Update()
    {

        if (File.Exists(@"DELTAFATE/" + naming + "/bposition.un"))
        {
            s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/"+naming+"/bposition.un"));
        }

        if (File.Exists(@"DELTAFATE/" + naming2 + "/inventory.un"))
        {
            s = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/"+naming2+ @"/inventory.un"));



        }
       
        if (PlayerPrefs.GetString(charakter, "") == "done")
        {
            if (Input.GetKey(KeyCode.Alpha5) && s.itemid.Count > savevartous.usvar(@"DELTAFATE/var/cur2.int", 0) && naming2 == "henry")
            {
                if (s.itemid[savevartous.usvar(@"DELTAFATE/var/cur2.int", 0)] == 14)
                {

                    PlayerPrefs.SetInt("upxp", Random.Range(10, sale) * 20);
                    s.itemid.RemoveAt(savevartous.usvar(@"DELTAFATE/var/cur2.int", 0));
                    PlayerPrefs.SetString(charakter, "");
                }
            }
            if (Input.GetKey(KeyCode.Alpha5) && s.itemid.Count > savevartous.usvar(@"DELTAFATE/var/cur2.int", 0))
            {

                PlayerPrefs.SetInt("upxp", Random.Range(10, sale));
                s.itemid.RemoveAt(savevartous.usvar(@"DELTAFATE/var/cur2.int", 0));
                PlayerPrefs.SetString(charakter, "");
            }
           

                if (s1.level >= sale && !Input.GetKey(KeyCode.Alpha5))
            {
                if (t)
                {
                    s.itemid.Add(id);
                    PlayerPrefs.SetInt("upxp", -sale);
                    s.patrons[id] += patrons;
                }
            }

            audioSource1.clip = c[0];
            audioSource1.Play();
            if (!Input.GetKey(KeyCode.Alpha5))
                PlayerPrefs.SetString(charakter, "");
        }
        if (PlayerPrefs.GetInt("u2", 0) == 0)
        {
            if (PlayerPrefs.GetInt("u1", -1) == s12)
            {



                audioSource1.clip = c[0];
                audioSource1.Play();
                PlayerPrefs.SetInt("u2", 1);

            }

        }
        if (PlayerPrefs.GetInt("u1", -1) != -1)
        {
            if (PlayerPrefs.GetInt("u1", -1) == s2)
            {



                
                PlayerPrefs.SetInt("u1", s3);
                PlayerPrefs.SetString("text2", "");
            }

        }
        if (PlayerPrefs.GetInt("u1", -1) != -1)
        {
            if (PlayerPrefs.GetInt("u1", -1) == s33)
            {


                PlayerPrefs.SetInt("upxp", 3000);
                if (s1.level < 0)
                {
                    PlayerPrefs.SetInt("upxp", 200);
                }
                PlayerPrefs.SetInt("u1", -1);
                PlayerPrefs.SetInt("u3", s33);
                PlayerPrefs.SetString("text2", "");
            }

        }
        if (PlayerPrefs.GetString(charakter, "") == "done1")
        {
            if (s1.level >= sale)
            {
                if (t1)
                {
                    s.itemid.Add(id1);
                    PlayerPrefs.SetInt("upxp", -sale);
                    s.patrons[id] += patrons;
                }
            }
            audioSource1.clip = c[1];
            audioSource1.Play();
            PlayerPrefs.SetInt("r", 1);
            PlayerPrefs.SetString(charakter, "");

        }
        if (PlayerPrefs.GetString(charakter, "") == "done2")
        {
            if (s1.level >= sale)
            {
                if (t2)
                {
                    s.itemid.Add(id2);
                    PlayerPrefs.SetInt("upxp", -sale);
                    s.patrons[id] += patrons;
                }
            }
            audioSource1.clip = c[2];
            audioSource1.Play();
            PlayerPrefs.SetString(charakter, "");
        }
        if (PlayerPrefs.GetString(charakter, "") == "done3")
        {
            if (s1.level >= sale)
            {
                if (t3)
                {
                    s.itemid.Add(id3);
                    PlayerPrefs.SetInt("upxp", -sale);
                    s.patrons[id] += patrons;
                }
            }
            audioSource1.clip = c[3];
            audioSource1.Play();
            PlayerPrefs.SetString(charakter, "");
        }
        Directory.CreateDirectory(@"DELTAFATE/" + naming2);
        Directory.CreateDirectory(@"DELTAFATE/" + naming);
        if (File.Exists(@"DELTAFATE/" + naming2 + "/inventory.un"))
        {
            File.WriteAllText(@"DELTAFATE/" + naming2 + "/inventory.un", JsonUtility.ToJson(s));
        }
        if (File.Exists(@"DELTAFATE/" + naming + "/bposition.un"))
        {
            File.WriteAllText(@"DELTAFATE/" + naming + "/bposition.un", JsonUtility.ToJson(s1));
        }
    }
}
