using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animh : MonoBehaviour
{
    public Animator hell;
    void Start()
    {
        if (PlayerPrefs.GetInt("dif", 0) >= 3)
        {
            hell.SetBool("hell", true);
        }
        if (PlayerPrefs.GetInt("undertale", 0) == 1)
        {
            hell.SetBool("undertale", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
