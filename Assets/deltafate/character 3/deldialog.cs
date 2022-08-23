using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deldialog : MonoBehaviour
{
    public GameObject button;
    public string del;
    void Start()
    {
        PlayerPrefs.SetInt("delbutton" + del, 0);
        button.SetActive(false);
    }

    
    void Update()
    {
        if (PlayerPrefs.GetInt("delbutton" + del, 0) == 1)
        {
            button.SetActive(true);
            Debug.Log(1);
        }
        else
        {
            button.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        Debug.Log(1);
        if (s.tag == "Player")
        {
            Debug.Log(1);
            PlayerPrefs.SetInt("delbutton" + del, 1);
        }
    }
    private void OnTriggerExit2D(Collider2D s)
    {
        if (s.tag == "Player")
        {
            PlayerPrefs.SetInt("delbutton" + del, 0);
        }
    }
}
