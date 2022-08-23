using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class deatrh1 : MonoBehaviour
{
    public GameObject[] t1;
    public GameObject t2;
    public string savechach = "siji";
    public bool en;
    public battlesave s = new battlesave();
    public save s3 = new save();
    public bool r;
    private void Start()
    {
        
    }
    void Update()
    {
        
        t1 = new GameObject[GameObject.FindObjectsOfType<Player23>().Length];
        for (int i=0;i<GameObject.FindObjectsOfType<Player23>().Length;i++)
        {
           
            t1[i] = GameObject.FindObjectsOfType<Player23>()[i].gameObject;
            s = JsonUtility.FromJson<battlesave>(File.ReadAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/bposition.un"));
            s3 = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/position" + s.idscene[0] / 150 + ".un"));

            if (t1[i].transform.position.y <= transform.position.y && !en)
            {

                s3.enter[SceneManager.GetActiveScene().buildIndex - t1[i].GetComponent<Player23>().scenevi * 150] = false;
                File.WriteAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/bposition.un",JsonUtility.ToJson(s));
                File.WriteAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/position" + s.idscene[0] / 150 + ".un", JsonUtility.ToJson(s3));

                r = true;

                PlayerPrefs.SetInt("delete", 1);

            }
            if (t1[i].transform.position.y >= transform.position.y && en)
            {

                s3.enter[SceneManager.GetActiveScene().buildIndex - t1[i].GetComponent<Player23>().scenevi * 150] = false;
                File.WriteAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/bposition.un", JsonUtility.ToJson(s));
                File.WriteAllText(@"DELTAFATE/" + GameObject.FindObjectsOfType<Player23>()[i].name33 + "/position" + s.idscene[0] / 150 + ".un", JsonUtility.ToJson(s3));

                r = true;

                PlayerPrefs.SetInt("delete", 1);

            }
            
        }
        t2 = t1[GameObject.FindObjectsOfType<Player23>().Length -1].GetComponent<Player23>().gameObject;
        if (t2 && r == true)
        {
            SceneManager.LoadSceneAsync(s.idscene[0]);
        }
    }
}
