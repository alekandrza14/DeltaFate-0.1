using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class debug 
{
    public static string[] ptchfiles = new string[2]
    { 
        "debug/log.un","debug/mods.un"
    };
    public string log;
    

}


public class Player : MonoBehaviour
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
    public int tir;
    public save s = new save();
    public save si = new save();
    public int level;
    public string name1;
    public bool camdown;
    public float attacktime;
    public bool t = false;
    public bool t4 = false;
    public RawImage t1;
    public RawImage t5;
    public AudioListener t2;
    public GameObject g;
    public items s1 = new items();
    public float dist = 40;
    public bool platorming;
    public saveload s3 = new saveload();
    

    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    private void Start()
    {
        if (File.Exists("res/speed"))
        {


            i = int.Parse(File.ReadAllText("res/speed"));
        }
        PlayerPrefs.SetString("text", "");
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



        }
        if (PlayerPrefs.GetInt("f", 0) == 1)
        {

            t = false;
        }
        if (PlayerPrefs.GetInt("f", 0) == 0)
        {
            t = true;
        }
        if (PlayerPrefs.GetInt("21", 0) == 1)
        {

            t4 = true;
        }
        if (PlayerPrefs.GetInt("21", 0) == 0)
        {
            t4 = false;
        }

        if (GameObject.FindGameObjectsWithTag("Player").Length != 2)
        {
            if (g != null)
            {


                if (PlayerPrefs.GetInt("r", 0) == 1)
                {



                    Instantiate(g, transform.position, Quaternion.identity);
                }
            }
        }
        if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
        {
            
            t5 = GameObject.FindWithTag("image2").GetComponent<RawImage>();
            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {
                t1.gameObject.SetActive(t);
            }
        }
        t2 = GameObject.FindObjectsOfType<Player>()[0].cam.GetComponent<AudioListener>();
        attacktime = PlayerPrefs.GetFloat("attack", 0);
        if (File.Exists(@"DELTAFATE/henry/position.un"))
        {
            s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));
            name1 = s.name;
            level = s.level;
            if (s.enter[SceneManager.GetActiveScene().buildIndex] == true)
            {


                transform.position = s.v3[SceneManager.GetActiveScene().buildIndex];
            }
        }


        int lvl;
        lvl = level;
        lvl /= 110 + level / 20;
        lvl += 11;
        txt.text = "Уровень : " + lvl.ToString() + "оп :" + level.ToString();

        


    }
    public debug d = new debug();
    public static void updata(Vector3 position,debug d)
    {
        if (Directory.Exists("debug"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                d.log = position.ToString() + "||" + SceneManager.GetActiveScene().name + "||" + SceneManager.GetActiveScene().buildIndex;

                File.WriteAllText(debug.ptchfiles[0], JsonUtility.ToJson(d));
            }
        }
    }
    private void Update()
    {
        
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



        }
        Player.updata(transform.position,d);
        guns.update();
        if (g == null)
        {
            PlayerPrefs.SetInt("f", 0);
            PlayerPrefs.SetInt("1", 1);
            t = true;
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
        if (File.Exists(@"DELTAFATE/henry/position.un"))
        {
            si = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));
            name1 = si.name;
            level = si.level;
            int lvl;
            lvl = level;
            lvl /= 110 + level / 20;
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
        velosity = Vector3.zero;
        if (t)
        {
            if (platorming)
            {
                
                txt.text = "";
                if (Input.GetKey(KeyCode.RightArrow))
                {
                  
                   

                    velosity += new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);

                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    velosity += new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);


                }
            }

        }
        if (!t)
        {
            if (platorming)
            {
                
                if (Input.GetKey(KeyCode.D))
                {


                    velosity += new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);

                }
                if (Input.GetKey(KeyCode.A))
                {
                    velosity += new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);


                }
            }

        }
        if (platorming)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {

                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x - 40 >= transform.position.x)
                {

                    velosity += new Vector2(i, 0);
                    isMove = true;
                    rotation = 1;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
                if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x + 40 <= transform.position.x)
                {
                    velosity += new Vector2(-i, 0);
                    isMove = true;
                    rotation = 3;
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                }
            }
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.Mouse1))
        {
            isMove = false;
        }
        if (PlayerPrefs.GetInt("r", 0) == 0)
        {
            if (t5 != null)
            {
                t5.gameObject.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("r", 0) == 0)
        {
            if (t1 != null)
            {
                t1.gameObject.SetActive(false);

            }
        }

        if (!File.Exists(@"DELTAFATE/unauticna/seed.un"))
        {
            Directory.CreateDirectory(@"DELTAFATE/unauticna");
            File.WriteAllText(@"DELTAFATE/unauticna/seed.un", Random.Range(-1000, 500).ToString());
            level += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un"));
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            t4 = !t4;
            if (t4)
            {

                PlayerPrefs.SetInt("21", 1);
            }
            if (!t4)
            {
                PlayerPrefs.SetInt("21", 0);
            }
        }
        if (g != null)
        {
            if (PlayerPrefs.GetInt("r", 0) == 1)
            {
                if (PlayerPrefs.GetInt("f", 0) == 0)
                {
                    if (PlayerPrefs.GetInt("21", 0) == 0)
                    {

                        t4 = false;
                    }
                    if (PlayerPrefs.GetInt("21", 0) == 1)
                    {
                        t4 = true;
                    }

                }
                else if (PlayerPrefs.GetInt("f", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("21", 0) == 0)
                    {
                        t4 = false;
                    }
                    if (PlayerPrefs.GetInt("21", 0) == 1)
                    {
                        t4 = false;
                    }
                }

            }

        }
        
            playermenager.p1shot(s1, gameObject, 0);

        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Linecast(new Vector2(transform.position.x, transform.position.y) + Vector2.up * 30f, new Vector2(cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
            if (hit.collider != null)
            {
                if (Vector3.Distance(hit.collider.transform.position, transform.position) < 100)
                {
                    if (hit.collider.gameObject.GetComponent<zombie>() != null)
                    {
                        hit.collider.gameObject.GetComponent<zombie>().hp -= 4;

                    }

                }

            }



        }



        AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
        Move(rigidbody2, velosity, isMove);

        if (!platorming)
        {

            if (Input.GetKey(KeyCode.Mouse1))
            {
                if (!platorming)
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
            
        }




        if (PlayerPrefs.GetInt("f", 0) == 1)
        {

            t = true;
        }
        if (PlayerPrefs.GetInt("f", 0) == 0)
        {
            t = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerPrefs.SetInt("r", 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {
                PlayerPrefs.SetInt("r", 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {
                t = !t;

            }
        }

        if (t)
        {

            PlayerPrefs.SetInt("f", 1);
            PlayerPrefs.SetInt("1", 0);
        }
        if (!t)
        {
            PlayerPrefs.SetInt("f", 0);
            PlayerPrefs.SetInt("1", 1);
        }

        if (g != null)
        {
            if (t1 != null)
            {
                if (PlayerPrefs.GetInt("r", 0) == 1)
                {
                    t1.gameObject.SetActive(t);
                    t5.gameObject.SetActive(t4);
                    t2.enabled = !t;
                }
            }
        }
        if (!platorming)
        {
            if (!t)
            {
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
                if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
                {

                }
                // w
            }
            if (t)
            {
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
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                    rotation = 1;
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
                    Move(rigidbody2, velosity, isMove);
                    AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                    rotation = 7;
                }
                // none


            }

        }
        




        attacktime += 1 * 60 * Time.fixedDeltaTime;
        PlayerPrefs.SetFloat("attack", attacktime);
        level += PlayerPrefs.GetInt("upxp", 0);
        if (GameObject.FindObjectOfType<Player1>())
        {


            GameObject.FindObjectOfType<Player1>().level += PlayerPrefs.GetInt("upxp", 0);
        }
        PlayerPrefs.SetInt("upxp", 0);
        playermenager.p1save(this,"DELTAFATE/henry/position.un",s);



        tic++;
        if (!platorming)
        {
            if (!Input.GetKey(KeyCode.Mouse1))
            {
                if (t)
                {
                    txt.text = "";
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
        }


    }

    public void Move(Rigidbody2D rigidbody, Vector2 vector2D, bool isMove)
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
                    cam.transform.localPosition = new Vector3(0, 1, -10);
                }
                if (camdown)
                {
                    cam.transform.localPosition = new Vector3(0, -1, -10);
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


