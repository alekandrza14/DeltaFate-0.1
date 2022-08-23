using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers1 : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.GetString("rejim", "pacifist") == "pacifist")
        {
            gameObject.SetActive(false);
        }
        
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("rs", 0) >= 2)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D s)
    {
        if (s.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("rs", 0) == 0)
            {
                PlayerPrefs.SetInt("rs", 1);
                
            }

        }
    }


}
