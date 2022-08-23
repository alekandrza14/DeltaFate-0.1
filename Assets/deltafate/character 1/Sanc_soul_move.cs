using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sanc_soul_move : MonoBehaviour
{
    public GameObject player;
    public GameObject st;
    public GameObject spplayer;
    public GameObject soul2;
    public Rigidbody2D rigidbody2;
    public int type = 0;
    public float forse;
    public SpriteRenderer renderer1;
    public Sprite sp;
    public float tic;
    void Start()
    {
        PlayerPrefs.SetInt("f", 0);
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

        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "t")
            {
                player.GetComponent<igrok>().hp -= 1;
                if (SceneManager.GetActiveScene().buildIndex == 27)
                {
                    player.GetComponent<igrok>().hp -= 100;
                }
            }
        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "tx")
            {
                player.GetComponent<igrok>().hp -= 2;
            }
        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "t2")
            {
                player.GetComponent<igrok>().hp -= 5;
            }
        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "t3")
            {
                player.GetComponent<igrok>().hp -= 20;
            }
        }


    }

    void FixedUpdate()
    {
        if (spplayer != null)
        {
            if (!GameObject.FindWithTag("Player"))
            {


                if (PlayerPrefs.GetInt("s1", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("r1", 0) == 1)
                    {
                        if (PlayerPrefs.GetInt("ts", 0) == 0)
                        {
                            Instantiate(spplayer.gameObject, spplayer.transform);
                            Instantiate(soul2.gameObject, gameObject.transform.position, Quaternion.identity);
                        }
                    }

                }
            }


        }

        if (player.GetComponent<igrok>().hp <= 0)
        {

            renderer1.sprite = sp;
            tic += 1 * Time.deltaTime;
            player.GetComponent<igrok>().hp = 0;
        }

        if (tic >= 0.5f)
        {
            Destroy(gameObject);
        }
        if (player.GetComponent<igrok>().hp > 0)
        {
            if (player.GetComponent<igrok>().fight == true)
            {
                if (!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.A)|| !Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.Mouse1))
                {
                    if (PlayerPrefs.GetInt("t44", 0) == 0)
                    {
                        rigidbody2.velocity = (new Vector2(0, 0));
                    }
                    if (PlayerPrefs.GetInt("t44", 0) == 1)
                    {
                        rigidbody2.velocity = new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse;
                    }
                }

                if (rigidbody2.velocity.x >= 10 || rigidbody2.velocity.x <= -10 || rigidbody2.velocity.y >= 10 || rigidbody2.velocity.y <= 10)
                {
                    if (PlayerPrefs.GetInt("t44", 0) == 0)
                    {
                        rigidbody2.velocity = (new Vector2(0, 0));
                    }
                    if (PlayerPrefs.GetInt("t44", 0) == 1)
                    {
                        rigidbody2.velocity = new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse;
                    }
                }

            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                if (player.GetComponent<igrok>().fight == true)
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
            

            if (PlayerPrefs.GetInt("TTN", 0) == 0)
            {
                if (Input.GetKey(KeyCode.Mouse1))
                {





                }
                if (PlayerPrefs.GetInt("t44", 0) == 1)
                {
                    forse += 1 * 20 * Time.fixedDeltaTime;
                }
                
                if (PlayerPrefs.GetInt("f", 0) == 1)
                {
                    type = 1;

                }
                if (PlayerPrefs.GetInt("f", 0) == 0)
                {
                    type = 0;

                }

                if (player.GetComponent<igrok>().fight == true)
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
                    if (player.GetComponent<igrok>().fight == true)
                    {
                        if (PlayerPrefs.GetInt("t44", 0) == 1)
                        {
                            if (PlayerPrefs.GetInt("teni", 0) == 1)
                            {

                                rigidbody2.gravityScale = 1;
                            }
                            if (PlayerPrefs.GetInt("teni", 0) != 1)
                            {
                                if (Input.GetKey(KeyCode.D))
                                {
                                    rigidbody2.velocity += (new Vector2(100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.A))
                                {
                                    rigidbody2.velocity += (new Vector2(-100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.W))
                                {
                                    rigidbody2.velocity += (new Vector2(0, 200) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.S))
                                {
                                    rigidbody2.velocity += (new Vector2(0, -20) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                            }
                        }
                        if (PlayerPrefs.GetInt("t44", 0) == 0)
                        {
                            if (Input.GetKey(KeyCode.D))
                            {
                                rigidbody2.velocity += new Vector2(100, 0);
                            }
                            if (Input.GetKey(KeyCode.A))
                            {
                                rigidbody2.velocity += new Vector2(-100, 0);
                            }
                            if (Input.GetKey(KeyCode.W))
                            {
                                rigidbody2.velocity += new Vector2(0, 100);
                            }
                            if (Input.GetKey(KeyCode.S))
                            {
                                rigidbody2.velocity += new Vector2(0, -100);
                            }

                        }



                        }

                    if (Input.GetKey(KeyCode.E))
                    {
                        if (type == 1)
                        {
                            if (GameObject.FindGameObjectsWithTag("st").Length == 0)
                            {

                                Instantiate(st.gameObject, gameObject.transform.position, Quaternion.identity);
                            }
                        }
                    }

                }
            }
            if (PlayerPrefs.GetInt("TTN", 0) == 1)
            {
                if (PlayerPrefs.GetInt("t44", 0) == 1)
                {
                    forse += 2 * 60 * Time.fixedDeltaTime;
                }
                if (PlayerPrefs.GetInt("t44", 0) == 0)
                {
                    forse = 0;
                }
                if (PlayerPrefs.GetInt("f", 0) == 1)
                {
                    type = 1;

                }
                if (PlayerPrefs.GetInt("f", 0) == 0)
                {
                    type = 0;

                }
                
                if (player.GetComponent<igrok>().fight == true)
                {
                    if (PlayerPrefs.GetInt("teni", 0) == 1)
                    {

                        rigidbody2.gravityScale = 1;
                    }
                    if (PlayerPrefs.GetInt("teni", 0) != 1)
                    {
                        if (Input.GetKey(KeyCode.D))
                        {
                            rigidbody2.velocity += (new Vector2(20, 0));
                        }
                        if (Input.GetKey(KeyCode.A))
                        {
                            rigidbody2.velocity += (new Vector2(-20, 0));
                        }
                        if (Input.GetKey(KeyCode.W))
                        {
                            rigidbody2.velocity += (new Vector2(0, 20));
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            rigidbody2.velocity += (new Vector2(0, -20));
                        }
                    }
                    
                    if (player.GetComponent<igrok>().fight == true)
                    {
                        if (PlayerPrefs.GetInt("t44", 0) == 1)
                        {
                            if (PlayerPrefs.GetInt("teni", 0) == 1)
                            {

                                rigidbody2.gravityScale = 1;
                            }
                            if (PlayerPrefs.GetInt("teni", 0) != 1)
                            {
                                if (Input.GetKey(KeyCode.D))
                                {
                                    rigidbody2.velocity += (new Vector2(100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.A))
                                {
                                    rigidbody2.velocity += (new Vector2(-100, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.W))
                                {
                                    rigidbody2.velocity += (new Vector2(0, 200) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                                if (Input.GetKey(KeyCode.S))
                                {
                                    rigidbody2.velocity += (new Vector2(0, -20) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                                }
                            }
                        }
                        if (PlayerPrefs.GetInt("teni", 0) == 1)
                        {
                            if (rigidbody2.velocity.x >= 10 || rigidbody2.velocity.x <= -10 || rigidbody2.velocity.y >= 10 || rigidbody2.velocity.y <= 10)
                            {
                                if (Input.GetKey(KeyCode.D))
                                {
                                    rigidbody2.AddForce(new Vector2(20, 0));
                                }
                                if (Input.GetKey(KeyCode.A))
                                {
                                    rigidbody2.AddForce(new Vector2(-20, 0));
                                }
                                if (Input.GetKey(KeyCode.W))
                                {
                                    rigidbody2.AddForce(new Vector2(0, 20));
                                }
                                if (Input.GetKey(KeyCode.S))
                                {
                                    rigidbody2.AddForce(new Vector2(-20, 0));
                                }
                            }
                            else
                            {
                                rigidbody2.velocity = (new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target2").transform.up.x, GameObject.FindWithTag("Target2").transform.up.y) * forse);
                            }

                        }
                    }

                    if (Input.GetKey(KeyCode.E))
                    {
                        if (type == 1)
                        {
                            if (GameObject.FindGameObjectsWithTag("st").Length == 0)
                            {

                                Instantiate(st.gameObject, gameObject.transform.position, Quaternion.identity);
                            }
                        }
                    }

                }
            }
        }

    }
}