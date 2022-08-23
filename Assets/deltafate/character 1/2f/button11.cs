using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button11 : MonoBehaviour
{

    public int id; public int id2;
    public bool enter;
    public string varible;
    public int vaule; 
    public int vaule2;
    public float tic;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            
                enter = true;


            

        }
    }
    private void OnTriggerExit2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            
                enter = false;

            


        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("u1", -1) != -1 && PlayerPrefs.GetInt("u1", -1) != 10)
        {
            PlayerPrefs.SetString("text2", eee11.t[PlayerPrefs.GetInt("u1", 0)]);

        }
        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
        {
            if (PlayerPrefs.GetInt("u1", -1) == -1)
            {
                if (id >= PlayerPrefs.GetInt("u3", -1))
                {

                    if (enter)
                    {

                        PlayerPrefs.SetInt("u1", id);
                        PlayerPrefs.SetInt("u2", 0);
                    }
                }

            }
            if (PlayerPrefs.GetInt("u1", -1) == vaule2)
            {

                if (enter)
                {

                    PlayerPrefs.SetInt("u1", id2);
                    PlayerPrefs.SetString("text2", "");
                }


            }
        }
        if (varible == "s")
        {

            if (enter)
            {

                PlayerPrefs.SetInt("u1", 10); if (PlayerPrefs.GetInt("u1", -1) == 10)
                {
                    PlayerPrefs.SetString("text2", "");
                    PlayerPrefs.SetString("text2", eee11.t[10]);
                }
            }


            if (PlayerPrefs.GetInt("u1", -1) == 10)
            {
                tic += 1 * Time.deltaTime;
                if (tic > 10)
                {
                    PlayerPrefs.SetString("text2", "");
                    PlayerPrefs.SetInt("u1", -1);
                    tic = 0;
                }
            }



        }

    }
}

