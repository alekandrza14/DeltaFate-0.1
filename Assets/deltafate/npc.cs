using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class npc : MonoBehaviour
{

    public int hp = 50;
    public int maxhp = 50;
    public bool run;
    public GameObject ps;
    public pathin pathrun = new pathin();
    public string path;
    public float tic;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"res/ai/"+path))
        {
            pathrun = JsonUtility.FromJson<pathin>(File.ReadAllText(@"res/ai/" + path));
            run = true;
        }
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "1")
        {
            hp = 0;
        }
        if (s.tag == "bmp")
        {
            if (ps)
            {


                Instantiate(ps.gameObject, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (run == true)
        {
            tic += 1 * 60 * Time.deltaTime;
            if (tic < pathrun.v4.Count)
            {


                transform.position = new Vector3(pathrun.v4[Mathf.FloorToInt(tic)].x, pathrun.v4[Mathf.FloorToInt(tic)].y, pathrun.v4[Mathf.FloorToInt(tic)].z);
            }
            else
            {
                tic = 0;
            }

        }
       


                if (hp <= 0)
                {
                    if (ps)
                    {


                        Instantiate(ps.gameObject, transform.position, transform.rotation);
                    }
                    Destroy(gameObject);
                }
            
            
            
        
        

    }

}

