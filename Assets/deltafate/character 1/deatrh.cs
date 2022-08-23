using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class deatrh : MonoBehaviour
{
    public GameObject[] t1;
    public save s;
    void Update()
    {
        s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/henry/position.un"));
        if (t1[0].transform.position.y >= transform.position.y)
        {
            
            s.enter[SceneManager.GetActiveScene().buildIndex] = false;
            File.WriteAllText(@"DELTAFATE/henry/position.un", JsonUtility.ToJson(s));
            
                SceneManager.LoadSceneAsync(15);
            
            PlayerPrefs.SetInt("delete",1);
            
        }
    }
}
