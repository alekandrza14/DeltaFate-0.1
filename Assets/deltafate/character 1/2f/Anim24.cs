using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim24 : MonoBehaviour
{
    public string character; 
    
    public string vaule;
    public bool invert; 
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        


    }
    private void Update()
    {
        if (PlayerPrefs.GetString(character, "") != vaule && !invert)
        {

            Destroy(gameObject);

        }
        if (PlayerPrefs.GetString(character, "") == vaule && invert)
        {

            Destroy(gameObject);

        }
    }


}
