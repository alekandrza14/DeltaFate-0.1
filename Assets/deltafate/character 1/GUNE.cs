using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class GUNE : MonoBehaviour
{

    public int id;
    public rtt[] guns;

    public Guns1 s = new Guns1();
    

    // Start is called before the first frame update
    private void Start()
    {
        guns = GameObject.FindObjectsOfType<rtt>();
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/scene_"+SceneManager.GetActiveScene().name + @"/gun" + id.ToString()))
        {
            s = JsonUtility.FromJson<Guns1>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString()));
            for (int i=0;i< GameObject.FindObjectsOfType<rtt>().Length;i++)
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
            Directory.CreateDirectory(@"DELTAFATE/" + "henry" + @"/scene_" + SceneManager.GetActiveScene().name);
            s.enter = new bool[GameObject.FindObjectsOfType<rtt>().Length];
            for (int i = 0; i < GameObject.FindObjectsOfType<rtt>().Length; i++)
            {
                s.enter[i] = guns[i].r1 == 1;
            }
            File.WriteAllText(@"DELTAFATE/" + "henry" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString(),JsonUtility.ToJson(s));

        }


    }
    

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("gun", -1) != -1)
        {
            

                

            
                s.enter[PlayerPrefs.GetInt("gun", -1)] = false;
            
            File.WriteAllText(@"DELTAFATE/" + "henry" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString(), JsonUtility.ToJson(s));
            s = JsonUtility.FromJson<Guns1>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/scene_" + SceneManager.GetActiveScene().name + @"/gun" + id.ToString()));



            guns[PlayerPrefs.GetInt("gun", -1)].r1 = 0;
            PlayerPrefs.SetInt("gun",-1);

            
        }
    }
    
}
public class Guns1
{
    public bool[] enter;
}
