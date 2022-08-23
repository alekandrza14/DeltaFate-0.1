using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class zombie1 : MonoBehaviour
{
    public Vector2 rand;
    public long hp = long.MaxValue;
    public long maxhp = long.MaxValue;
    public float tic;
    public GameObject ps;
    public GameObject dead;
    public GameObject zombie;
    public long fin;
    public save s1 = new save();
    public int id = 14;
    public bool s2;
    public int xp = 200;
    public string pp = "mesto0-1";
    public string pp2 = "mesto0-1";
    public int maxcount = 10;
    public bool perplayer = true;
    public float s = 20;
    GameObject s22;
    public AudioSource ass;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("dif", 0) == 4)
        {
            hp = savevartous.usvarl(@"DELTAFATE/var/errorhp.long", hp);
        }
        if (File.Exists(@"DELTAFATE/var/errorhp.long"))
        {


            fin = savevartous.usvarl(@"DELTAFATE/var/errorhp.long", hp);
        }
        else
        {
            fin = 1;
        }
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
    }

    // Update is called once per frame
    public void startUpdate()
    {
        hp = maxhp;
        PlayerPrefs.SetInt("dif", 4);
    }
    void Update()
    {
        if (fin <= 0)
        {
            Destroy(gameObject);
        }
        // enddil
        if (PlayerPrefs.GetInt("enddil", 0) == 1)
        {
            hp = maxhp;
            PlayerPrefs.SetInt("dif", 4);
            PlayerPrefs.SetInt("enddil", 0);
        }
        if (PlayerPrefs.GetInt("dif",0) == 4)
        {
            ass.enabled = true;
            savevartous.setusvarlong(@"DELTAFATE/var/errorhp.long",false,hp);

            if (PlayerPrefs.GetInt(pp, 0) >= maxcount)
            {
                PlayerPrefs.SetInt(pp2 + "x", 1);
                Destroy(gameObject);
            }
            if (Directory.Exists("debug"))
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    PlayerPrefs.SetInt(pp, maxcount);
                }
            }
            GetComponent<Rigidbody2D>().velocity = rand;
            tic += 1 * Time.deltaTime;
            if (tic >= 0.2)
            {
                s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
                Instantiate(zombie.gameObject, transform.position, transform.rotation);
                if (transform.position.y > -205)
                {


                    rand.x = Random.Range(-1000, 1001);
                    rand.y = Random.Range(-1000, 1001);
                }
                else
                {
                    rand.y = Random.Range(0, 1001);
                }
                tic = 0;
            }
            if (tic >= 1)
            {
                s22 = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation); 
                Instantiate(zombie.gameObject, transform.position, transform.rotation);
                Instantiate(zombie.gameObject, transform.position, transform.rotation);

                if (transform.position.y > -205)
                {


                    rand.x = Random.Range(-100, 101);
                    rand.y = Random.Range(-100, 101);
                }
                else
                {
                    rand.y = Random.Range(0, 101);
                }
                tic = 0;
            }
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (hp < 1)
                {
                    PlayerPrefs.SetInt(pp, PlayerPrefs.GetInt(pp, 0) + 1);
                    PlayerPrefs.SetInt("soul_error", 1);
                    PlayerPrefs.SetInt("upxp", xp);
                    if (ps)
                    {


                        Instantiate(ps.gameObject, transform.position, transform.rotation);
                        Instantiate(dead.gameObject, transform.position, transform.rotation);
                    }
                    Destroy(gameObject);
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


                        }
                    }
                }

            }
            
            if (GameObject.FindGameObjectsWithTag("Player").Length != 0 && perplayer && s22)
            {
                
                if (s22.transform.position.x - 80 >= transform.position.x)
                {

                    GetComponent<Rigidbody2D>().velocity = new Vector2(s, 0);

                }
                if (s22.transform.position.x + 80 <= transform.position.x)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-s, 0);
                }
                if (s22.transform.position.y - 80 >= transform.position.y)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, s);
                }
                if (s22.transform.position.y + 80 <= transform.position.y)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -s);
                }

            }
        }
    }


}

