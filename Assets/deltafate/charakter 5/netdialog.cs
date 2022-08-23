using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netdialog : MonoBehaviour
{
    public GameObject button;
    public string del; 
    public string delvar1;
    public string[] s = new string[1]; public string sm = "Очевидно...";
    public string[] se = new string[1]; public string sme = "yep undersatnd...";
    public string[] su = new string[1]; public string smu = "yep undersatnd...";
    public TextMeshProUGUI text;
    public TMP_FontAsset ft;
    public bool enter; public bool act;
    public float speed; public float speed2;
    public float tic; public int tir; public int tir2;
    public int item; public int count;
    public int sceneid;
    public GameObject g;
    public Transform t;
    public AudioSource ass;
    public items i1 = new items();

    public AudioClip assasin;
    public AudioClip assasine;
    public bool init;

    void Start()
    {
        init = true;
    }

    
    void Update()
    {
        if (act && enter && PlayerPrefs.GetInt("ling", 0) == 0)
        {

            tic += 1 * Time.deltaTime;
            if (tic >= 0.1f / speed)
            {
                for (int i = 0; i < speed2 && act && enter; i++)
                {
                    if (sm.Length > 2)
                    {
                        if (s.Length > tir2)
                        {


                            if (s[tir2].Length > tir)
                            {
                                text.text += s[tir2][tir];
                            }
                        }





                        else if (sm[0] != 's' && sm[1] != '2' && sm[2] != '-' && sm.Length > tir)
                        {
                            text.text += sm[tir];
                        }
                    }
                    if (sm.Length <= 2)
                    {
                        if (s.Length > tir2)
                        {


                            if (s[tir2].Length > tir)
                            {
                                text.text += s[tir2][tir];
                            }
                        }





                        else if (sm.Length > tir)
                        {
                            text.text += sm[tir];
                        }
                    }


                    tir += 1; if (s.Length > tir2)
                    {
                        if (s[tir2].Length <= tir)
                        {
                            tir2 += 1;
                            tir = 0;

                            act = false;
                        }
                    }
                    else if (sm.Length <= tir && sm[0] != 's' && sm[1] != '2' && sm[2] != '-')
                    {
                        tir2 += 1;
                        tir = 0;

                        act = false;
                    }
                    else if (sm == "s2-resset()")
                    {
                        tir2 = 0;
                        tir = 0;


                    }
                    else if (sm == "s2-resset(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if (sm == "s2-end(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(delvar1, 1);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if (sm == "s2-end(give)")
                    {
                        tir2 = 0;
                        tir = 0;
                        if (File.Exists(@"DELTAFATE/henry/inventory.un"))
                        {


                            i1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                            i1.itemid.Add(item);
                            i1.patrons[item] = count;
                            File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(i1));
                        }

                    }
                    else if (sm == "s2-(spawn)")
                    {
                        Instantiate(g, t);
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);

                    }
                    tic = 0;
                }
            }
        }
        if (act && enter && PlayerPrefs.GetInt("ling", 0) == 1)
        {

            tic += 1 * Time.deltaTime;
            if (tic >= 0.1f / speed)
            {
                for (int i = 0; i < speed2 && act && enter; i++)
                {
                    if (sme.Length > 2)
                    {
                        if (se.Length > tir2)
                        {


                            if (se[tir2].Length > tir)
                            {
                                text.text += se[tir2][tir];
                            }
                        }





                        else if (sme[0] != 's' && sme[1] != '2' && sme[2] != '-' && sme.Length > tir)
                        {
                            text.text += sme[tir];
                        }
                    }
                    if (sme.Length <= 2)
                    {
                        if (se.Length > tir2)
                        {


                            if (se[tir2].Length > tir)
                            {
                                text.text += se[tir2][tir];
                            }
                        }





                        else if (sme.Length > tir)
                        {
                            text.text += sme[tir];
                        }
                    }


                    tir += 1; if (se.Length > tir2)
                    {
                        if (se[tir2].Length <= tir)
                        {
                            tir2 += 1;
                            tir = 0;

                            act = false;
                        }
                    }
                    else if (sme.Length <= tir && sme[0] != 's' && sme[1] != '2' && sme[2] != '-')
                    {
                        tir2 += 1;
                        tir = 0;

                        act = false;
                    }
                    else if (sme == "s2-resset()")
                    {
                        tir2 = 0;
                        tir = 0;


                    }
                    else if (sme == "s2-end(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(delvar1, 1);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if (sme == "s2-resset(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if(sme == "s2-end(give)")
                    {
                        tir2 = 0;
                        tir = 0;
                        if (File.Exists(@"DELTAFATE/henry/inventory.un"))
                        {


                            i1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                            i1.itemid.Add(item);
                            i1.patrons[item] = count;
                            File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(i1));
                        }

                    }
                    else if (sme == "s2-(spawn)")
                    {
                        Instantiate(g, t);
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);

                    }
                    tic = 0;
                }
            }
        }
        if (act && enter && PlayerPrefs.GetInt("ling", 0) == 2)
        {

            tic += 1 * Time.deltaTime;
            if (tic >= 0.1f / speed)
            {
                for (int i = 0; i < speed2 && act && enter; i++)
                {
                    if (smu.Length > 2)
                    {
                        if (su.Length > tir2)
                        {


                            if (su[tir2].Length > tir)
                            {
                                text.text += su[tir2][tir];
                            }
                        }





                        else if (smu[0] != 's' && smu[1] != '2' && smu[2] != '-' && smu.Length > tir)
                        {
                            text.text += smu[tir];
                        }
                    }
                    if (smu.Length <= 2)
                    {
                        if (su.Length > tir2)
                        {


                            if (su[tir2].Length > tir)
                            {
                                text.text += su[tir2][tir];
                            }
                        }





                        else if (smu.Length > tir)
                        {
                            text.text += smu[tir];
                        }
                    }


                    tir += 1; if (su.Length > tir2)
                    {
                        if (su[tir2].Length <= tir)
                        {
                            tir2 += 1;
                            tir = 0;

                            act = false;
                        }
                    }
                    else if (smu.Length <= tir && smu[0] != 's' && smu[1] != '2' && smu[2] != '-')
                    {
                        tir2 += 1;
                        tir = 0;

                        act = false;
                    }
                    else if (smu == "s2-resset()")
                    {
                        tir2 = 0;
                        tir = 0;


                    }
                    else if (smu == "s2-end(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(delvar1, 1);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if (smu == "s2-resset(End-Room)")
                    {
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);
                        SceneManager.LoadScene(sceneid);
                    }
                    else if(smu == "s2-end(give)")
                    {
                        tir2 = 0;
                        tir = 0; 
                        if (File.Exists(@"DELTAFATE/henry/inventory.un"))
                        {


                            i1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/henry/inventory.un"));
                            i1.itemid.Add(item);
                            i1.patrons[item] = count;
                            File.WriteAllText(@"DELTAFATE/henry/inventory.un", JsonUtility.ToJson(i1));
                        }

                    }
                    else if (smu == "s2-(spawn)")
                    {
                        Instantiate(g, t);
                        tir2 = 0;
                        tir = 0;
                        PlayerPrefs.SetInt(del, tir2);

                    }
                    tic = 0;
                }
            }
        }
        if (!enter)
        {
            tir = 0;
            
            tic = 0;
            act = false;
        }
        if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]) && enter && !act)
        {
            if (ass && PlayerPrefs.GetInt("ling", 0) == 0)
            {
                ass.clip = assasin;
                ass.Play();
            }
            if (ass && PlayerPrefs.GetInt("ling", 0) == 1)
            {
                ass.clip = assasine;
                ass.Play();
            }
            act = true;
            tir = 0;
            text.text = "";
            tic = 0;
        }
        
        if (PlayerPrefs.GetInt("delbutton" + del, 0) == 1)
        {
            button.SetActive(true);
            
            
        }
        else
        {
            button.SetActive(false);
        }
        PlayerPrefs.SetInt(del ,tir2);
        if (init)
        {
            tir2 = PlayerPrefs.GetInt(del);
            s[0] = text.text;
            se[0] = text.text; 
            su[0] = text.text;
            PlayerPrefs.SetInt("delbutton" + del, 0);
            button.SetActive(false);
            text.text = "";
            init = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        Debug.Log(1);
        if (s.tag == "Player")
        {
            enter = true;
            Debug.Log(1);
            PlayerPrefs.SetInt("delbutton" + del, 1);
        }
    }
    private void OnTriggerExit2D(Collider2D s)
    {
        if (s.tag == "Player")
        {
            enter = false;
            PlayerPrefs.SetInt("delbutton" + del, 0);
        }
    }
}
