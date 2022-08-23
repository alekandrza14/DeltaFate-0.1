using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    public GameObject[] g;
    public float[] g1;

    // Start is called before the first frame update
    void Start()
    {
        g[0] = GameObject.FindObjectOfType<Player>().gameObject;
        g[1] = GameObject.FindObjectOfType<Player1>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("1", 0) == 1)
        {
            for (int i = 0; i < g1.Length; i++)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    g1[0] += 1 * Time.deltaTime;
                    if (g1[0] < 0.5f)
                    {

                        g[0].transform.position += new Vector3(0, 200 * Time.deltaTime, 0);
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (g1[0] > 0.1f)
                    {
                        g[0].transform.position -= new Vector3(0, 200 * Time.deltaTime, 0);

                    }
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    g1[1] += 1 * Time.deltaTime;
                    if (g1[1] < 0.5f)
                    {

                        g[1].transform.position += new Vector3(0, 200 * Time.deltaTime, 0);
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    if (g1[1] > 0.1f)
                    {
                        g[1].transform.position -= new Vector3(0, 200 * Time.deltaTime, 0);
                    }

                }

            }

        }
        if (PlayerPrefs.GetInt("1", 0) == 0)
        {
            for (int i = 0; i < g1.Length; i++)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    g1[1] += 1 * Time.deltaTime;
                    if (g1[1] < 0.5f)
                    {

                        g[1].transform.position += new Vector3(0, 200 * Time.deltaTime, 0);
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {

                    if (g1[1] > 0.1f)
                    {
                        g[1].transform.position -= new Vector3(0, 200 * Time.deltaTime, 0);
                    }


                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    g1[0] += 1 * Time.deltaTime;
                    if (g1[0] < 0.5f)
                    {

                        g[0].transform.position += new Vector3(0, 200 * Time.deltaTime, 0);
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    if (g1[0] > 0.1f)
                    {
                        g[0].transform.position -= new Vector3(0, 200 * Time.deltaTime, 0);

                    }

                }
            }

        }
    }
    private void OnCollisionStay2D(Collision2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            if (s.gameObject.GetComponent<Player>())
            {
                if (g1[0] != 0)
                {
                    g1[0] = 0;
                }
            }
        }
        if (s.gameObject.tag == "Player")
        {
            if (s.gameObject.GetComponent<Player1>())
            {
                if (g1[1] != 0)
                {
                    g1[1] = 0;
                }
            }
        }
    }
}
