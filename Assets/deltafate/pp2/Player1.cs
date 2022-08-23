using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
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
    public save2 s = new save2();
    public int level;
    public string name1;
    public bool camdown;
    public float attacktime;
    public bool t = true;
    public bool t4;
    public RawImage t5;
    public AudioListener t2;
    public items s1 = new items();
    public bool platorming;

    public SpriteRenderer spriteRenderer;
    private void Start()
    {
        if(File.Exists("res/speed"))
        {


            i = int.Parse(File.ReadAllText("res/speed"));
        }
        PlayerPrefs.SetString("text", "");
        if (File.Exists(@"DELTAFATE/" + "reynor" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "reynor" + @"/inventory.un"));



        }
        if (PlayerPrefs.GetInt("21", 0) == 1)
        {

            t4 = true;
        }
        if (PlayerPrefs.GetInt("21", 0) == 0)
        {
            t4 = false;
        }
        if (t4)
        {

            PlayerPrefs.SetInt("2f", 1);
        }
        if (!t4)
        {
            PlayerPrefs.SetInt("2f", 0);
        }
        if (PlayerPrefs.GetInt("r", 0) == 1)
        {

            transform.position = GameObject.FindObjectOfType<Player>().gameObject.transform.position;
        }

        t5 = GameObject.FindWithTag("image3").GetComponent<RawImage>();
        attacktime = PlayerPrefs.GetFloat("attack", 0);
        t2 = GameObject.FindObjectsOfType<Player1>()[0].cam.GetComponent<AudioListener>();
        if (File.Exists(@"DELTAFATE/reynor/position.un"))
        {
            s = JsonUtility.FromJson<save2>(File.ReadAllText(@"DELTAFATE/reynor/position.un"));
            name1 = s.name;
            level = s.level;
            if (s.enter[SceneManager.GetActiveScene().buildIndex] == true)
            {


                transform.position = s.v3[SceneManager.GetActiveScene().buildIndex];
            }
        }
        if (!File.Exists(@"DELTAFATE/reynor/position.un"))
        {
            name1 = "reynor";
            level = 0;
        }
        int lvl;
        lvl = level;
        lvl /= 110 + (level / 20);
        lvl += 11;
        txt.text = "Уровень : " + lvl.ToString() + "оп :" + level.ToString();
        if (PlayerPrefs.GetInt("r", 0) == 0)
        {
            txt.text = "";
            t5.gameObject.SetActive(false);
            t4 = false;
        }
    }
    private void Update()
    {
        guns.update();
        if (PlayerPrefs.GetInt("1", 0) == 1)
        {

            t = true;
        }
        if (PlayerPrefs.GetInt("1", 0) == 0)
        {

            t = false;
        }
        velosity = Vector3.zero;
        Move(rigidbody2, velosity, isMove);
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
        if (PlayerPrefs.GetInt("21", 0) == 0)
        {
            t4 = false;
        }
        if (PlayerPrefs.GetInt("21", 0) == 1)
        {
            t4 = true;
        }
        if (t4)
        {

            PlayerPrefs.SetInt("2f", 1);
        }
        if (!t4)
        {
            PlayerPrefs.SetInt("2f", 0);
        }
        if (PlayerPrefs.GetInt("r", 0) != 0)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 2)
            {

                t5.gameObject.SetActive(t4);
            }

        }
        if (t)
        {
            txt.text = "";
        }


        if (PlayerPrefs.GetInt("r", 0) == 1)
        {

            if (t)
            {
                if (platorming)
                {
                    if (PlayerPrefs.GetInt("r", 0) == 1)
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
                        if (Input.GetKey(KeyCode.RightArrow))
                        {

                            tic++;
                            velosity += new Vector2(i, 0);
                            isMove = true;
                            rotation = 1;
                            Move(rigidbody2, velosity, isMove);
                            AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);

                        }
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            tic++;
                            velosity += new Vector2(-i, 0);
                            isMove = true;
                            rotation = 3;
                            Move(rigidbody2, velosity, isMove);
                            AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);





                        }
                        txt.text = "";
                    }

                }
            }
            if (!t)
            {
                if (platorming)
                {

                    if (Input.GetKey(KeyCode.D))
                    {

                        tic++;
                        velosity += new Vector2(i, 0);
                        isMove = true;
                        rotation = 1;
                        Move(rigidbody2, velosity, isMove);
                        AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);

                    }
                    if (Input.GetKey(KeyCode.A))
                    {
                        tic++;
                        velosity += new Vector2(-i, 0);
                        isMove = true;
                        rotation = 3;
                        Move(rigidbody2, velosity, isMove);
                        AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);


                    }
                    int lvl;
                    lvl = level;
                    lvl /= 110 + (level / 20);
                    lvl += 11;
                    txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();
                }

            }


            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.Mouse1))
            {
                isMove = false;
            }


            int f = -1;
            for (int i = 0; i < s1.itemid.Count; i++)
            {
                if (s1.itemid[i] > f)
                {
                    f = s1.itemid[i];

                }

            }
            playermenager.p1shot(s1, gameObject, 2);


            AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
            Move(rigidbody2, velosity, isMove);

            if (PlayerPrefs.GetInt("r", 0) == 1)
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    if (t)
                    {
                        if (!platorming)
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

                            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y - 40 >= transform.position.y)
                            {
                                velosity += new Vector2(0, i);
                                isMove = true;
                                rotation = 0;
                                Move(rigidbody2, velosity, isMove);
                                AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                            }

                            if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y + 40 <= transform.position.y)
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

            }
            if (PlayerPrefs.GetInt("r", 0) == 1)
            {
                if (Input.GetKey(KeyCode.Mouse1))
                {
                    if (!platorming)
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

                        if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y - 40 >= transform.position.y)
                        {
                            velosity += new Vector2(0, i);
                            isMove = true;
                            rotation = 0;
                            Move(rigidbody2, velosity, isMove);
                            AnimationMove(spriteRenderer, sprite, sprite1, sprite2, rotation, isMove, time, time2);
                        }

                        if (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y + 40 <= transform.position.y)
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



            if (PlayerPrefs.GetInt("r", 0) == 1)
            {
                if (PlayerPrefs.GetInt("1", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("2f", 0) == 1)
                    {

                        t4 = false;
                    }
                    if (PlayerPrefs.GetInt("2f", 0) == 0)
                    {
                        t4 = false;
                    }

                }
                else if (PlayerPrefs.GetInt("1", 0) == 0)
                {
                    if (PlayerPrefs.GetInt("2f", 0) == 0)
                    {
                        t4 = false;
                    }
                    if (PlayerPrefs.GetInt("2f", 0) == 1)
                    {
                        t4 = true;
                    }
                }

            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                t4 = !t4;
                if (t4)
                {

                    PlayerPrefs.SetInt("2f", 1);
                }
                if (!t4)
                {
                    PlayerPrefs.SetInt("2f", 0);
                }
            }
            t2.enabled = !t;




            t5.gameObject.SetActive(t4);
            attacktime += 1 * 60 * Time.fixedDeltaTime;
            playermenager.p2save(this, "DELTAFATE/reynor/position.un", s);

            if (PlayerPrefs.GetInt("r", 0) == 1)
            {


            }
            tic++;
            if (!platorming)
            {


                if (!t)
                {
                    int lvl;
                    lvl = level;
                    lvl /= 110 + (level / 20);
                    lvl += 11;
                    txt.text = "Уровень : " + lvl.ToString() + " оп :" + level.ToString();
                    // w
                    if (GameObject.FindObjectsOfType<playerjump>().Length != 1)
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


                    }
                }
            }



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

        }

    }

        
    
        
    
    
    
    
    public void Move(Rigidbody2D rigidbody, Vector2 vector2D, bool isMove)
    {
        if (rigidbody != null)
        {
            if (isMove == true)
            {
                rigidbody.velocity = new Vector2(vector2D.x, vector2D.y);
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
[SerializeField]
public class save2
{
    public Vector3[] v3 = new Vector3[150];
    public bool[] enter = new bool[150];
    public int level;
    public int idscene;
    public string name = "reynor"; 
}
