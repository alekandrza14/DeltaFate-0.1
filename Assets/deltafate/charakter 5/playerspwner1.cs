using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspwner1 : MonoBehaviour
{
    public GameObject[] players;
    void Awake()
    {
        if (PlayerPrefs.GetString("rejim", "pacifist") == "pacifist")
        {
            Instantiate(players[0].gameObject, gameObject.transform.position, Quaternion.identity);
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "genocide")
        {
            Instantiate(players[1].gameObject, gameObject.transform.position, Quaternion.identity);
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "neytral")
        {
            Instantiate(players[0].gameObject, gameObject.transform.position, Quaternion.identity);
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "hero")
        {
            Instantiate(players[2].gameObject, gameObject.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
