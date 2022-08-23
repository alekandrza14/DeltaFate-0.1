using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Henry : ActiveBehaiver
{
    public float speed;
    public Animator anim;
    Vector2 direction;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        for (int i=0;i<FindObjectsOfType<SpriteRenderer>().Length;i++)
        {
            if (!FindObjectsOfType<SpriteRenderer>()[i].gameObject.GetComponent<sorting>())
            {


                FindObjectsOfType<SpriteRenderer>()[i].gameObject.AddComponent<sorting>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("vert", direction.y *1.5f);
        anim.SetFloat("hor", direction.x * 1.5f);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+direction*speed*Time.fixedDeltaTime);
    }
}
