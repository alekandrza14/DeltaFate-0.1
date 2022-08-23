using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim22 : MonoBehaviour
{
    public string character;
    public bool s; public bool s2;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(character, 0) == 1 && !s)
        {
            Destroy(gameObject);
        }
        if (PlayerPrefs.GetInt(character, 0) == 2 && s2)
        {
            Destroy(gameObject);
        }
        if (PlayerPrefs.GetInt(character, 0) != 1 && s)
        {
            Destroy(gameObject);
        }

    }

    
}
