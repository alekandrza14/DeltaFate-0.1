using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class katscene_main6 : MonoBehaviour
{
    public string charakter;
    public Sprite[] anim;
    public float tic1;
    public float tic2;
    public float tic3;
    public int time1;
    public int time2;
    public int time3;
    public int time4;
    public int time5;
    public int time6;
    public int time7;
    public Rigidbody2D Rigidbody2Ds;
    public GameObject[] t1;
    public GameObject[] players;
    public GameObject curplayer;
    public int id;

    public void Update()
    {


        if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
        {
            SceneManager.LoadScene(id);
        }

        if (PlayerPrefs.GetInt(charakter + "2", 0) == 1)
        {
            
            PlayerPrefs.SetInt(charakter + "1", 1);
        }
        if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
        {
            

        }        
        
    }
   
           
      
}
