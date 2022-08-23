using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMP : MonoBehaviour
{
    public float forse;
    public float tic;
    public float tic2;
    public int time = 20;
    public int time2 = 800;
    public GameObject[] obj1;
    public int time3 = 400;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tic += 1 * 60 * Time.deltaTime;
        tic2 += 1 * 60 * Time.deltaTime;

        GetComponent<Rigidbody2D>().velocity = transform.right * forse;
        if (obj1.Length != 0)
        {


            if (tic >= time)
            {



               GameObject g = Instantiate(obj1[0], transform);
                g.transform.parent = GameObject.FindWithTag("Player").transform.parent;
                GameObject g1 = Instantiate(obj1[1], transform);
                g1.transform.parent = GameObject.FindWithTag("Player").transform.parent;
                tic = 0;

            }

            

        }
        if (tic2 >= time2)
        {
            Destroy(gameObject);
        }
    }
}
