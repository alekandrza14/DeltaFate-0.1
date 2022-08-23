using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class reys1 : MonoBehaviour
{
    public GameObject player;
    public Sprite[] s11;
    public Sprite[] s12;
    public SpriteRenderer renderer1;
    public items s1 = new items();
    public float tic;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));




        }
        if (PlayerPrefs.GetInt("gunr1", -1) != -1)
        {
            renderer1.sprite = s11[PlayerPrefs.GetInt("gunr1", 0)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));




        }

        tic += 1 * Time.deltaTime;
        if( s11.Length > PlayerPrefs.GetInt("gunr1", -1)) {
            if (PlayerPrefs.GetInt("gunr1", -1) != -1)
            {
                if (tic >= 2)
                {
                    renderer1.sprite = s11[PlayerPrefs.GetInt("gunr1", 0)];
                    tic = 0;
                }
            }
            if (PlayerPrefs.GetInt("gunr1", -1) != -1)
            {



                if (Input.GetKeyDown(KeyCode.Mouse0))
                {







                    renderer1.sprite = s12[PlayerPrefs.GetInt("gunr1", 0)];



                }
                if (PlayerPrefs.GetInt("gunr1", 0) == 6)
                {


                    if (Input.GetKey(KeyCode.Mouse0))
                    {



                        renderer1.sprite = s12[PlayerPrefs.GetInt("gunr1", 0)];



                    }
                }

            }
        }
        if (Camera.main.orthographic == false)
        {


            Vector3 difference = Camera.main.ViewportToScreenPoint(new Vector3(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2, 0)) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 0);
        }
        else
        {


            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 0);

        }
    }
}
