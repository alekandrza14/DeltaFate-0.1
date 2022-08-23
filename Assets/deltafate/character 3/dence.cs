using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class dence : MonoBehaviour
{
    public KeyCode arrows; public KeyCode wasd;
    public float tic; 
    public float tic2;
    public float time = 2;
    public float timefell = 4;
    public float end = 45;
    public int xp = 1000;

    public int Random1;
    public battlesave s = new battlesave();
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

            if (File.Exists(@"DELTAFATE/" + "henry1" + "/bposition.un"))
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "henry1" + "/bposition.un"));

            }
        }
        if (PlayerPrefs.GetString("ch", "henry") == "siji")
        {
            if (File.Exists(@"DELTAFATE/" + "siji0" + "/bposition.un"))
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "siji0" + "/bposition.un"));

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
            Random1 = Random.Range(0,4);
            
        }
        if (Random1 == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.green;

        }
        if (tic >= timefell && Random1 == 2)
        {
            Random1 = 0;
            tic = 0;

            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (tic2 >= end)
        {
            Random1 = 0;
            tic = 0;
            if (PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "henry1" + "/bposition.un"));
                s.level += xp;
                File.WriteAllText(@"DELTAFATE/" + "henry1" + "/bposition.un", JsonUtility.ToJson(s));
                SceneManager.LoadScene(s.idscene[0]);
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "siji0" + "/bposition.un"));
                s.level += xp;
                File.WriteAllText(@"DELTAFATE/" + "siji0" + "/bposition.un", JsonUtility.ToJson(s));
                SceneManager.LoadScene(s.idscene[0]);
            }
        }
        if (tic >= timefell && Random1 == 3 || tic >= timefell && Random1 == 1 || tic >= timefell && Random1 == 4 || tic >= timefell && Random1 == 0)
        {
            Random1 = 0;
            tic = 0;
            
            
        }
        if (Random1 == 0 && Input.GetKeyDown(arrows) || Random1 == 0 && Input.GetKeyDown(wasd))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            Random1 = 0;
            tic = 0;
        }
        if (Random1 == 2 && Input.GetKeyDown(arrows) || Random1 == 2 && Input.GetKeyDown(wasd))
        {
            if(PlayerPrefs.GetString("ch", "henry") == "henry")
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "henry1" + "/bposition.un"));
                s.level += 10;
                File.WriteAllText(@"DELTAFATE/" + "henry1" + "/bposition.un", JsonUtility.ToJson(s));
                
            }
            if (PlayerPrefs.GetString("ch", "henry") == "siji")
            {
                s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + "siji0" + "/bposition.un"));
                s.level += 10;
                File.WriteAllText(@"DELTAFATE/" + "siji0" + "/bposition.un", JsonUtility.ToJson(s));
                
            }
            GetComponent<SpriteRenderer>().color = Color.blue;
            Random1 = 0;
            tic = 0;
        }
        if (GetComponent<SpriteRenderer>().color == Color.red) 
        {
            SceneManager.LoadScene(31);
        }
        
    }
}
