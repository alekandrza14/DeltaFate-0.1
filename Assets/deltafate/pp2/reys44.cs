using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class reys44 : MonoBehaviour
{
    public GameObject player;
    public Sprite[] s11;
    public Sprite[] s12;
    public SpriteRenderer renderer1;
    public items s1 = new items();
    public float tic;
    public Texture2D[] txt = new Texture2D[5];
    public GameObject hoe_oterra;
    // Start is called before the first frame update
    void Start()
    {
       

        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));




        }
        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
        {
            if (s11.Length < PlayerPrefs.GetInt("gunr3", 0))
            {
                if (s11[PlayerPrefs.GetInt("gunr3", 0)] != null)
                {
                    renderer1.sprite = s11[PlayerPrefs.GetInt("gunr3", 0)];

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));




        }

        tic += 1 * Time.deltaTime;

        if (PlayerPrefs.GetInt("gunr3", -1) == 3)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (s1.patrons[3]>0)
                {


                    Instantiate(hoe_oterra, transform);
                }
            }
        }
        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
        {
            if (tic >= 2)
            {
                if (s11.Length > PlayerPrefs.GetInt("gunr3", 0))
                {
                    if (s11[PlayerPrefs.GetInt("gunr3", 0)] != null)
                    {


                        renderer1.sprite = s11[PlayerPrefs.GetInt("gunr3", 0)];
                    }
                    else
                    {
                        renderer1.sprite = null;
                    }
                }
                else
                {
                    renderer1.sprite = null;
                }
                tic = 0;
            }

        }
        else
        {
            renderer1.sprite = null;
        }
        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
        {



            if (Input.GetKeyDown(KeyCode.Mouse0))
            {





                if (s12.Length > PlayerPrefs.GetInt("gunr3", 0))
                {
                    if (s12[PlayerPrefs.GetInt("gunr3", 0)] != null)
                    {
                        renderer1.sprite = s12[PlayerPrefs.GetInt("gunr3", 0)];

                    }
                    else
                    {
                        renderer1.sprite = null;
                    }
                }
                else
                {
                    renderer1.sprite = null;
                }


            }
            if (PlayerPrefs.GetInt("gunr3", 0) == 6)
            {


                if (Input.GetKey(KeyCode.Mouse0))
                {


                    if (s12.Length > PlayerPrefs.GetInt("gunr3", 0))
                    {
                        if (s12[PlayerPrefs.GetInt("gunr3", 0)] != null)
                        {
                            renderer1.sprite = s12[PlayerPrefs.GetInt("gunr3", 0)];


                        }
                        else
                        {
                            renderer1.sprite = null;
                        }

                    }
                    else
                    {
                        renderer1.sprite = null;
                    }
                }
            }


        }
        else
        {
            renderer1.sprite = null;
        }
        
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 0);

    }


}
