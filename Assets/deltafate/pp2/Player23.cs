using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainname
{
    public static string[] name = new string[3]
    {
        "уровень",
        "level",
        ">>┐"
    }; public static string[] namexp = new string[3]
     {
        "оп",
        "xp",
        "x<"
     }; public static string[] namelive = new string[3]
      {
        "жизни",
        "lives",
        "vvV"
      }; public static string[] namec = new string[3]
      {
        "п",
        "c",
        "><V"
      };
}



public class Player23 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hole")
        {
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "hole")
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
    public GameObject cam;
    [SerializeField] private float speed = 300f;
    [SerializeField] public int lives = 30;
    [SerializeField] private float jumpforse = 1;

    public Text txt;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public Sprite[] sprites;
    public Sprite[] sprite1;
    public Sprite[] sprite2;
    
    private bool isgraund;
    public save s = new save(); 
    public battlesave s4 = new battlesave();
    public int level;
    public string name1;
    public float tic;
    public int time;
    public int time2;
    public int tir;
    public float attacktime;
    public bool s3;
    public string name33 = "siji";
    public items s1 = new items();
    public debug d = new debug();
    GameObject p2;
    public int scenevi;
    public GameObject reynor;
    public GameObject siji;
    public GameObject sarux;
    public GameObject henry;
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "t")
        {
            lives--;
        }
    }
    private void Awake()
    {
        playermenager.inst(this);
        if (PlayerPrefs.GetInt("gender", 0) == 1)
        {
            jumpforse *= 1.1f;
        }
        if (Directory.Exists("debug/arena"))
        {


            namey.uname = "1";
        }
        int h = 0;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        if (namey.uname != "0" && name33 == "henry")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (namey.uname != "0" && name33 == "henry1")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry1")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (namey.uname != "0" && name33 == "henry12")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry12")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (namey.uname != "0" && name33 == "henry1standart")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry1standart")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (namey.uname != "0" && name33 == "siji")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "siji")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (Directory.Exists("debug/arena") && name33 == "henry")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (Directory.Exists("debug/arena") && name33 == "henry1")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry1")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (Directory.Exists("debug/arena") && name33 == "henry12")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry12")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (Directory.Exists("debug/arena") && name33 == "henry1standart")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "henry1standart")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
        if (Directory.Exists("debug/arena") && name33 == "siji")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<Player23>()[i].name33 == "siji")
                {
                    h++;


                }
            }
            if (h < 2)
            {
                Player23 pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<Player23>();
                pa.name33 += "-2";
                p2 = pa.gameObject;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("delete", 0);
        scenevi = SceneManager.GetActiveScene().buildIndex / 150;
        if (File.Exists(@"DELTAFATE/" + "name33" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + name33 + @"/inventory.un"));



        }
        PlayerPrefs.SetString("text", "");
        if (File.Exists(@"DELTAFATE/" + name33 + "/bposition.un"))
        {
            s4 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + name33 + "/bposition.un"));
            s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/"+name33+"/position"+s4.idscene[0]/ 150+".un"));
            name1 = s.name;
            level = s4.level;
            if (s.enter[SceneManager.GetActiveScene().buildIndex - scenevi * 150] == true)
            {


                transform.position = s.v3[SceneManager.GetActiveScene().buildIndex - scenevi * 150];
            }
        }
        if (!File.Exists(@"DELTAFATE/" + name33 + "/bposition.un"))
        {
            name1 = name33;
            level = 0;
            s.name = name1;
            s.level = level;
            s4.level = level;
            Directory.CreateDirectory("DELTAFATE");
            Directory.CreateDirectory(@"DELTAFATE/" + name33 + "");
            File.WriteAllText(@"DELTAFATE/" + name33 + "/position" + s4.idscene[0] / 150 + ".un", JsonUtility.ToJson(s)); 
            File.WriteAllText(@"DELTAFATE/" + name33 + "/bposition.un", JsonUtility.ToJson(s4));
        }
    }

    // Update is called once per frame
    void Update()
    {
        playermenager.setteamplayer23(this);

        if (Directory.Exists("debug") && Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Instantiate(Resources.Load<GameObject>("your au/sans_ee"), transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameObject.FindObjectsOfType<Player23>()[0].gameObject == gameObject)
            {

                PlayerPrefs.SetInt("idcharactaer", PlayerPrefs.GetInt("idcharactaer", 0) + 1);

            }
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (GameObject.FindObjectsOfType<Player23>()[0].gameObject == gameObject)
            {
                if (PlayerPrefs.GetInt("gender", 0) == 0)
                    PlayerPrefs.SetInt("gender", 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            if (GameObject.FindObjectsOfType<Player23>()[0].gameObject == gameObject)
            {

                if (PlayerPrefs.GetInt("gender", 0) == 1)
                    PlayerPrefs.SetInt("gender", 0);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (PlayerPrefs.GetInt("idcharactaer", 0) >= GameObject.FindObjectsOfType<Player23>().Length)
        {
            PlayerPrefs.SetInt("idcharactaer", 0);
        }
        Player.updata(transform.position, d);
        if (cam.GetComponent<Camera>().fieldOfView <= 111f)
        {


            if (Input.GetKeyDown(KeyCode.F1))
            {
                cam.GetComponent<Camera>().fieldOfView *= 1.1f;
            }
        }
        if (cam.GetComponent<Camera>().fieldOfView >= 61.6869f)
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                cam.GetComponent<Camera>().fieldOfView /= 1.1f;
            }

        }
        int lvl;
        lvl = level;
        lvl /= 2000 + s.level / 60;
        lvl += 11;
        
            txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] +" : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + level.ToString() + mainname.namelive[PlayerPrefs.GetInt("ling", 0)] + " : " + lives.ToString();
        
        
        death();
        attacktime += 1 * 60 * Time.fixedDeltaTime;
        PlayerPrefs.SetFloat("attack", attacktime);
        if (deltacontrols.getcontrols.s12[0] == "Escape")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (Input.GetKey(deltacontrols.getcontrols.s12[0]))
            {
                SceneManager.LoadScene(0);
            }
        }
        scenevi = Mathf.FloorToInt(SceneManager.GetActiveScene().buildIndex / 150);
        s.level = level;
        s4.level = level;
        s.v3[SceneManager.GetActiveScene().buildIndex - scenevi * 150] = transform.position;
        s.enter[SceneManager.GetActiveScene().buildIndex - scenevi * 150] = true;
        s.idscene = SceneManager.GetActiveScene().buildIndex;
        s4.idscene[0] = SceneManager.GetActiveScene().buildIndex;
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/" + name33 + "");

        if (PlayerPrefs.GetInt("delete", 0) != 1)
        {
            File.WriteAllText(@"DELTAFATE/" + name33 + "/position" + s4.idscene[0] / 150 + ".un", JsonUtility.ToJson(s));
            File.WriteAllText(@"DELTAFATE/" + name33 + "/bposition.un", JsonUtility.ToJson(s4));
        }
        else
        {
            
                
            
        }
            AnimationMove(sprite, sprites, sprite1, sprite2, 0, false, time, time2);
        checkground();
        if (GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject)
        {
            if (Input.GetButton("Horizontal1"))
            {


                run();
            }
        }
        if (GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != gameObject)
        {
            if (Input.GetButton("Horizontal"))
            {


                run1();
            }
        }
        if (isgraund == true)
        {
            s3 = true;
        }
        if (GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (isgraund == true)
                {


                    jump();
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (s3)
                {
                    if (sprite.flipX == true)
                    {
                        s3 = false;

                        jimp1();
                    }
                    if (sprite.flipX == false)
                    {
                        s3 = false;

                        jimp2();
                    }
                }
            }

        }
        if (GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != gameObject)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (isgraund == true)
                {


                    jump3();
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (s3)
                {
                    if (sprite.flipX == true)
                    {
                        s3 = false;

                        jimp31();
                    }
                    if (sprite.flipX == false)
                    {
                        s3 = false;

                        jimp32();
                    }
                }
            }

        }
        if (GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != gameObject)
        {
            txt.text = "";
            cam.GetComponent<Camera>().enabled = false;
            
        }
        GameObject.FindObjectsOfType<Player23>()[PlayerPrefs.GetInt("idcharactaer", 0)].cam.GetComponent<Camera>().enabled = true;
        
        
        attacktime += 1 * 60 * Time.fixedDeltaTime;
        PlayerPrefs.SetFloat("attack", attacktime);
        GameObject.FindObjectsOfType<Player23>()[Random.Range(0, GameObject.FindObjectsOfType<Player23>().Length)].level += PlayerPrefs.GetInt("upxp", 0);
        
        
    }
    private void run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal1");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir * Time.deltaTime * 60, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0;
        AnimationMove(sprite, sprites, sprite1, sprite2, 0, true, time, time2);
    }
    private void run1()
    {
        Vector3 dir = -transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir * Time.deltaTime * 60, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0;
        AnimationMove(sprite, sprites, sprite1, sprite2, 0, true, time, time2);
    }
    private void jump()
    {
        rb.AddForce(Vector2.up * jumpforse, ForceMode2D.Impulse);
    }
    private void jimp1()
    {
        rb.AddForce(-Vector2.right * jumpforse, ForceMode2D.Impulse);
    }
    private void jimp2()
    {
        rb.AddForce(Vector2.right * jumpforse, ForceMode2D.Impulse);
    }
    private void jump3()
    {
        rb.AddForce(Vector2.up * jumpforse, ForceMode2D.Impulse);
    }
    private void jimp31()
    {
        rb.AddForce(-Vector2.right * jumpforse, ForceMode2D.Impulse);
    }
    private void jimp32()
    {
        rb.AddForce(Vector2.right * jumpforse, ForceMode2D.Impulse);
    }
    private void checkground()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position,20f);
        isgraund = collider.Length > 1;
    }
    public void AnimationMove(SpriteRenderer spriteRenderer, Sprite[] sprite, Sprite[] sprite1, Sprite[] sprite2, int rotation, bool isMove, int time, int time2)
    {
        tic+=1 *60* Time.deltaTime;
        if (spriteRenderer != null)
        {

            if (isMove != true)
            {


                spriteRenderer.sprite = sprite[0];



            }
            if (isMove != false)
            {


                

                if (tic > time)
                {
                    if (tir >= sprite1.Length)
                    {
                        tir = 0;
                    }
                    spriteRenderer.sprite = sprite1[tir];
                    tir++;
                    tic = 0;


                }
                if (tir < sprite1.Length)
                {
                    spriteRenderer.sprite = sprite1[tir];
                }
            }
        }
    }

    private void death()
    {
        s4 = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + name33 + "/bposition.un"));
        s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + name33 + "/position" + s4.idscene[0] / 150 + ".un"));
        if (lives <= 0)
        {
            int u = s4.idscene[0] / 150;
            s.enter[SceneManager.GetActiveScene().buildIndex - u * 150] = false;
            File.WriteAllText(@"DELTAFATE/" + name33 + "/position" + u + ".un", JsonUtility.ToJson(s));
            File.WriteAllText(@"DELTAFATE/" + name33 + "/bposition.un", JsonUtility.ToJson(s4));

            SceneManager.LoadSceneAsync(s4.idscene[0]);

            PlayerPrefs.SetInt("delete", 1);

        }
    }
    


}
