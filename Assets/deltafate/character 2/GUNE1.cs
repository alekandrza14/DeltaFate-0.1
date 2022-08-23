using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class GUNE1 : MonoBehaviour
{

    public int id;
    public rtt1[] guns;

    public Guns2 s = new Guns2();
    

    // Start is called before the first frame update
    private void Start()
    {
        guns = GameObject.FindObjectsOfType<rtt1>();
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/scene_"+SceneManager.GetActiveScene().name + @"/gun" + id.ToString()))
        {
            s = JsonUtility.FromJson<Guns2>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString()));
            for (int i=0;i< GameObject.FindObjectsOfType<rtt1>().Length;i++)
            {
                if (s.enter[i] == false)
                {


                    guns[i].r1 = 0;
                }

                if (s.enter[i] == true)
                {


                    guns[i].r1 = 1;
                }
            }

        }
        else
        {
            Directory.CreateDirectory(@"DELTAFATE/" + "siji" + @"/scene_" + SceneManager.GetActiveScene().name);
            s.enter = new bool[GameObject.FindObjectsOfType<rtt1>().Length];
            for (int i = 0; i < GameObject.FindObjectsOfType<rtt1>().Length; i++)
            {
                s.enter[i] = guns[i].r1 == 1;
            }
            File.WriteAllText(@"DELTAFATE/" + "siji" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString(),JsonUtility.ToJson(s));

        }


    }
    

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("gun1", -1) != -1)
        {
            

                

            
                s.enter[PlayerPrefs.GetInt("gun1", -1)] = false;
            
            File.WriteAllText(@"DELTAFATE/" + "siji" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString(), JsonUtility.ToJson(s));
            s = JsonUtility.FromJson<Guns2>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString()));



            guns[PlayerPrefs.GetInt("gun1", -1)].r1 = 0;
            PlayerPrefs.SetInt("gun1",-1);

            
        }
    }
    
}
public class Guns2
{
    public bool[] enter;
}
