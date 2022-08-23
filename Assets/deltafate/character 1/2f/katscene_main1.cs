using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class katscene_main1 : MonoBehaviour
{
    public string charakter;
    public Sprite[] anim;
    public float tic1;
    public float tic2;
    public float tic3;
    public int time1;
    public int time2;
    public int time3;
    public int time4;
    public int time5;
    public int time6;
    public int time7;
    public Rigidbody2D Rigidbody2Ds;
    public GameObject[] t1;
    public Player23[] players;
    public GameObject curplayer;
    private void Start()
    {
        players = GameObject.FindObjectsOfType<Player23>();
        curplayer = players[Random.Range(0, players.Length)].gameObject;
    }

    void Update()
    {
       
        if (t1[0].transform.position.y >= transform.position.y)
        {
            transform.position = t1[3].transform.position;
        }


        if (PlayerPrefs.GetString(charakter, "") == "done")
        {
            
            PlayerPrefs.SetInt(charakter + "1", 1);
        }
        if (PlayerPrefs.GetInt("c", 0) == 1 || PlayerPrefs.GetInt("c", 0) == 3)
        {
            if (PlayerPrefs.GetInt(charakter + "1", 0) == 1)
            {
                if (curplayer.gameObject.transform.position.x - 40 >= transform.position.x)
                {
                    Rigidbody2Ds.AddForce(new Vector2(20000000, 0));
                    GetComponent<SpriteRenderer>().flipX = false;
                }
                if (curplayer.gameObject.transform.position.x + 40 <= transform.position.x)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                    Rigidbody2Ds.AddForce(new Vector2(-20000000, 0));
                }
                tic1 += 1 * Time.deltaTime;
                tic2 += 1 * Time.deltaTime;
                if (tic1 <= 1f)
                {
                    Rigidbody2Ds.AddForce(new Vector2(0, 2000000));

                    GetComponent<SpriteRenderer>().sprite = anim[2];
                }
                if (tic2 >= 500)
                {
                    curplayer = players[Random.Range(0, players.Length)].gameObject;
                }
            }

        }        
        
    }
    public void OnCollisionStay2D(Collision2D s)
    {

        if (s.gameObject.tag == "terrain")
        {
            GetComponent<SpriteRenderer>().sprite = anim[1];
            tic1 = 0;
        }
        if (s.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetInt("c", 0) == 1)
            {
                SceneManager.LoadScene("fight6");
            }
            if (PlayerPrefs.GetInt("c", 0) == 3)
            {
                SceneManager.LoadScene("fight7");
            }
        }
    }
}
