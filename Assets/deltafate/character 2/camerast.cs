using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class camerast : MonoBehaviour
{
    public int level;
    public string name1;
    public GameObject targetmove;
    public save s = new save();
    void Start()
    {
        if (File.Exists(@"DELTAFATE/siji/position.un"))
        {
            s = JsonUtility.FromJson<save>(File.ReadAllText(@"DELTAFATE/siji/position.un"));
            name1 = s.name;
            level = s.level;
            if (s.enter[SceneManager.GetActiveScene().buildIndex] == true)
            {


                transform.position = s.v3[SceneManager.GetActiveScene().buildIndex];
            }
        }
        if (!File.Exists(@"DELTAFATE/siji/position.un"))
        {
            name1 = "siji";
            level = 0;
            s.name = name1;
            s.level = level;
        }
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/siji");
        File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));

    }


    void Update()
    {
        if (gameObject.GetComponent<Camera>().orthographicSize <= 283.4498f)
        {


            if (Input.GetKeyDown(KeyCode.F1))
            {
                gameObject.GetComponent<Camera>().orthographicSize *= 1.1f;
            }
        }
        if (gameObject.GetComponent<Camera>().orthographicSize >= 61.6869f)
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                gameObject.GetComponent<Camera>().orthographicSize /= 1.1f;
            }

        }


        if (deltacontrols.getcontrols.s12[0] == "Escape")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (Input.GetKey(deltacontrols.getcontrols.s12[0]))
            {
                SceneManager.LoadScene(0);
            }
        }
        s.level = level;
        s.v3[SceneManager.GetActiveScene().buildIndex] = transform.position;
        s.enter[SceneManager.GetActiveScene().buildIndex] = true;
        s.idscene = SceneManager.GetActiveScene().buildIndex;
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/siji");
        File.WriteAllText(@"DELTAFATE/siji/position.un", JsonUtility.ToJson(s));

        if (targetmove != null)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                targetmove.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 90 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 90 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(90 * Time.deltaTime,0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(90 * Time.deltaTime, 0, 0);
        }
    }
}
