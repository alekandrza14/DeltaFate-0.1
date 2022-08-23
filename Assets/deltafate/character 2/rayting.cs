using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class rayting : MonoBehaviour
{
    public save s1;
    public save s2;
    public save2 s3;
    public save s4;

    public Text killskg;
    void Update()
    {
        if (File.Exists(@"DELTAFATE/henry/position.un"))
        {


            s1 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));
        }
        if (File.Exists(@"DELTAFATE/siji/position.un"))
            s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));
        if (File.Exists(@"DELTAFATE/reynor/position.un"))
            s3 = JsonUtility.FromJson<save2>(File.ReadAllText(@"DELTAFATE/reynor/position.un"));
        if (File.Exists(@"DELTAFATE/sarux/position.un"))
            s4 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/sarux/position.un"));
        int killskgcount = 0;
        if (File.Exists(@"DELTAFATE/henry/position.un"))
            killskgcount = s1.level;
        if (File.Exists(@"DELTAFATE/siji/position.un"))
            killskgcount += s2.level;
        if (File.Exists(@"DELTAFATE/reynor/position.un"))
            killskgcount += s3.level;
        if (File.Exists(@"DELTAFATE/henry1/position.un"))
            s1 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));
        if (File.Exists(@"DELTAFATE/siji0/position.un"))
            s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji0/position.un"));
        
        if (File.Exists(@"DELTAFATE/henry/position.un"))
            killskgcount = s1.level;
        if (File.Exists(@"DELTAFATE/siji/position.un"))
            killskgcount += s2.level;
        
        killskgcount /= 22;
        if (killskgcount > 0)
        {


            killskg.text = "килограммы трупов :" + killskgcount.ToString();
        }
        else
        {
            killskg.text = "килограммы трупов : 0";
        }
    }
}
