using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class playertop : MonoBehaviour
{
    public float offset;
    public GameObject spriteplayer;
    public float tic;
    public float tic0;
    public float tic1;
    public int tir;
    public Sprite[] sp;
    public Rigidbody2D rd;
    public int i;
    public save s = new save();
    public items s1 = new items();
    public save s2 = new save();
    public save s6 = new save();
    public int level;
    public Text txt;
    public string name1;
    public bool camdown;
    public float attacktime;
    public bool ishenry;
    public bool issiji;
    public bool issarux;
    public debug d = new debug();
    void Start()
    {
        if(File.Exists("res/speed"))
        {


            i = int.Parse(File.ReadAllText("res/speed"));
        }
        PlayerPrefs.SetString("text", "");
        if (ishenry)
        {

            if (File.Exists(@"DELTAFATE/henry1/position.un"))
            {

                s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));

                level = s6.level;
                if (s6.enter[SceneManager.GetActiveScene().buildIndex] == true)
                {


                    transform.position = s6.v3[SceneManager.GetActiveScene().buildIndex];
                }
            }

        
        }
        if (issiji)
        {
            

                    if (File.Exists(@"DELTAFATE/siji0/position.un"))
                    {

                        s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji0/position.un"));

                        level = s6.level;
                        if (s6.enter[SceneManager.GetActiveScene().buildIndex] == true)
                        {


                            transform.position = s6.v3[SceneManager.GetActiveScene().buildIndex];
                        }
                    }

             

        }
    }
    public void move()
    {
        
        if (tir > sp.Length)
        {
            tir = 0;
        }
        rd.velocity = Vector2.zero;
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - spriteplayer.transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        spriteplayer.transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (Input.GetKey(KeyCode.W))
        {
            rd.velocity += new Vector2(spriteplayer.transform.right.x, spriteplayer.transform.right.y) * i;

            tic += 1 * Time.deltaTime; tic0 += 1 * Time.deltaTime;

            if (tic >= 0.5f)
            {
                
                if (tir < sp.Length)
                {
                    spriteplayer.GetComponent<SpriteRenderer>().sprite = sp[tir];
                }
                tir++;
                tic = 0;
            }


        }
        if (Input.GetKey(KeyCode.S))
        {
            rd.velocity -= new Vector2(spriteplayer.transform.right.x, spriteplayer.transform.right.y) * i;

            tic += 1 * Time.deltaTime; tic0 += 1 * Time.deltaTime;

            if (tic >= 0.5f)
            {
                
                if (tir < sp.Length)
                {
                    spriteplayer.GetComponent<SpriteRenderer>().sprite = sp[tir];
                }
                tir++;
                tic = 0;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            rd.velocity -= new Vector2(spriteplayer.transform.up.x, spriteplayer.transform.up.y) * i;

            tic += 1 * Time.deltaTime; tic0 += 1 * Time.deltaTime;

            if (tic >= 0.5f)
            {
                
                if (tir < sp.Length)
                {
                    spriteplayer.GetComponent<SpriteRenderer>().sprite = sp[tir];
                }
                tir++;
                tic = 0;
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            rd.velocity += new Vector2(spriteplayer.transform.up.x, spriteplayer.transform.up.y) * i;

            tic += 1 * Time.deltaTime; tic0 += 1 * Time.deltaTime;

            if (tic >= 0.5f)
            {
                
                if (tir < sp.Length)
                {
                    spriteplayer.GetComponent<SpriteRenderer>().sprite = sp[tir];
                }
                tir++;

                tic = 0;
            }

        }
        if (Input.GetKey(KeyCode.Space))
        {


            tic1 += 1 * Time.deltaTime;

            if (tic1 <= 0.6f)
            {
                if (spriteplayer.transform.localScale.x < Vector3.one.x * 2f)
                {
                    spriteplayer.transform.localScale += Vector3.one * 0.8f * Time.deltaTime;
                }
            }
            if (tic1 >= 0.6f && spriteplayer.transform.localScale.x == Vector3.one.x)
            {
                tic1 = 0;

            }
            

        }
        if(!Input.GetKey(KeyCode.Space))
        {
            if (spriteplayer.transform.localScale.x >= Vector3.one.x)
            {


                spriteplayer.transform.localScale -= Vector3.one * 1.6f * Time.deltaTime;
            }
        }
        if (spriteplayer.transform.localScale.x >= Vector3.one.x)
        {


            spriteplayer.transform.localScale -= Vector3.one * 0.1f * Time.deltaTime;
        }
        if (spriteplayer.transform.localScale.x < Vector3.one.x)
        {


            spriteplayer.transform.localScale = Vector3.one;
        }
        //tic1 += 1 * Time.deltaTime;
    }


    void Update()
    {

        if (Directory.Exists("debug") && Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Instantiate(Resources.Load<GameObject>("your au/sans_ee"), transform.position, Quaternion.identity);
        }
        Player.updata(transform.position, d);
        jump();
        move();
        if (ishenry)
        {
            if (File.Exists(@"DELTAFATE/henry1/position.un"))
            {


                s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry1/position.un"));
                s6.name = "team star";



                level = s6.level;
                int lvl;
                lvl = level;
                lvl /= 2000 + s.level / 20;
                lvl += 11;
                if (PlayerPrefs.GetInt("gunr", -1) != -1)
                {
                    txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString() + " п :" + s1.patrons[PlayerPrefs.GetInt("gunr", 0)];
                }
                else
                {
                    txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();
                }

            }
        }
        if (issiji)
        {
            if (File.Exists(@"DELTAFATE/siji0/position.un"))
            {


                s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji0/position.un"));


                s6.name = "team star";


                level = s6.level;
                int lvl2;
                lvl2 = level;
                lvl2 /= 2000 + s.level / 20;
                lvl2 += 11;
                txt.text = "Уровень : " + lvl2.ToString() + " оп :" + level.ToString();

            }
        }
        if (ishenry)
        {
            attacktime += 1 * 60 * Time.fixedDeltaTime;
            PlayerPrefs.SetFloat("attack", attacktime);
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

            s6.name = name1;
            s6.v3[SceneManager.GetActiveScene().buildIndex] = transform.position;
            s6.enter[SceneManager.GetActiveScene().buildIndex] = true;
            s6.idscene = SceneManager.GetActiveScene().buildIndex;
            Directory.CreateDirectory("DELTAFATE");
            
                    Directory.CreateDirectory(@"DELTAFATE/henry1");


                    File.WriteAllText(@"DELTAFATE/henry1/position.un", JsonUtility.ToJson(s6));
              

        }
        if (issiji)
        {
            attacktime += 1 * 60 * Time.fixedDeltaTime;
            PlayerPrefs.SetFloat("attack", attacktime);
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

            s6.name = name1;
            s6.v3[SceneManager.GetActiveScene().buildIndex] = transform.position;
            s6.enter[SceneManager.GetActiveScene().buildIndex] = true;
            s6.idscene = SceneManager.GetActiveScene().buildIndex;
            Directory.CreateDirectory("DELTAFATE");
            
                    Directory.CreateDirectory(@"DELTAFATE/siji0");


                    File.WriteAllText(@"DELTAFATE/siji0/position.un", JsonUtility.ToJson(s6));
              

        }
    }
    public void jump()
    {
        if (spriteplayer.transform.localScale.x > Vector3.one.x * 1.2f)
        {
            for (int x = 0; x < GameObject.FindGameObjectsWithTag("1").Length; x++)
            {


                GameObject.FindGameObjectsWithTag("1")[x].GetComponent<BoxCollider2D>().isTrigger = true;

            }
        }
        if (spriteplayer.transform.localScale.x <= Vector3.one.x * 1.2f)
        {
            for (int x = 0; x < GameObject.FindGameObjectsWithTag("1").Length; x++)
            {


                GameObject.FindGameObjectsWithTag("1")[x].GetComponent<BoxCollider2D>().isTrigger = false;

            }
        }
    }

}
