using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spg : MonoBehaviour
{
    public int id;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        sps sp = new sps();
        sp.privot = new Vector2(transform.position.x, transform.position.y);
        sp = JsonUtility.FromJson<sps>(PlayerPrefs.GetString("rf" + id, JsonUtility.ToJson(sp)));
        transform.position = new Vector3(sp.privot.x,sp.privot.y, 0);
    }
    // Update is called once per frame
    void Update()
    {
        sps sp = new sps();
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, -20f - speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 20f + speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-20f-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(20f + speed, 0, 0);
        }
        sp.privot = new Vector2(transform.position.x, transform.position.y);

        PlayerPrefs.SetString("rf" + id, JsonUtility.ToJson(sp));
    }

    
}
