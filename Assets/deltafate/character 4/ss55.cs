using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss55 : MonoBehaviour
{
    public bool enter;
    public int count;
    public int id = 111;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (count == 2)
        {
            if (collision.GetComponent<PlayerAnime>().ishenry)
            {
                ExampleClass.oo(collision.transform);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (count == 1)
        {
            if (collision.GetComponent<PlayerAnime>().ishenry)
            {
                enter = true;
                PlayerPrefs.SetInt("tt", 1);
            }
        }
        
        if (count == 0)
        {
            if (collision.GetComponent<PlayerAnime>().issiji)
            {
                enter = true;
                PlayerPrefs.SetInt("tt2", 1);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (count == 1)
        {
            if (collision.GetComponent<PlayerAnime>().ishenry)
            {
                enter = false;
                PlayerPrefs.SetInt("tt", 0);
            }
        }
        if (count == 0)
        {
            if (collision.GetComponent<PlayerAnime>().issiji)
            {
                enter = false;
                PlayerPrefs.SetInt("tt2", 0);
            }
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("tt",0)==1&& PlayerPrefs.GetInt("tt2", 0) == 1 && Input.GetKeyDown(deltacontrols.getcontrols.s12[3]))
        {
            PlayerPrefs.SetInt("u", id);
        }
    }
}
