using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texty : MonoBehaviour
{
    public string pasword;
    public Text txt;
    public int id = 96;
    public string[] lengich;
    public bool is4c;
    void Update()
    {
        pasword = lengich[PlayerPrefs.GetInt("ling", 0)];
        if (txt.text == pasword && !is4c)
        {
            PlayerPrefs.SetInt("u", id);
        }
        if (txt.text == pasword && is4c)
        {
            PlayerPrefs.SetInt("uu", 1);
            PlayerPrefs.SetInt("u", id);
        }
    }
}
