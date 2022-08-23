using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class aveyks : MonoBehaviour
{
    public string[] pp;
    public int[] pp2;
    public battlesave s1 = new battlesave();
    private void Awake()
    {
        for (int x = 0;x<pp2.Length; x++)
        {


            if (PlayerPrefs.GetInt(pp[x] + "x", 0) == 1)
            {
                pp2[x] = PlayerPrefs.GetInt(pp[x] + "x", 0);
            }
            if (pp2[x] == 0)
            {
                if (PlayerPrefs.GetString("rejim", "pacifist") != "genocide")
                {


                    PlayerPrefs.SetString("rejim", "pacifist");
                    x = pp2.Length;
                }
                int s = 0;
                if (File.Exists(@"DELTAFATE/henry/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/henry1/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/siji0/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji0/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/henry12/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry12/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/siji02/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji02/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/siji/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/siji/bposition.un"));
                }
                s += s1.level; if (File.Exists(@"DELTAFATE/henry1standart/bposition.un"))
                {
                    s1 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/henry1standart/bposition.un"));
                }
                s += s1.level;
                if (PlayerPrefs.GetString("rejim", "pacifist") != "genocide" && s >= 11000)
                {


                    PlayerPrefs.SetString("rejim", "neytral");
                    x = pp2.Length;
                }
                if (PlayerPrefs.GetString("rejim", "neytral") != "genocide" && savevartous.usvarl(@"DELTAFATE/var/errorhp.long", 300000) == 0)
                {


                    PlayerPrefs.SetString("rejim", "genocide");
                    x = pp2.Length;
                }

            }

            if (x < pp2.Length)
            {
                if (PlayerPrefs.GetString("rejim", "pacifist") != "genocide")
                {



                    PlayerPrefs.SetString("rejim", "hero");
                }
            }
        }
    }
}
