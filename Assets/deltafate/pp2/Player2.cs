using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public GameObject cam;
    
    public Text txt;
    public Sprite[] sprite;
    public Sprite[] sprite1;
    public Sprite[] sprite2;
    public Sprite[] sprite3;
    public Sprite[] sprite4;
    public Sprite[] sprite5;
    public Sprite[] sprite6;
    public Sprite[] sprite7;
    public Sprite[] sprite8;
    
    public int tic;
    public int time;
    public int time2;
    public int rotation;
    public bool isMove;
    public Vector2 velosity;
    public Rigidbody2D rigidbody2;
    public float i;
    public float i2;
    public float i3;
    public int tir;
    public save s = new save();
    public save s2 = new save();
    public save s6 = new save();
    public saveload s3 = new saveload();
    public int level;
    public string name1;
    public bool camdown;
    public float attacktime;
    public bool t = false;
    public RawImage t6;
    public RawImage t1;
    public RawImage t5;
    public AudioListener t2;
    public GameObject g;
    public GameObject g2;
    public items s1 = new items();
    public items s5 = new items();
    public float dist = 40;
    public bool ishenry;
    public debug d = new debug();


    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    private void Start()
    {
        if(File.Exists("res/speed"))
        {


            i = int.Parse(File.ReadAllText("res/speed"));
            i2 = int.Parse(File.ReadAllText("res/speed"));
        }
        PlayerPrefs.SetString("text", "");

        if (!ishenry)
        {


            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
            {
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));



            }
        }
        if (ishenry)
        {
            if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
            {
                s5 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



            }
            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
            {
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));



            }
        }
        if (PlayerPrefs.GetInt("1", 0) == 1)
        {

            t = true;
        }
        if (PlayerPrefs.GetInt("1", 0) == 0)
        {
            t = false;
        }
        

        if (GameObject.FindGameObjectsWithTag("Player").Length != 2)
        {
            
                PlayerPrefs.SetInt("1", 0);

            if (g != null)
            {
                if (PlayerPrefs.GetInt("ts", 0) == 1)
                {
                    Vector3 s3 = new Vector3();
                    if (File.Exists(@"DELTAFATE/sarux/position.un"))
                    {
                        s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/sarux/position.un"));
                        name1 = s2.name;
                        level = s2.level;
                        if (s2.enter[SceneManager.GetActiveScene().buildIndex] == true)
                        {


                            s3 = s2.v3[SceneManager.GetActiveScene().buildIndex];
                            Instantiate(g, s3, Quaternion.identity);
                            Destroy(gameObject);
                        }
                        else
                        {
                            Instantiate(g, transform.position, Quaternion.identity);
                            Destroy(gameObject);
                        }
                    }


                }
            }
            if (g2 != null)
            {
                if (PlayerPrefs.GetInt("ts", 0) == 2)
                {
                    Vector3 s3 = new Vector3();
                    if (File.Exists(@"DELTAFATE/siji/position.un"))
                    {
                        s2 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));
                        name1 = s2.name;
                        level = s2.level;
                        if (s2.enter[SceneManager.GetActiveScene().buildIndex] == true)
                        {


                            s3 = s2.v3[SceneManager.GetActiveScene().buildIndex];
                            Instantiate(g2, s3, Quaternion.identity);
                            Destroy(gameObject);
                        }
                        else
                        {
                            Instantiate(g2, transform.position, Quaternion.identity);
                            Destroy(gameObject);
                        }
                    }


                }
            }
            if (g != null)
            {
                if (PlayerPrefs.GetInt("s1", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("r1", 0) == 1)
                    {
                        if (PlayerPrefs.GetInt("ts", 0) == 0)
                        {
                            Instantiate(g, transform.position, Quaternion.identity);
                        }

                    }
                }
            }
            if (g2 != null)
            {
                if (PlayerPrefs.GetInt("s1", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("r1", 0) == 1)
                    {
                        if (PlayerPrefs.GetInt("ts", 0) == 2)
                        {
                            Instantiate(g2, transform.position, Quaternion.identity);
                        }

                    }
                }
            }
        }
        if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
        {
            

            
            if (t1 != null)
            {

                if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
                {
                    t1.gameObject.SetActive(!t);
                }
            }
        }
        t2 = GameObject.FindObjectsOfType<Player2>()[0].cam.GetComponent<AudioListener>();
        attacktime = PlayerPrefs.GetFloat("attack", 0);
        if (!ishenry)
        {
            if (File.Exists(@"DELTAFATE/siji/position.un"))
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));
                name1 = s.name;
                level = s.level;
                if (s.enter[SceneManager.GetActiveScene().buildIndex] == true)
                {


                    transform.position = s.v3[SceneManager.GetActiveScene().buildIndex];
                }
            }

        }
        if (ishenry)
        {
            if (File.Exists(@"DELTAFATE/henry/position.un"))
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));
                s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));
                if (name1 != "team star")
                {


                    name1 = s6.name;
                }
                level = s6.level;
                if (s6.enter[SceneManager.GetActiveScene().buildIndex] == true)
                {


                    transform.position = s6.v3[SceneManager.GetActiveScene().buildIndex];
                }
            }

        }
        if (!File.Exists(@"DELTAFATE/siji/position.un"))
        {
            name1 = "siji";
            level = 0;
            s.name = name1;
            s.level = level;
        }
        if (ishenry) 
        {
            if (!File.Exists(@"DELTAFATE/henry/position.un"))
            {
                if (name1 == "team star")
                {
                    name1 = "team star";
                    level = 0;
                    s.name = name1;
                    s.level = level;
                }
            }
        }
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/siji");
        File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));
        if (ishenry)
        {
            Directory.CreateDirectory("DELTAFATE");
            Directory.CreateDirectory(@"DELTAFATE/henry");
            
            File.WriteAllText(@"DELTAFATE/henry/position.un", JsonUtility.ToJson(s6));
        }
        int lvl;
        lvl = level;
        lvl /= 2000 + s.level / 60;
        txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();

    }
    private void Update()
    {


        Player.updata(transform.position, d);
        if (PlayerPrefs.GetInt("r1", 0) == 1)
        {

            if (GameObject.FindGameObjectsWithTag("Player").Length != 2)
            {
                t = false;
                PlayerPrefs.SetInt("1", 0);
                
            }
            if (GameObject.FindGameObjectsWithTag("Player").Length != 2)
            {
                if (Input.GetKeyDown(KeyCode.F3))
                {
                    if (PlayerPrefs.GetInt("1", 0) == 0)
                    {
                        PlayerPrefs.SetInt("ts", 1);
                    }
                    Instantiate(g, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }

            }
            if (GameObject.FindGameObjectsWithTag("Player").Length != 2)
            {
                if (Input.GetKeyDown(KeyCode.F4))
                {
                    PlayerPrefs.SetInt("s1", 1);
                    Instantiate(g, transform.position, Quaternion.identity);

                }
            }
        }
        if (s.level / 2000 > tish.maxlevel)
        {
            s.level = tish.maxlevel * 2000;
            File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));
        }
        if (cam.GetComponent<Camera>().orthographicSize <= 283.4498f)
        {


            if (Input.GetKeyDown(KeyCode.F1))
            {
                cam.GetComponent<Camera>().orthographicSize *= 1.1f;
            }
        }
        if (cam.GetComponent<Camera>().orthographicSize >= 61.6869f)
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                cam.GetComponent<Camera>().orthographicSize /= 1.1f;
            }

        }
        int f = -1;
        if (!ishenry)
        {

           
            for (int i = 0; i < s1.itemid.Count; i++)
            {
                if (s1.itemid[i] > f)
                {
                    f = s1.itemid[i];

                }

            }

        }
        
       




        playermenager.p1shot(s1, gameObject, 1);

        if (!File.Exists(@"DELTAFATE/unauticna/seed2.un"))
        {
            Directory.CreateDirectory(@"DELTAFATE/unauticna");
            
            File.WriteAllText(@"DELTAFATE/unauticna/seed2.un", Random.Range(-1000, 500).ToString());

            s.level += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed2.un"));
            File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));
        }
        
        if (!Input.GetKey(KeyCode.Space))
        {
            i = i2;
        }
        if (Input.GetKey(KeyCode.F11))
        {
            s3.level = s.level; s3.enter = s.enter; s3.idscene = s.idscene; s3.v3 = s.v3; s3.name = s.name;
            File.WriteAllText(@"DELTAFATE/unauticna/position.un", JsonUtility.ToJson(s3));

        }
        if (Input.GetKey(KeyCode.F12) && !Input.GetKey(KeyCode.R))
        {
            s3 = JsonUtility.FromJson<saveload>(File.ReadAllText(@"DELTAFATE/unauticna/position.un"));
            level = s3.level;

            if (File.Exists(@"DELTAFATE/unauticna/position.un"))
            {
                s3 = JsonUtility.FromJson<saveload>(File.ReadAllText(@"DELTAFATE/unauticna/position.un"));
                name1 = s3.name;
                level = s3.level;
                if (s3.enter[SceneManager.GetActiveScene().buildIndex] == true)
                {


                    transform.position = s3.v3[SceneManager.GetActiveScene().buildIndex];
                }
            }

        }
        if (Input.GetKey(KeyCode.F12) && Input.GetKey(KeyCode.R))
        {
            s3 = JsonUtility.FromJson<saveload>(File.ReadAllText(@"DELTAFATE/unauticna/position.un"));

            SceneManager.LoadScene(s3.idscene);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            tic++;
            i = i3;
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.Mouse1))
        {
            isMove = false;
        }
        if (!ishenry)
        {
            if (File.Exists(@"DELTAFATE/siji/position.un"))
            {

                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));



                name1 = s.name;

                level = s.level;
                int lvl;
                lvl = level;
                lvl /= 2000 + s.level / 60;
                lvl += 11;
                txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();

            }
        }
        if (ishenry)
        {
            if (File.Exists(@"DELTAFATE/henry/position.un"))
            {

                s6 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));


                if (name1 != "team star")
                {

                    name1 = s6.name;
                }

                level = s6.level;
                int lvl;
                lvl = level;
                lvl /= 2000 + s6.level / 60;
                lvl += 11;
                txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();

            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            t = !t;
            if (!t)
            {
                t6.enabled = true;
                PlayerPrefs.SetInt("1", 1);
            }
            if (t)
            {
                t6.enabled = false;
                PlayerPrefs.SetInt("1", 0);
            }
        }
        if (g != null)
        {
            if (PlayerPrefs.GetInt("r1", 0) == 0)
            {
                if (PlayerPrefs.GetInt("1", 0) == 0)
                {
                    if (PlayerPrefs.GetInt("21", 0) == 1)
                    {

                        t = false;
                    }
                    if (PlayerPrefs.GetInt("21", 0) == 0)
                    {
                        t = false;
                    }

                }
                else if (PlayerPrefs.GetInt("1", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("21", 0) == 0)
                    {
                        t = false;
                    }
                    if (PlayerPrefs.GetInt("21", 0) == 1)
                    {
                        t = true;
                    }
                }

            }

        }
        
        velosity = Vector3.zero;
        AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
        Move(rigidbody2, velosity, isMove);

        if (Input.GetKey(KeyCode.Z))
        {
            if (!t)
            {


                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x - dist >= transform.position.x)
                {

                    velosity += new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x + dist <= transform.position.x)
                {
                    velosity += new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y - dist >= transform.position.y)
                {
                    velosity += new Vector2(0, i);
                    isMove = true;
                    rotation = 0;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y + dist <= transform.position.y)
                {
                    velosity += new Vector2(0, -i);
                    isMove = true;
                    rotation = 2;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }


            }
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {

            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x - dist >= transform.position.x)
            {

                velosity += new Vector2(i, 0);
                isMove = true;
                rotation = 1;
                Move(rigidbody2, velosity, isMove);
                AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
            }
            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x + dist <= transform.position.x)
            {
                velosity += new Vector2(-i, 0);
                isMove = true;
                rotation = 3;
                Move(rigidbody2, velosity, isMove);
                AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
            }
            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y - dist >= transform.position.y)
            {
                velosity += new Vector2(0, i);
                isMove = true;
                rotation = 0;
                Move(rigidbody2, velosity, isMove);
                AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
            }
            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y + dist <= transform.position.y)
            {
                velosity += new Vector2(0, -i);
                isMove = true;
                rotation = 2;
                Move(rigidbody2, velosity, isMove);
                AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
            }


        }




        
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerPrefs.SetInt("r1", 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {
                PlayerPrefs.SetInt("r1", 1);
            }
        }
        
        
       

        if (g != null)
        {
            if (t1 != null)
            {
                if (PlayerPrefs.GetInt("r1", 0) == 1)
                {
                    t1.gameObject.SetActive(t);
                    if (t5 != null)
                    {
                        t5.gameObject.SetActive(t);
                    }
                    t2.enabled = !t;
                }
            }
        }





        level += PlayerPrefs.GetInt("upxp", 0);
        PlayerPrefs.SetInt("upxp", 0);

        attacktime += 1 * 60 * Time.fixedDeltaTime;
        PlayerPrefs.SetFloat("attack", attacktime);
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
       
            s.level = level;
        
        s.v3[SceneManager.GetActiveScene().buildIndex] = transform.position;
        s.enter[SceneManager.GetActiveScene().buildIndex] = true;
        s.idscene = SceneManager.GetActiveScene().buildIndex;
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/siji");
        File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));
       



        tic++;
        
            if (t)
            {
                // w
                if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(0, i);
                    isMove = true;
                    rotation = 0;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // d
                if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // s
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(0, -i);
                    isMove = true;
                    rotation = 2;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // a
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // sa
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(-i, -i);
                    isMove = true;
                    rotation = 4;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // sd
                if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(i, -i);
                    isMove = true;
                    rotation = 5;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // wa
                if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(-i, i);
                    isMove = true;
                    rotation = 6;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // wd
                if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity = new Vector2(i, i);
                    isMove = true;
                    rotation = 7;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // none
                

            }
            if (!t)
            {
                // w
                if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(0, i);
                    isMove = true;
                    rotation = 0;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // d
                if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // s
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(0, -i);
                    isMove = true;
                    rotation = 2;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // a
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // sa
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(-i, -i);
                    isMove = true;
                    rotation = 4;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // sd
                if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(i, -i);
                    isMove = true;
                    rotation = 5;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // wa
                if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(-i, i);
                    isMove = true;
                    rotation = 6;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // wd
                if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {
                    velosity = new Vector2(i, i);
                    isMove = true;
                    rotation = 7;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                // none
                
            }
        


    }
    public void Move(Rigidbody2D rigidbody,Vector2 vector2D,bool isMove)
    {
        if (rigidbody != null)
        {
            if (isMove == true)
            {
                rigidbody.velocity = new Vector2(0, 0);
                rigidbody.velocity += new Vector2(vector2D.x, vector2D.y);
            }
            if (isMove == false)
            {
                rigidbody.velocity = new Vector2(0, 0);
            }
        }
    }
    public void AnimationMove(SpriteRenderer spriteRenderer, Sprite[] sprite, Sprite[] sprite1, Sprite[] sprite2, int rotation, bool isMove, int time, int time2)
    {
        if (spriteRenderer != null)
        {
            
            if (isMove != true)
            {
                
                if (rotation == 0)
                {
                    spriteRenderer.sprite = sprite[0];
                }
                if (rotation == 1)
                {
                    spriteRenderer.sprite = sprite[1];
                }
                if (rotation == 2)
                {
                    spriteRenderer.sprite = sprite[2];
                }
                if (rotation == 3)
                {
                    spriteRenderer.sprite = sprite[3];
                }
                if (rotation == 4)
                {
                    spriteRenderer.sprite = sprite[4];
                }
                if (rotation == 5)
                {
                    spriteRenderer.sprite = sprite[5];
                }
                if (rotation == 6)
                {
                    spriteRenderer.sprite = sprite[0];
                }
                if (rotation == 7)
                {
                    spriteRenderer.sprite = sprite[0];
                }
            }
            if (isMove != false)
            {

                if (tic > time)
                {
                    camdown = !camdown;
                    tir++;
                }
                if (!camdown)
                {
                    cam.transform.localPosition = new Vector3(0,1,-100);
                }
                if (camdown)
                {
                    cam.transform.localPosition = new Vector3(0, -1, -100);
                }
                if (rotation == 0)
                {

                    if (tic > time)
                    {
                        if (tir >= sprite1.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite1[tir];
                        
                        tic = 0;
                        

                    }
                }
                if (rotation == 1)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite2.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite2[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 2)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite3.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite3[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 3)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite4.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite4[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 4)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite5.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite5[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 5)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite6.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite6[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 6)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite7.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite7[tir];
                        
                        tic = 0;
                    }
                }
                if (rotation == 7)
                {
                    
                    if (tic > time)
                    {
                        if (tir >= sprite8.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = sprite8[tir];
                        
                        tic = 0;
                    }
                }
            }
        }
    }
}

