using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button13 : MonoBehaviour
{

    public int id;
    public bool enter;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            
                enter = true;
           
            if (GameObject.FindObjectsOfType<zombie>().Length == 0)
            {
                if (PlayerPrefs.GetInt("ling", 0) == 0)
                {


                    PlayerPrefs.SetString("text", "войти " + deltacontrols.getcontrols.s12[3]);
                }
                if (PlayerPrefs.GetInt("ling", 0) == 1)
                {


                    PlayerPrefs.SetString("text", "enter " + deltacontrols.getcontrols.s12[3]);
                }


            }
            if (GameObject.FindObjectsOfType<zombie>().Length != 0)
            {
                if (PlayerPrefs.GetInt("ling", 0) == 0)
                {


                    PlayerPrefs.SetString("text", "для прохода нужно убить вскх врагов");
                }
                if (PlayerPrefs.GetInt("ling", 0) == 1)
                {


                    PlayerPrefs.SetString("text", "to pass you need to kill vskh enemies");
                }
               

            }
            if (GameObject.FindObjectsOfType<zombie1>().Length != 0)
            {
                if (PlayerPrefs.GetInt("ling", 0) == 0)
                {


                    PlayerPrefs.SetString("text", "не так просто");
                }
                if (PlayerPrefs.GetInt("ling", 0) == 1)
                {


                    PlayerPrefs.SetString("text", "not so easy");
                }
                

            }

        }
    }
    private void OnTriggerExit2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            
                enter = false;
            PlayerPrefs.SetString("text", "");



        }
    }
    void Update()
    {
        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
        {
            if (enter)
            {
                if (GameObject.FindObjectsOfType<zombie>().Length == 0)
                {

                    if (GameObject.FindObjectsOfType<zombie1>().Length == 0)
                    {
                        PlayerPrefs.SetInt("dif", 0);

                        PlayerPrefs.SetInt("u", id);
                    }
                }
            }
        }
    }
}

