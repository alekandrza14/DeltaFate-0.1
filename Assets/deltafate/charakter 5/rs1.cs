using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rs1 : MonoBehaviour
{
    public Animator s;
    public bool s3;
    void Update()
    {
        if (PlayerPrefs.GetInt("rs", 0) == 3)
        {
            s.SetBool("rt3", true);
        }
        
    }
    

}
