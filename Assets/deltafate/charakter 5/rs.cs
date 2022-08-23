using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rs : MonoBehaviour
{
    public Animator s;
    public bool s3;
    void Update()
    {
        if (PlayerPrefs.GetInt("rs", 0) == 1)
        {
            s.SetBool("rs", true);
        }
        if (PlayerPrefs.GetInt("rs", 0) == 2)
        {
            s.SetBool("rs", false);
            if (PlayerPrefs.GetString("rejim", "pacifist") == "neytral")
            {

                if (PlayerPrefs.GetInt("sans332",0) == 0)
                {


                    PlayerPrefs.SetInt("u", 83);
                }
            }
            if (PlayerPrefs.GetString("rejim", "pacifist") == "genocide")
            {

                if (PlayerPrefs.GetInt("sans331", 0) == 0)
                {
                    PlayerPrefs.SetInt("u", 84);
                }
            }

        }
        if (s3) 
        { 
            ss1();
        }
    }
    public void ss1() 
    {
        PlayerPrefs.SetInt("rs",2);

    }

}
