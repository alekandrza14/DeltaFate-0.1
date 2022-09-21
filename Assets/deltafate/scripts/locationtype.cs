using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum location
{
    top_down,
    platformer
}

public class locationtype : MonoBehaviour
{
    public location lc;
    public static location lc1 = location.top_down;
    public location getlc()
    {
        return lc;
    }
    static public location GetLocation()
    {
        
        if (FindObjectOfType<locationtype>())
        {
            lc1 = FindObjectOfType<locationtype>().getlc();
        }
        return lc1;
    }
}
