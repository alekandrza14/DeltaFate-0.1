using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class zombie : MonoBehaviour
{
    public Vector2 rand;
    public int hp = 40;
    public int maxhp = 40;
    public float tic;
    public GameObject ps;
    public GameObject dead;
    public save s1 = new save();
    public int id = 14;
    public bool s2;
    public int xp = 200;
    public string pp = "mesto0-1";
    public string pp2 = "mesto0-1";
    public int maxcount = 10;
    public bool perplayer = true;
    public float s = 20;
    public float mindis = 80;
    GameObject s22;
    public bool isdist;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void hight()
    {
        s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
        s = s * 2;
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "1")
        {
            hp = 0;
        }
        if (s.tag == "bmp")
        {
            hp -= 100000;
        }
        if (s.tag == "error")
        {
            hp -= 20000;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (PlayerPrefs.GetInt(pp,0) >= maxcount)
        {
            PlayerPrefs.SetInt(pp2+"x",1);
            Destroy(gameObject);
        }
        if (Directory.Exists("debug"))
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                PlayerPrefs.SetInt(pp, maxcount);
            }
        }
        GetComponent<Rigidbody2D>().velocity = rand;
        tic += 1 * Time.deltaTime;
        if (tic >= 20)
        {
            s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length-1)];
            rand.x = Random.Range(-s, s + 1);
            rand.y = Random.Range(-s, s + 1);
            tic = 0;
        }
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
        {
            if(hp < 1)
            {
                PlayerPrefs.SetInt(pp, PlayerPrefs.GetInt(pp, 0)+1);
                PlayerPrefs.SetInt("upxp", xp);
                if (ps)
                {


                    Instantiate(ps.gameObject, transform.position, transform.rotation);
                    Instantiate(dead.gameObject, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }


            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {


                if (Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Player")[0].transform.position) >= 400 && Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Player")[1].transform.position) >= 400)
                {
                    hp = maxhp;
                }
            }
            if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
            {
                if (Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Player")[0].transform.position) >= 400)
                {
                    hp = maxhp;
                }
            }


        }
        if (s2 == false)
        {


            if (PlayerPrefs.GetFloat("attack", 0) >= 1000)
            {
                for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
                {
                    if (Vector3.Distance(transform.position, GameObject.FindGameObjectsWithTag("Player")[i].transform.position) < 40)
                    {

                        SceneManager.LoadScene(id);
                    }
                }
            }

        }

        if (s22)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length != 0 && perplayer )
            {
                if (Vector3.Distance(transform.position, s22.transform.position) < 400 && isdist)
                {


                    //  s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
                    if (s22.transform.position.x - mindis >= transform.position.x)
                    {

                        GetComponent<Rigidbody2D>().velocity = new Vector2(s, 0);

                    }
                    if (s22.transform.position.x + mindis <= transform.position.x)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-s, 0);
                    }
                    if (s22.transform.position.y - mindis >= transform.position.y)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, s);
                    }
                    if (s22.transform.position.y + mindis <= transform.position.y)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -s);
                    }
                }
                if (!isdist)
                {


                    //  s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
                    if (s22.transform.position.x - mindis >= transform.position.x)
                    {

                        GetComponent<Rigidbody2D>().velocity = new Vector2(s, 0);

                    }
                    if (s22.transform.position.x + mindis <= transform.position.x)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-s, 0);
                    }
                    if (s22.transform.position.y - mindis >= transform.position.y)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, s);
                    }
                    if (s22.transform.position.y + mindis <= transform.position.y)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -s);
                    }
                }


            }
        }
    }


}

