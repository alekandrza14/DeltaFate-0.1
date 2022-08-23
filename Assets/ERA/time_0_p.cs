using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class time_0_p : MonoBehaviour
{
    public long level;
    public Rigidbody2D rigidbody2;
    public save3 s6 = new save3();
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"DELTAFATE/ERA/position.un"))
        {


            s6 = JsonUtility.FromJson<save3>(File.ReadAllText(@"DELTAFATE/ERA/position.un"));
            if (s6.enter[SceneManager.GetActiveScene().buildIndex - 50] == true)
            {


                transform.position = s6.v3[SceneManager.GetActiveScene().buildIndex - 50];
                Debug.Log("u");
            }



            level = s6.level;

            long lvl;
            lvl = level;
            lvl /= 110 + level / 20;
            lvl += 11;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2.velocity = Vector2.zero;

        rigidbody2.velocity += new Vector2(Input.GetAxis("Horizontal1")*5, Input.GetAxis("Vertical") * 5);
        
        s6.enter[SceneManager.GetActiveScene().buildIndex - 50] = true;
        s6.idscene = SceneManager.GetActiveScene().buildIndex - 50; 
        s6.level = level;
        s6.v3[SceneManager.GetActiveScene().buildIndex - 50] = transform.position;
        Directory.CreateDirectory(@"DELTAFATE/ERA");
        File.WriteAllText(@"DELTAFATE/ERA/position.un", JsonUtility.ToJson(s6));
    }
}
public class save3
{
    public Vector3[] v3 = new Vector3[150];
    public bool[] enter = new bool[150];
    public long level = 11000;
    public int idscene;
    public string name = "ERA";

}
