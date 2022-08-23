using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers2 : MonoBehaviour
{
    public AudioSource s1;
    public AudioClip s2;
    void Start()
    {
        if (PlayerPrefs.GetString("rejim","pacifist") == "pacifist")
        {
            gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "neytral")
        {


            gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetString("rejim", "pacifist") == "genocide")
        {

            gameObject.SetActive(true);

        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("rs", 0) == 3)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D s)
    {
        if (s.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("rs", 0) == 2)
            {
                s1.clip = s2;
                s1.Play();

                PlayerPrefs.SetInt("rs", 3);
            }
        }
    }


}
