using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim18 : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public int tic;
    public GameObject Character;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("ch1", "") == "reynor")
        {
            if (Character.GetComponent<igrok>().playcharacter == 1 && Input.GetKey(KeyCode.W))
            {
                Character.GetComponent<igrok>().playcharacter = 0;
            }
            if (Character.GetComponent<igrok>().playcharacter == 0 && Input.GetKey(KeyCode.S))
            {
                Character.GetComponent<igrok>().playcharacter = 1;
            }
            if (Character.GetComponent<igrok>().playcharacter == 1)
            {
                object1.GetComponent<SpriteRenderer>().color = Color.white;
                object2.GetComponent<SpriteRenderer>().color = Color.grey;
            }
            if (Character.GetComponent<igrok>().playcharacter == 0)
            {
                object2.GetComponent<SpriteRenderer>().color = Color.white;
                object1.GetComponent<SpriteRenderer>().color = Color.grey;
            }

        }

        if (PlayerPrefs.GetString("ch1", "") == "")
        {
            if (Character.GetComponent<igrok>().playcharacter == 0)
            {
                object2.GetComponent<SpriteRenderer>().color = Color.white;
                object1.GetComponent<SpriteRenderer>().color = new Color(0,0,0,0);
            }
            if (Character.GetComponent<igrok>().playcharacter == 1)
            {
                object1.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                object2.GetComponent<SpriteRenderer>().color = Color.white;
            }

        }
    }
    
}
