using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim23 : MonoBehaviour
{
    public string character; 
    public string charactervar;
    public int vaule;
    public bool invert; 
    public bool setvar;
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.GetInt(charactervar, 0) == 1 && invert)
        {
            Destroy(gameObject);
            
        }
        if (PlayerPrefs.GetInt(character, 0) >= vaule && !invert)
        {
            
            Destroy(gameObject);
            
        }
        if (PlayerPrefs.GetInt(character, 0) < vaule && invert)
        {
            
            Destroy(gameObject);
            
        }


    }
    private void Update()
    {
        if (setvar)
        {
            PlayerPrefs.SetInt(charactervar, 1);
        }
    }


}
