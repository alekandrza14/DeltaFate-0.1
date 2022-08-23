using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class character
{
    public string curent;
}

public class PlayerAnime : MonoBehaviour
{

    public int rotation;

    public int dence;
    public GameObject cam;
    public Sprite[] sprite;
    public Text txt;


    public float tic;
    public float tic2;
    public int time;
    public int time2;

    public bool isMove;
    public Vector2 velosity;
    public Rigidbody2D rigidbody2;
    public Rigidbody rigidbody3;
    public float i;
    public float i2;
    public float i3;
    public float i4;
    public int tir;
    public save s = new save();
    public battlesave s2 = new battlesave();
    public save s6 = new save();
    public saveload s3 = new saveload();
    public int level;
    public int levelget;
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
    public bool issiji;
    public bool issarux;
    public bool isreynor;
    public animx anim;
    public animx anim2;
    public SpriteRenderer spriteRenderer;
    public debug d = new debug();
    public string nameplus = "";
    public string nameminus = "DELTAFATE/henry1";
    public int scenevi;
    public bool isnotattack;
    public bool ch4;
    public float desty = -1000;
    public int hp = 100;
    public GameObject reynor;
    public GameObject siji;
    public GameObject sarux; 
    public GameObject henry;
    public int size = 1;
    public Color tse = Color.cyan;
    GameObject p2;
    float ise1 = 0;
    float ise2 = 0;
    public modefikatoreffects effect = new modefikatoreffects();
    public pathin path = new pathin();
    private void Awake()
    {
        if (gameObject == GameObject.FindObjectsOfType<PlayerAnime>()[0].gameObject)
        {
            gameObject.AddComponent<Modding>();
        }
        if (File.Exists(@"DELTAFATE/mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

        }
        if (File.Exists(@"mods/effect.un"))
        {
            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

        }
        int h = 0;
        if (Directory.Exists("debug/arena"))
        {


            namey.uname = "1";
        }
        if (namey.uname != "0" && ishenry)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry == true)
                {
                    h++;


                }
            }
            if (h < 2)
            {
                PlayerAnime pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<PlayerAnime>();
                pa.nameplus += "-2";
                p2 = pa.gameObject;
                if (p2.gameObject.GetComponent<surv>())
                    p2.gameObject.GetComponent<surv>().enabled = false;
            }
        }
        if (namey.uname != "0" && issiji)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji == true)
                {
                    h++;


                }
            }
            if (h < 2)
            {
                PlayerAnime pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<PlayerAnime>();
                pa.nameplus += "-2";
                p2 = pa.gameObject;
                if (p2.gameObject.GetComponent<surv>())
                    p2.gameObject.GetComponent<surv>().enabled = false;
            }
        }
        
        if (Directory.Exists("debug/arena") && ishenry)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry == true)
                {
                    h++;


                }
            }
            if (h < 2)
            {
                PlayerAnime pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<PlayerAnime>();
                pa.nameplus += "-2";
                p2 = pa.gameObject;
                if (p2.gameObject.GetComponent<surv>())
                    p2.gameObject.GetComponent<surv>().enabled = false;
            }
        }
        if (Directory.Exists("debug/arena") && issiji)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji == true)
                {
                    h++;


                }
            }
            if (h < 2)
            {
                PlayerAnime pa = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<PlayerAnime>();
                pa.nameplus += "-2";
                p2 = pa.gameObject;
                if(p2.gameObject.GetComponent<surv>())
                p2.gameObject.GetComponent<surv>().enabled = false;
            }
        }
        cam.GetComponent<Camera>().backgroundColor = tse;
    }
    public void s33s()
    {
        hp = Random.Range(100,2000);
    }
    private void Update()
    {
        



        
        
        if (PlayerPrefs.GetString("rejim", "") == "hero" && ishenry)
        {
            anim = anim2;
            
        }
        if (PlayerPrefs.GetInt("idcharactaer", 0) >= GameObject.FindObjectsOfType<PlayerAnime>().Length)
        {
            PlayerPrefs.SetInt("idcharactaer", 0);
        }
        tic2 += 1 * 30 * Time.deltaTime;
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject && tic2 >= 1)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.Count < 100)
            {
                if (PlayerPrefs.GetInt("gunr", -1) != -1)
                {
                    if (PlayerPrefs.GetInt("gunr", -1) == 23)
                    {



                        path.v4.Add(new Vector4(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z, rotation));
                        tic2 = 0;
                    }
                }
            }
        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.Count >= 100)
            {
                

                for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
                {
                   
                    

                        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != GameObject.FindObjectsOfType<PlayerAnime>()[i].gameObject)
                        {




                            

                                if (Vector3.Distance(GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject.transform.position, GameObject.FindObjectsOfType<PlayerAnime>()[i].gameObject.transform.position) > 40)
                                {



                                    GameObject.FindObjectsOfType<PlayerAnime>()[i].gameObject.transform.position = new Vector3(GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4[0 + i * 10].x, GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4[0 + i * 10].y, GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4[0 + i * 10].z);
                                    GameObject.FindObjectsOfType<PlayerAnime>()[i].rotation = Mathf.FloorToInt(GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4[0 + i * 10].w);
                                    GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.RemoveAt(0);
                                }
                            

                        }

                    
                    
                }

            }


        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.Count > 100)
        {
            GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.RemoveAt(0);
        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject)
        {
            File.WriteAllText("DELTAFATE/pos1"+SceneManager.GetActiveScene().buildIndex+"ai", JsonUtility.ToJson(path));
        }
            if (Input.GetKeyDown(KeyCode.F3))
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[0].gameObject == gameObject)
            {
                if (PlayerPrefs.GetInt("gender", 0) == 0)
                    PlayerPrefs.SetInt("gender", 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[0].gameObject == gameObject)
            {
                
                if (PlayerPrefs.GetInt("gender", 0) == 1)
                    PlayerPrefs.SetInt("gender", 0);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        i = i2;
        if (issiji || Directory.Exists("debug"))
        {
            if (!Input.GetKey(KeyCode.Space))
            {
                i = i2;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                i = i3;
            }
        }
        if (Directory.Exists("debug") && Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Instantiate(Resources.Load<GameObject>("your au/sans_ee"),transform.position,Quaternion.identity);
        }
        if (ise1 == 0)
        {
            ise1 = i2;
        }
        if (ise1 != 0)
        {
            i2 = ise1;
        }
       
        if (ise2 == 0)
        {
            ise2 = i3;
        }
        if (ise2 != 0)
        {
            i3 = ise2;
        }

             
        int r = 0; int si = 0; int sa = 0;
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i])
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].isreynor == true)
                {
                    r++;


                }
            }
        }
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i])
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issarux == true)
                {
                    sa++;


                }
            }
        }
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i])
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji == true)
                {
                    si++;


                }
            }
        }
        if (Input.GetKey(deltacontrols.getcontrols.s12[2]) && ishenry && r < 1)
        {
            Instantiate(reynor, transform);
        }
        if (Input.GetKey(deltacontrols.getcontrols.s12[2]) && issiji && sa < 1)
        {
            Instantiate(reynor, transform);
        }
        if (!File.Exists(@"DELTAFATE/unauticna/seed.un"))
        {
            Directory.CreateDirectory(@"DELTAFATE/unauticna");
            File.WriteAllText(@"DELTAFATE/unauticna/seed.un", Random.Range(-1000, 500).ToString());
            level += int.Parse(File.ReadAllText(@"DELTAFATE/unauticna/seed.un"));
        }
        if (Directory.Exists("DELTAFATE/var"))
        {
            if (cam.GetComponent<Camera>().orthographic == false)
            {


                File.WriteAllText("DELTAFATE/var/curs2.folat", cam.GetComponent<Camera>().fieldOfView.ToString());
                File.WriteAllText("DELTAFATE/var/curs3.folat", cam.GetComponent<Camera>().transform.rotation.y.ToString());







            }
            else
            {



                File.WriteAllText("DELTAFATE/var/curs.folat", cam.GetComponent<Camera>().orthographicSize.ToString());

            }
        }

        if (si >= 1)
        {
            PlayerPrefs.SetString("ch1", "0");
            if (si >= 1 && r >= 1)
            {
                PlayerPrefs.SetString("ch1", "1");

            }
        }
        if (r >= 1)
        {
            PlayerPrefs.SetString("ch1", "reynor");
            if (si >= 1 && r >= 1)
            {
                PlayerPrefs.SetString("ch1", "1");

            }
        }
        
            if (si < 1 && r < 1)
            {
                PlayerPrefs.SetString("ch1", "");

            }




        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == gameObject)
        {
            if (Input.GetKey(KeyCode.F11))
            {
                battlesave bs = new battlesave();
                s3.level = s2.level; s3.enter = s6.enter; s3.idscene = s2.idscene[0]; s3.v3 = s6.v3; s3.name = s6.name;
                bs.idscene[0] = s2.idscene[0]; bs.pos = s6.v3[SceneManager.GetActiveScene().buildIndex - scenevi * 150];
                Directory.CreateDirectory(@"DELTAFATE/unauticna");
                File.WriteAllText(@"DELTAFATE/unauticna/position" + scenevi + ".un", JsonUtility.ToJson(s3)); 
                File.WriteAllText(@"DELTAFATE/unauticna/bposition.un", JsonUtility.ToJson(bs));

            }
        }
        if (Input.GetKey(KeyCode.F12) && !Input.GetKey(KeyCode.R))
        {
            

            if (File.Exists(@"DELTAFATE/unauticna/position.un"))
            {
                s3 = JsonUtility.FromJson<saveload>(File.ReadAllText(@"DELTAFATE/unauticna/position" + scenevi + ".un"));
                battlesave bs = new battlesave();
                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/unauticna/bposition.un"));
                level = bs.level;

                if (s3.enter[SceneManager.GetActiveScene().buildIndex] == true)
                {


                    transform.position = s3.v3[SceneManager.GetActiveScene().buildIndex];
                }
            }

        }
        if (Input.GetKey(KeyCode.F12) && Input.GetKey(KeyCode.R))
        {
            battlesave bs = new battlesave();
            bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/unauticna/bposition.un"));
            PlayerPrefs.SetInt("loadstart", 1);
            SceneManager.LoadScene(bs.idscene[0]);

        }
       

        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un") && ishenry)
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



        }
        if (File.Exists(@"DELTAFATE/" + "reynor" + @"/inventory.un") && isreynor)
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "reynor" + @"/inventory.un"));



        }
        Player.updata(transform.position, d);
        velosity = Vector2.zero;
        Move(rigidbody2, velosity, isMove);
        
        if (cam.GetComponent<Camera>().orthographic == false)
        {
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
            if (cam.GetComponent<Camera>().transform.rotation.y < 0.5f)
            {


                if (Input.GetKeyDown(KeyCode.N))
                {
                    cam.GetComponent<Camera>().transform.Rotate(0, 6, 0);
                }
            }
            if (cam.GetComponent<Camera>().transform.rotation.y > -0.5f)
            {


                if (Input.GetKeyDown(KeyCode.B))
                {
                    cam.GetComponent<Camera>().transform.Rotate(0, -6, 0);
                }
            }
        }
        else
        {


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
        }
        guns.update();
        
            if (ishenry)
            {
                if (File.Exists(nameminus + nameplus + "/bposition.un"))
                {


                    s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(nameminus + nameplus + "/bposition.un"));
                    



                    levelget = s2.level;

                    int lvl;
                    lvl = levelget;
                    lvl /= 110 + levelget / 20;
                    lvl += 11;
                    if (PlayerPrefs.GetInt("gunr", -1) != -1)
                    {
                        txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + levelget.ToString() + mainname.namec[PlayerPrefs.GetInt("ling", 0)] + " : " + s1.patrons[PlayerPrefs.GetInt("gunr", 0)];
                    }
                    else
                    {
                        txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + levelget.ToString();
                    }

                }
            }
            if (isreynor)
            {
                if (File.Exists(nameminus + nameplus + "/bposition.un"))
                {


                    s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(nameminus + nameplus + "/bposition.un"));
                    



                    levelget = s2.level;

                    int lvl;
                    lvl = levelget;
                    lvl /= 110 + levelget / 20;
                    lvl += 11;
                    if (PlayerPrefs.GetInt("gunr3", -1) != -1)
                    {
                        txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + levelget.ToString() + mainname.namec[PlayerPrefs.GetInt("ling", 0)]+" : " + s1.patrons[PlayerPrefs.GetInt("gunr3", 0)];
                    }
                    else
                    {
                        txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + levelget.ToString();
                    }

                }
            }
        if (issiji)
        {
            if (File.Exists(nameminus + nameplus + "/bposition.un"))
            {


                s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(nameminus + nameplus + "/bposition.un"));





                levelget = s2.level;
                int lvl2;
                lvl2 = levelget;
                lvl2 /= 2000 + s.level / 20;
                lvl2 += 11;
                txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl2.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + levelget.ToString();

            }
        }
        if (issarux)
        {
            if (File.Exists(nameminus + nameplus + "/bposition.un"))
            {


                s2 = JsonUtility.FromJson<battlesave>(File.ReadAllText(nameminus + nameplus + "/bposition.un"));





                levelget = s2.level;
                int lvl2;
                lvl2 = levelget;
                lvl2 /= 2000 + s.level / 20;
                lvl2 += 11;
                txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + "∞";

            }
        }
        //∞

        if (ishenry)
        {
            playermenager.p1shot(s1, gameObject, 0);
            
        }
        if (isreynor)
        {
            playermenager.p1shot(s1, gameObject, 2);

        }
        if (issiji)
        {
            playermenager.p1shot(s1,gameObject,1);
        }
    


        
       
        
        velosity = Vector2.zero;

        
        

        i4 = PlayerPrefs.GetInt("idcharactaer", 0);
        if (PlayerPrefs.GetInt("idcharactaer", 0) >= GameObject.FindObjectsOfType<PlayerAnime>().Length)
        {
            PlayerPrefs.SetInt("idcharactaer", 0);
        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != gameObject && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Destroy(gameObject);
        }

        for (int it = 0; it < effect.ideffect.Count; it++)
        {
            if (effect.ideffect[it] == "speed")
            {
                
                i2 += effect.power[it] * 120;

                i3 += effect.power[it] * 80;
            }
        }

        playermenager.pAmove(this);
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != gameObject)
        {
            txt.text = "";
            cam.GetComponent<Camera>().enabled = false;
            t2.enabled = false; t6.enabled = false;
        }
        GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].cam.GetComponent<Camera>().enabled = true;
        GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].t2.enabled = true;
        GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].t6.enabled = true;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[0].gameObject == gameObject)
            {

                PlayerPrefs.SetInt("idcharactaer", PlayerPrefs.GetInt("idcharactaer", 0) + 1);
            }
        }
        attacktime += 1 * 60 * Time.fixedDeltaTime;
        
        PlayerPrefs.SetFloat("attack", attacktime);
        GameObject.FindObjectsOfType<PlayerAnime>()[Random.Range(0, GameObject.FindObjectsOfType<PlayerAnime>().Length)].level += PlayerPrefs.GetInt("upxp", 0);
        PlayerPrefs.SetInt("upxp", 0);
        playermenager.pAsave(this, nameminus, nameplus, s6);

        

    }

    private void Start()
    {
        if (PlayerPrefs.GetString("rejim","")== "hero" && ishenry)
        {
            anim = anim2;
            spriteRenderer.sprite = anim.sprite[0];
        }
        deltacontrols.getcontrols.Getkeycode();
        if (File.Exists("DELTAFATE/pos1" + SceneManager.GetActiveScene().buildIndex + ".ai"))
        {
            path = JsonUtility.FromJson<pathin>(File.ReadAllText("DELTAFATE/pos1" + SceneManager.GetActiveScene().buildIndex + ".ai"));
        }
        if (cam.GetComponent<Camera>().orthographic == false)
        {
            if (File.Exists("DELTAFATE/var/curs3.folat"))
            {


                cam.GetComponent<Camera>().transform.rotation = new Quaternion(cam.GetComponent<Camera>().transform.rotation.x, float.Parse(File.ReadAllText("DELTAFATE/var/curs3.folat")), cam.GetComponent<Camera>().transform.rotation.z, cam.GetComponent<Camera>().transform.rotation.w);

            }
            if (File.Exists("DELTAFATE/var/curs2.folat"))
            {


                cam.GetComponent<Camera>().fieldOfView = float.Parse(File.ReadAllText("DELTAFATE/var/curs2.folat"));

            }
        }
        else
        {


            if (File.Exists("DELTAFATE/var/curs.folat"))
            {


                cam.GetComponent<Camera>().orthographicSize = float.Parse(File.ReadAllText("DELTAFATE/var/curs.folat"));

            }
        }
        if (File.Exists("res/speed"))
        {


            i = int.Parse(File.ReadAllText("res/speed"));
            i2 = int.Parse(File.ReadAllText("res/speed"));
        }
        if (GameObject.FindWithTag("ss"))
        {
            isnotattack = true;
        }
        PlayerPrefs.SetString("text", "");

        if (ishenry)
        {
            if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
            {
                s5 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



            }

        }
        if (issiji)
        {
            if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
            {
                s5 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));



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

        playermenager.pAload(this, nameminus, nameplus);
       


        

        if (!isnotattack)
        {


            attacktime = PlayerPrefs.GetFloat("attack", 0);
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
        if (rigidbody3 != null)
        {
            if (Input.GetKey(KeyCode.I))
            {
                if (isMove == true)
                {
                    rigidbody3.velocity = new Vector3(0, 0,-i);
                    rigidbody3.velocity += new Vector3(vector2D.x, vector2D.y);
                }
            }
            if (Input.GetKey(KeyCode.J))
            {
                if (isMove == true)
                {
                    rigidbody3.velocity = new Vector3(0, 0,i);
                    rigidbody3.velocity += new Vector3(vector2D.x, vector2D.y);
                }
            }
            if (isMove == true && !Input.GetKey(KeyCode.J) && !Input.GetKey(KeyCode.I))
            {
                rigidbody3.velocity = new Vector3(0, 0);
                rigidbody3.velocity += new Vector3(vector2D.x, vector2D.y);
            }
            if (isMove == true && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.I))
            {
                rigidbody3.velocity = new Vector3(0, 0);
                rigidbody3.velocity += new Vector3(vector2D.x, vector2D.y);
            }
            if (isMove == false)
            {
                rigidbody3.velocity = new Vector2(0, 0);
            }
        }
    }
    public void AnimationMove(SpriteRenderer spriteRenderer, int rotation, bool isMove, int time, int time2)
    {
        tic += 1 * 60 * Time.deltaTime;
        if (spriteRenderer != null)
        {

            if (isMove != true)
            {

                if (rotation == 0)
                {
                    spriteRenderer.sprite = anim.sprite[0];
                }
                if (rotation == 1)
                {
                    spriteRenderer.sprite = anim.sprite[1];
                }
                if (rotation == 2)
                {
                    spriteRenderer.sprite = anim.sprite[2];
                }
                if (rotation == 3)
                {
                    spriteRenderer.sprite = anim.sprite[3];
                }
                if (rotation == 4)
                {
                    spriteRenderer.sprite = anim.sprite[4];
                }
                if (rotation == 5)
                {
                    spriteRenderer.sprite = anim.sprite[5];
                }
                if (rotation == 6)
                {
                    spriteRenderer.sprite = anim.sprite[0];
                }
                if (rotation == 7)
                {
                    spriteRenderer.sprite = anim.sprite[0];
                }
            }
            if (isMove != false)
            {

                if (tic > time)
                {
                    camdown = !camdown;
                    tir++;
                }
                if (PlayerPrefs.GetInt("dif", 0) != 4)
                {
                    if (!camdown)
                    {
                        cam.transform.localPosition = new Vector3(0, 1, desty);
                    }
                    if (camdown)
                    {
                        cam.transform.localPosition = new Vector3(0, -1, desty);
                    }
                }
                if (PlayerPrefs.GetInt("dif", 0) == 4)
                {
                    if (!camdown)
                    {
                        cam.transform.localPosition = new Vector3(0, 10, desty);
                    }
                    if (camdown)
                    {
                        cam.transform.localPosition = new Vector3(0, -10, desty);
                    }
                }
                if (rotation == 0)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite1.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite1[tir];

                        tic = 0;


                    }
                }
                if (rotation == 1)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite2.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite2[tir];

                        tic = 0;
                    }
                }
                if (rotation == 2)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite3.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite3[tir];

                        tic = 0;
                    }
                }
                if (rotation == 3)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite4.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite4[tir];

                        tic = 0;
                    }
                }
                if (rotation == 4)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite5.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite5[tir];

                        tic = 0;
                    }
                }
                if (rotation == 5)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite6.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite6[tir];

                        tic = 0;
                    }
                }
                if (rotation == 6)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite7.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite7[tir];

                        tic = 0;
                    }
                }
                if (rotation == 7)
                {

                    if (tic > time)
                    {
                        if (tir >= anim.sprite8.Length)
                        {
                            tir = 0;
                        }
                        spriteRenderer.sprite = anim.sprite8[tir];

                        tic = 0;
                    }
                }
            }
        }
    }
}
public class save
{
    public Vector3[] v3 = new Vector3[150];
    public bool[] enter = new bool[150];
    public int level;
    public int idscene;
    public string name = "henry";
    public int hp = 100;
    public string v5;
}
public class saveload
{
    public Vector3[] v3 = new Vector3[150];
    public bool[] enter = new bool[150];
    public int level;
    public int idscene;
    public string name = "";
    public int hp = 100;
}
