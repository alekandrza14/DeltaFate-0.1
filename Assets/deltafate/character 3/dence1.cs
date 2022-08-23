using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class dence1 : MonoBehaviour
{
    public KeyCode arrows; public KeyCode wasd;
    public float tic;
    public float tic2;
    public float time = 2;
    public float timefell = 4;
    public float end = 45;
    public int xp = 1000;
    public GameObject note;
    public bool player;


    public int Random1;
    public save s = new save();
    private void OnTriggerEnter2D(Collider2D s)
    {
        if(s.gameObject.tag == "t")
        {
            Random1 = 2;
            tic = 0;
            tic2 = 0;
}
    }
    void Start()
    {
        if (PlayerPrefs.GetString("ch", "henry") == "henry")
        {

            if (File.Exists(@"DELTAFATE/" + "henry1" + "/position.un"))
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + "henry1" + "/position.un"));

            }
        }
        if (PlayerPrefs.GetString("ch", "henry") == "siji")
        {
            if (File.Exists(@"DELTAFATE/" + "siji0" + "/position.un"))
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + "siji0" + "/position.un"));

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        tic += 1 * Time.deltaTime;
        tic2 += 1 * Time.deltaTime;
        if (tic >= time && Random1 == 0)
        {

            PlayerPrefs.SetInt("i",Random.Range(0,2));
            tic = 0;
        }
        
        
        if (tic2 >= end)
        {
            Random1 = 0;
            tic = 0;
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + "henry1" + "/position.un"));
                s.level += xp;
                File.WriteAllText(@"DELTAFATE/" + "henry1" + "/position.un", JsonUtility.ToJson(s));
                SceneManager.LoadScene(s.idscene);
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + "siji0" + "/position.un"));
                s.level += xp;
                File.WriteAllText(@"DELTAFATE/" + "siji0" + "/position.un", JsonUtility.ToJson(s));
                SceneManager.LoadScene(s.idscene);
            }
        }
        if (tic >= timefell && Random1 == 3 || tic >= timefell && Random1 == 1 || tic >= timefell && Random1 == 4 || tic >= timefell && Random1 == 0)
        {
            Random1 = 0;
            
            
            
        }
        if (player == true && PlayerPrefs.GetInt("i", 0) == 0)
        {


            if (Input.GetKeyDown(arrows) || Input.GetKeyDown(wasd))
            {
                Instantiate(note, gameObject.transform);
            }
        }
        if (player == false && PlayerPrefs.GetInt("i", 0) == 1)
        {


            if (Input.GetKeyDown(arrows) || Input.GetKeyDown(wasd))
            {
                Instantiate(note, gameObject.transform);
            }
        }
        if (GetComponent<SpriteRenderer>().color == Color.red) 
        {
            SceneManager.LoadScene(31);
        }
        
    }
}
