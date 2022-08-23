using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soul_move1 : MonoBehaviour
{
    

    public Rigidbody2D rigidbody2;

    
    public SpriteRenderer renderer1;
    public int renderer2;
    public Sprite sp;
    public float tic;
    public KeyCode s1;
    public KeyCode w1;
    public KeyCode d1;
    public KeyCode a1;
    public int hp;
    
    void Start()
    {
        //isinstialization
        
        rigidbody2 = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D s)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        
        
       
            if (s.gameObject.tag == "tx")
            {
                hp -= 2;
            }
            if (s.gameObject.tag == "t2")
            {
                hp -= 10;
            }
            if (s.gameObject.tag == "t3")
            {
                hp -= 20;
            }
        


    }

    void FixedUpdate()
    {

        if (hp <= 0)
        {

            renderer1.sprite = sp;
            tic += 1 * Time.deltaTime;
            hp = 0;
        }

        if (tic >= 0.5f)
        {
            Destroy(gameObject);
        }
        
                rigidbody2.velocity = (new Vector2(0, 0));


            

           
            
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
}
