using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class pps : MonoBehaviour
{
    public Text txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("rejim", "pacifist") == "pacifist")
        {
            txt.text = "ты папцифист";
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "neytral")
        {


            txt.text = "ты особенный";
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "genocide")
        {

            txt.text = "ты маньяк";

        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "hero")
        {

            txt.text = "ты герой";

        }
        if (File.Exists(@"DELTAFATE/unauticna/goingbytulmen"))
        {
            if (double.Parse(File.ReadAllText(@"DELTAFATE/unauticna/goingbytulmen")) > 1000)
            {


                txt.text = "ты демон";

            }
        }
        if (File.Exists(@"DELTAFATE/unauticna/goingbytulmen"))
        {
            if (double.Parse(File.ReadAllText(@"DELTAFATE/unauticna/goingbytulmen")) > 100000000000000000000000000000000000d)
            {


                txt.text = "кто ты?";

            }
        }
    }
}
