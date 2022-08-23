using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soul_move : MonoBehaviour
{
    public GameObject player;

    public Rigidbody2D rigidbody2;

    public float forse;
    public SpriteRenderer renderer1;
    public int renderer2;
    public Sprite sp;
    public float tic;
    public KeyCode s1;
    public KeyCode w1;
    public KeyCode d1;
    public KeyCode a1;
    public bool issoulbrowen;
    void Start()
    {
        //isinstialization
        
        rigidbody2 = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D s)
    {
        if (s.collider.tag == "yt")
        {
            forse = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (player.GetComponent<igrok2>().ss == true && player.GetComponent<igrok2>().isinstialization == true)
        {
            if (renderer2 == 1)
            {

                player.GetComponent<igrok2>().hp = 0;
                Destroy(gameObject);
            }
        }
        if (player.GetComponent<igrok2>().fight == true)
        {
            if (s.gameObject.tag == "t")
            {
                player.GetComponent<igrok2>().hp -= 1;
                if (SceneManager.GetActiveScene().buildIndex == 27)
                {
                    player.GetComponent<igrok2>().hp -= 100;
                }
            }
        }
        if (player.GetComponent<igrok2>().fight == true)
        {
            if (s.gameObject.tag == "tx")
            {
                player.GetComponent<igrok2>().hp -= 2;
            }
            if (s.gameObject.tag == "t2")
            {
                player.GetComponent<igrok2>().hp -= 10;
            }
            if (s.gameObject.tag == "t3")
            {
                player.GetComponent<igrok2>().hp -= 20;
            }
        }


    }

    void FixedUpdate()
    {

        if (player.GetComponent<igrok2>().hp <= 0)
        {

            renderer1.sprite = sp;
            tic += 1 * Time.deltaTime;
            player.GetComponent<igrok2>().hp = 0;
        }

        if (tic >= 0.5f)
        {
            Destroy(gameObject);
        }
        if (player.GetComponent<igrok2>().hp > 0)
        {
            if (player.GetComponent<igrok2>().fight == true)
            {

                rigidbody2.velocity = (new Vector2(0, 0));


            }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (player.GetComponent<igrok2>().fight == true)
                {
                    if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - 1 >= transform.position.x)
                    {
                        rigidbody2.velocity += (new Vector2(100, 0));

                    }
                    if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x + 1 <= transform.position.x)
                    {
                        rigidbody2.velocity += new Vector2(-100, 0);
                    }
                    if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - 1 >= transform.position.y)
                    {
                        rigidbody2.velocity += new Vector2(0, 100);
                    }
                    if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y + 1 <= transform.position.y)
                    {
                        rigidbody2.velocity += new Vector2(0, -100);
                    }


                }

            }
            if (PlayerPrefs.GetInt("t44", 0) == 0 && !issoulbrowen)
            {
                if (Input.GetKey(d1))
                {
                    rigidbody2.velocity += new Vector2(100, 0);
                }
                if (Input.GetKey(a1))
                {
                    rigidbody2.velocity += new Vector2(-100, 0);
                }
                if (Input.GetKey(w1))
                {
                    rigidbody2.velocity += new Vector2(0, 100);
                }
                if (Input.GetKey(s1))
                {
                    rigidbody2.velocity += new Vector2(0, -100);
                }

            }


            if (PlayerPrefs.GetInt("TTN", 0) == 0)
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {





                }
                if (PlayerPrefs.GetInt("t44", 0) == 1)
                {
                    forse += 1 * 20 * Time.fixedDeltaTime;
                }



                if (player.GetComponent<igrok2>().fight == true)
                {
                    if (PlayerPrefs.GetInt("teni", 0) == 1)
                    {

                        rigidbody2.gravityScale = 1;
                    }

                    if (PlayerPrefs.GetInt("teni", 0) != 1)
                    {
                        if (PlayerPrefs.GetInt("t44", 0) == 1)
                        {

                        }
                    }
                    if (player.GetComponent<igrok2>().fight == true &&!issoulbrowen)
                    {
                        if (PlayerPrefs.GetInt("t44", 0) == 1)
                        {
                            if (PlayerPrefs.GetInt("teni", 0) == 1)
                            {

                                rigidbody2.gravityScale = 1;
                            }
                            if (PlayerPrefs.GetInt("teni", 0) != 1)
                            {
                                if (Input.GetKey(d1))
                                {
                                    rigidbody2.velocity += (new Vector2(100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(a1))
                                {
                                    rigidbody2.velocity += (new Vector2(-100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(w1))
                                {
                                    rigidbody2.velocity += (new Vector2(0, 200) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(s1))
                                {
                                    rigidbody2.velocity += new Vector2(0, -20) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse;
                                }
                            }
                        }
                        if (PlayerPrefs.GetInt("teni", 0) == 1)
                        {
                            if (rigidbody2.velocity.x >= 10 || rigidbody2.velocity.x <= -10 || rigidbody2.velocity.y >= 10 || rigidbody2.velocity.y <= 10)
                            {
                                if (Input.GetKey(d1))
                                {
                                    rigidbody2.AddForce(new Vector2(100, 0));
                                }
                                if (Input.GetKey(a1))
                                {
                                    rigidbody2.AddForce(new Vector2(-100, 0));
                                }
                                if (Input.GetKey(w1))
                                {
                                    rigidbody2.AddForce(new Vector2(0, 100));
                                }
                                if (Input.GetKey(s1))
                                {
                                    rigidbody2.AddForce(new Vector2(-100, 0));
                                }
                            }
                            else
                            {
                                rigidbody2.velocity = (new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                            }

                        }
                    }



                }
            }
            if (PlayerPrefs.GetInt("TTN", 0) == 1)
            {
                if (PlayerPrefs.GetInt("t44", 0) == 1)
                {
                    forse += 1 * 60 * Time.fixedDeltaTime;
                }
                if (PlayerPrefs.GetInt("t44", 0) == 0)
                {
                    forse = 0;
                }


                if (player.GetComponent<igrok2>().fight == true)
                {
                    if (PlayerPrefs.GetInt("teni", 0) == 1)
                    {

                        rigidbody2.gravityScale = 1;
                    }
                    if (PlayerPrefs.GetInt("teni", 0) != 1 && !issoulbrowen)
                    {
                        if (Input.GetKey(d1))
                        {
                            rigidbody2.velocity += (new Vector2(20, 0));
                        }
                        if (Input.GetKey(a1))
                        {
                            rigidbody2.velocity += (new Vector2(-20, 0));
                        }
                        if (Input.GetKey(w1))
                        {
                            rigidbody2.velocity += (new Vector2(0, 20));
                        }
                        if (Input.GetKey(s1))
                        {
                            rigidbody2.velocity += (new Vector2(0, -20));
                        }
                    }


                    if (player.GetComponent<igrok2>().fight == true)
                    {
                        if (PlayerPrefs.GetInt("t44", 0) == 1)
                        {
                            if (PlayerPrefs.GetInt("teni", 0) == 1)
                            {

                                rigidbody2.gravityScale = 1;
                            }
                            if (PlayerPrefs.GetInt("teni", 0) != 1&&!issoulbrowen)
                            {
                                if (Input.GetKey(d1))
                                {
                                    rigidbody2.velocity += (new Vector2(20, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(a1))
                                {
                                    rigidbody2.velocity += (new Vector2(-20, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(w1))
                                {
                                    rigidbody2.velocity += (new Vector2(0, 20) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(s1))
                                {
                                    rigidbody2.velocity += (new Vector2(0, -20) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                            }
                        }

                        if (rigidbody2.velocity.x >= 10&&!issoulbrowen || rigidbody2.velocity.x <= -10&&!issoulbrowen || rigidbody2.velocity.y >= 10&&!issoulbrowen || rigidbody2.velocity.y <= 10&&!issoulbrowen)
                        {
                            if (Input.GetKey(d1))
                            {
                                rigidbody2.AddForce(new Vector2(100, 0));
                            }
                            if (Input.GetKey(a1))
                            {
                                rigidbody2.AddForce(new Vector2(-100, 0));
                            }
                            if (Input.GetKey(w1))
                            {
                                rigidbody2.AddForce(new Vector2(0, 100));
                            }
                            if (Input.GetKey(s1))
                            {
                                rigidbody2.AddForce(new Vector2(-100, 0));
                            }
                        }
                        else
                        {
                            rigidbody2.velocity = (new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                        }


                    }



                }

            }
        }
        if (player.GetComponent<igrok2>().fight == false)
        {

            rigidbody2.velocity = (new Vector2(0, 0));


        }

    }
}
