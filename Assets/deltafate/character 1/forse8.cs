using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse8 : MonoBehaviour
{
    public bool vc; 
    public bool vc3;
    public Vector2 vc2;
    public Vector2 vc21;
    public int dist;
    public int type = 1;
    public int forse;
    public float tic;
    public int s = 2;
    public string names;
    private void Start()
    {
        phisics.start(names, gameObject,type);
        vc21 = new Vector2(transform.position.x, transform.position.y);
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "2")
        {
            Destroy(gameObject);
        }
        if (s.tag == "3")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0,0.5f);
        }
    }
    void Update()
    {
        
        if (PlayerPrefs.GetInt("dif", 0) >= 1)
        {
            tic += 2 * Time.deltaTime;
            if (tic >= 1)
            {
                vc2.x = Random.Range(-3f * s, 3f * s);
                vc2.y = Random.Range(-3f * s, 3f * s);
                tic = 0;
            }
        }
        if (PlayerPrefs.GetInt("dif", 0) >= 3)
        {
            tic += 2 * Time.deltaTime;
            if (tic >= 20)
            {
                vc2.x = Random.Range(-44f * s, 44f * s);
                vc2.y = Random.Range(-44f * s, 44f * s);
                tic = 0;
            }
        }
        forse++;
        if (type == 1)
        {

            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target").transform.up.x, GameObject.FindWithTag("Target").transform.up.y) * forse) + vc2;

        }
        if (type == 2)
        {

            phisics.startupdate(names,gameObject, GetComponent<Rigidbody2D>(), type);
        }
        if (type == 0)
        {


            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, 0) + new Vector2(GameObject.FindWithTag("Target").transform.up.x, GameObject.FindWithTag("Target").transform.up.y) * forse) + vc2;
        }


    }
}
