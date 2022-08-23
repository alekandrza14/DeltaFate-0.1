using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using UnityEngine.SceneManagement;

public class sttszombe : MonoBehaviour
{
    public string s;
    public zombieobj zo;
    public sct start;
    private void Start()
    {
        bool sp = false; bool sp1 = false; bool sp2 = false;
        sct s = new sct();
        s = start;
        for (int i = 0; i < s.idscene.Length;i++)
        {
            if (s.idscene[i] == SceneManager.GetActiveScene().buildIndex)
            {
                if (s.idtype[i] == 3)
                {
                    sp = true;
                    Debug.Log("type scene " + 3);
                }
                else
                {
                    Debug.Log("type scene " + s.idtype[i]);
                }
                if (s.idtype[i] == 0)
                {
                    sp1 = true;

                }
                if (s.idtype[i] == 5)
                {
                    sp2 = true;

                }
            }

        }

        for (int i = 0; i < zo.namespawnzombie.Length; i++)
        {



            if (zo.namespawnzombie[i] == "1000" && Random.Range(0, 20) == 1 && sp)
            {
                GameObject g = Instantiate(zo.idspawnzombie[i]);
                g.transform.position = GameObject.FindWithTag("Player").transform.position;
                g.transform.position += new Vector3(0, 200, 0);
            }
            if (zo.namespawnzombie[i] == "1000" && Random.Range(0, 20) >= 1 && Random.Range(0, 20) <= 19 && sp2)
            {
                GameObject g = Instantiate(zo.idspawnzombie[i]);
                g.transform.position = GameObject.FindWithTag("Player").transform.position;
                g.transform.position += new Vector3(0, 200, 0);
            }
            if (zo.namespawnzombie[i] == "0101" && Random.Range(0, 2) == 1 && sp1)
            {
                GameObject g = Instantiate(zo.idspawnzombie[i]);
                g.transform.position = GameObject.FindWithTag("Player").transform.position;
                g.transform.position += new Vector3(0, 200, 0);
            }
        }
    }
    private void OnGUI()
    {
        if (Directory.Exists(@"debug"))
        {


            GUILayout.TextField(s, 10);
            GUILayout.TextArea(s, 10);
            

        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            string s2 ="";
            foreach (char litter in s.ToCharArray(0, s.Length -1))
            {
                s2 += litter;
            }
            s = s2;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {

            s += 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            s += 1;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            for (int i = 0; i < zo.namespawnzombie.Length; i++)
            {



                if (zo.namespawnzombie[i] == s)
                {
                    GameObject g = Instantiate(zo.idspawnzombie[i]);
                    g.transform.position = GameObject.FindWithTag("Player").transform.position;
                    g.transform.position += new Vector3(0, 200, 0);
                }
            }
        }
    }
}
