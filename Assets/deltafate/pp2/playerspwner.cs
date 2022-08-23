using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspwner : MonoBehaviour
{
    public GameObject[] players;
    private void Awake()
    {
        
    
        if (PlayerPrefs.GetString("ch", "henry") == "henry")
        {
            Instantiate(players[0].gameObject,gameObject.transform.position,Quaternion.identity);
        }
        if (PlayerPrefs.GetString("ch", "henry") == "siji")
        {
            Instantiate(players[1].gameObject, gameObject.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
