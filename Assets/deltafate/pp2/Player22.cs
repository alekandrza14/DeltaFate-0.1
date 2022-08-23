using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player22 : MonoBehaviour
{
   
    public Sprite[] sprite;

    public save s = new save();

    public Vector2 velocity;
    public int level;
    public string name1;
    public float dist; 
    public float i;
    public int isactive;
    public int si;
    public debug d = new debug();
    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    void Start()
    {
        PlayerPrefs.SetString("text", "");
        si = 1;
    }
    void Update()
    {
        if (Directory.Exists("debug") && Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Instantiate(Resources.Load<GameObject>("your au/sans_ee"), transform.position, Quaternion.identity);
        }
        Player.updata(transform.position, d);
        if (si >= 1)
        {
            for (int i = 0; i < GameObject.FindObjectsOfType<Player22>().Length; i++)
            {

                if (GameObject.FindObjectsOfType<Player22>()[i].gameObject == gameObject)
                {


                    if (!File.Exists(@"DELTAFATE/sarux" + i.ToString() +"/position.un"))
                    {

                        name1 = "sarux";
                        level = 0;
                        s.name = name1;
                        s.level = level;
                        if (s.level >= 0)
                        {


                            isactive = 1;
                        }
                    }
                    

                    if (File.Exists(@"DELTAFATE/sarux" + i.ToString() + "/position.un"))
                    {
                        Debug.Log(11);
                        s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/sarux" + i.ToString() + "/position.un"));
                        name1 = s.name;
                        level = s.level;
                        if (s.enter[SceneManager.GetActiveScene().buildIndex] == true)
                        {


                            gameObject.transform.position = s.v3[SceneManager.GetActiveScene().buildIndex];
                            si = 2;
                        }
                        if (s.level >= 0)
                        {


                            isactive = 1;
                        }
                    }


                }
            }
            

        }

        for (int i = 0; i < GameObject.FindObjectsOfType<Player22>().Length; i++)
        {

            if (GameObject.FindObjectsOfType<Player22>()[i].gameObject == gameObject)
            {


                if (!File.Exists(@"DELTAFATE/sarux" + i.ToString() + "/position.un"))
                {
                    
                    if (level >= 0)
                    {


                        isactive = 1;
                    }
                }
            }
        }
        if (si == 2)
        {
            si = 0;
        }

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
        s.level = level;
        s.v3[SceneManager.GetActiveScene().buildIndex] = transform.position;
        s.enter[SceneManager.GetActiveScene().buildIndex] = true;
        s.idscene = SceneManager.GetActiveScene().buildIndex;
        for (int i = 0; i < GameObject.FindObjectsOfType<Player22>().Length; i++)
        {

            if (GameObject.FindObjectsOfType<Player22>()[i].gameObject == gameObject)
            {


                Directory.CreateDirectory("DELTAFATE");
                Directory.CreateDirectory(@"DELTAFATE/sarux" + i);
                File.WriteAllText(@"DELTAFATE/sarux" + i.ToString() + "/position.un", JsonUtility.ToJson(s));


            }
        }

        if (isactive == 0)
        {
            spriteRenderer.color = new Color(0,0,0,0);
        }
        if (isactive == 1)
        {



            velocity = new Vector2(0, 0);


            if (!Input.GetKey(KeyCode.Space))
            {
                spriteRenderer.sprite = sprite[0];
            }
            if (Input.GetKey(KeyCode.Space))
            {

                spriteRenderer.sprite = sprite[1];

                if (GameObject.FindGameObjectWithTag("s").transform.position.x - dist >= transform.position.x)
                {

                    velocity += new Vector2(i, 0);


                }
                if (GameObject.FindGameObjectWithTag("s").transform.position.x + dist <= transform.position.x)
                {
                    velocity += new Vector2(-i, 0);


                }
                if (GameObject.FindGameObjectWithTag("s").transform.position.y - dist >= transform.position.y)
                {
                    velocity += new Vector2(0, i);


                }
                if (GameObject.FindGameObjectWithTag("s").transform.position.y + dist <= transform.position.y)
                {
                    velocity += new Vector2(0, -i);


                }

            }
            if (GetComponent<Rigidbody2D>())
            {
                GetComponent<Rigidbody2D>().velocity = velocity;
            }

        }

        
    }
}

