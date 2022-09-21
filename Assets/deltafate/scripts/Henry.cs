using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Henry : ActiveBehaiver
{
    public float speed;
    public Animator anim;
    public float size;
    Vector2 direction;
    float us;
    bool isgraund;
    public float jump = 6;
    float tjump =0, gr = 1f;
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
        switch (DuoInput.ÑancellationS())
        {
            case true:
                us = 1.25f;
                break;
            case false:
                us = 1f;
                break;
        }
        
        if (isMain)
        {
            if (locationtype.GetLocation() == location.top_down)
            {
                rb.gravityScale = 0;

                direction.x = Input.GetAxisRaw("Horizontal");
                direction.y = Input.GetAxisRaw("Vertical");
            }
            if (locationtype.GetLocation() == location.platformer)
            {

                rb.gravityScale = -0;
                tjump -= Time.deltaTime * gr;
                if (Input.GetAxis("Vertical") > 0 && isgraund)
                {
                    tjump = jump;
                    isgraund = false;
                }
                physics0();
                direction.y = tjump;
               direction.x = Input.GetAxisRaw("Horizontal");
            }
        }
        if (locationtype.GetLocation() == location.top_down)
        {
            
            anim.SetFloat("vert", direction.y * 1.5f);
        }
        else if(locationtype.GetLocation() == location.platformer)
        {
            if (!isMain)
            {
                rb.gravityScale = 10;
            }
                anim.SetFloat("jump", direction.y * 1.5f);
        }
            anim.SetFloat("hor", direction.x * 1.5f);
        if (adirectoin.x != 0 && adirectoin.y != 0)
        {
            anim.SetFloat("vert", -adirectoin.y * 1.5f);
            anim.SetFloat("hor", -adirectoin.x * 1.5f);
        }
    }
    private void physics0()
    {

        if (Physics2D.Raycast(transform.position, Vector2.down, size, LayerMask.GetMask("trigger")))
        {
            if (tjump <= 0)
            {



            }
            isgraund = true;
        }
        if (Physics2D.Raycast(transform.position, Vector2.down, size, LayerMask.GetMask("Default")))
        {
            if (tjump <= 0)
            {

                tjump = 0;

            }
            isgraund = true;
        }
        if (Physics2D.Raycast(transform.position, Vector2.up, 1, LayerMask.GetMask("Default")))
        {
            if (tjump <= 0)
            {

                tjump -= Time.deltaTime * gr*2;

            }
            isgraund = false;
        }
    }
    private void FixedUpdate()
    {
        if (!System.Save.isata.onbatlle)
        {


            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime *us);
        }
        else
        {
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime /3);
        }
    }
}
