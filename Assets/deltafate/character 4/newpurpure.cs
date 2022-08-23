using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newpurpure : MonoBehaviour
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
    public GameObject[] line;
    public int numberline;
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
    private void Update()
    {
        if (Input.GetKeyDown(w1) && numberline < line.Length && numberline >= 0)
        {
            numberline++;
        }
        if (Input.GetKeyDown(s1) && numberline < line.Length && numberline >= 0)
        {
            numberline--;
        }
    }
    void FixedUpdate()
    {
         for (int i = 0; i < line.Length; i++)
            {

                if (i == numberline)
                {
                    transform.position = new Vector3(transform.position.x, line[numberline].transform.position.y, transform.position.z);
                }

            }

        
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



            if (Input.GetKey(d1))
            {
                rigidbody2.velocity += new Vector2(100, 0);
            }
            if (Input.GetKey(a1))
            {
                rigidbody2.velocity += new Vector2(-100, 0);
            }

            if (numberline > line.Length -1)
            {
                numberline = line.Length - 1;
            }
            if (numberline <= 0)
            {
                numberline = 0;
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



                
                   
                    



                
            }
           
        }
        if (player.GetComponent<igrok2>().fight == false)
        {

            rigidbody2.velocity = (new Vector2(0, 0));


        }

    }
}
