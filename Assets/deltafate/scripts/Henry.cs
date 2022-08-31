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
        System.Save.isata.Data = false;
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
        Updateb();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        
        if (isMain)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
        }
        anim.SetFloat("vert", direction.y *1.5f);
        anim.SetFloat("hor", direction.x * 1.5f);
        if (adirectoin.x != 0 && adirectoin.y != 0)
        {
            anim.SetFloat("vert", -adirectoin.y * 1.5f);
            anim.SetFloat("hor", -adirectoin.x * 1.5f);
        }
    }
    private void FixedUpdate()
    {
        if (!System.Save.isata.onbatlle)
        {


            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime /3);
        }
    }
}
