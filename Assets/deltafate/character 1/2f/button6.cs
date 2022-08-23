using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button6 : MonoBehaviour
{

    public int id;
    public bool enter;
    private void Start()
    {
        
    }
    public void startcol()
    {
        enter = true;
        if (PlayerPrefs.GetInt("ling", 0) == 0)
        {


            PlayerPrefs.SetString("text", "нажать "+deltacontrols.getcontrols.s12[3]);
        }
        if (PlayerPrefs.GetInt("ling", 0) == 1)
        {


            PlayerPrefs.SetString("text", "press " + deltacontrols.getcontrols.s12[3]);
        }
        if (PlayerPrefs.GetInt("ling", 0) == 2)
        {


            PlayerPrefs.SetString("text", "**.-GGп-" + deltacontrols.getcontrols.s12[3]);
        }
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {

            startcol();



        }
    }
    private void OnTriggerEnter(Collider s)
    {
        if (s.gameObject.tag == "Player")
        {

            startcol();



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
                PlayerPrefs.SetInt("u", id);
            }
        }
    }
    private void OnTriggerExit(Collider s)
    {
        if (s.gameObject.tag == "Player")
        {

            enter = false;
            PlayerPrefs.SetString("text", "");



        }
    }
    
}

