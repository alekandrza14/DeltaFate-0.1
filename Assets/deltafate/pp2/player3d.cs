using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player3d : MonoBehaviour
{
    public save s6 = new save(); public battlesave s = new battlesave();
    public int scenevi;
    public Rigidbody rb;
    public int level;
    public Text txt; public string nime; public string nimep;
    // Start is called before the first frame update
    void Start()
    {
        playermenager.p3load(this, "DELTAFATE/" + nimep, nime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 6, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -6, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += transform.forward *100;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity -= transform.forward * 100;
        }


        if (File.Exists("DELTAFATE/" + nimep+ nime+"/bposition.un"))
        {


            s = JsonUtility.FromJson<battlesave>(File.ReadAllText("DELTAFATE/" + nimep + nime + "/bposition.un"));




            level = s.level;

            int lvl;
            lvl = level;
            lvl /= 110 + level / 20;
            lvl += 11;
            if (PlayerPrefs.GetInt("gunr", -1) != -1)
            {
                txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + level.ToString();
            }
            else
            {
                txt.text = mainname.name[PlayerPrefs.GetInt("ling", 0)] + " : " + lvl.ToString() + mainname.namexp[PlayerPrefs.GetInt("ling", 0)] + " :" + level.ToString();
            }

        }


        playermenager.p3save(this, "DELTAFATE/" + nimep ,nime  ,s6);
    }
}
