using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button10 : MonoBehaviour
{

    public int[] id;
    public bool enter;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            
                enter = true;
            if (PlayerPrefs.GetInt("ling", 0) == 0)
            {


                PlayerPrefs.SetString("text", "нажать " + deltacontrols.getcontrols.s12[3]);
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
        if (Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
        {
            if (enter)
            {
                PlayerPrefs.SetInt("u", id[Random.Range(0,id.Length)]);
            }
        }
    }
}

