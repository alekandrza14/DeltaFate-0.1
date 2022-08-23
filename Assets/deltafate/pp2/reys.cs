using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class reys : MonoBehaviour
{
    public GameObject player;
    public Sprite[] s11;
    public Sprite[] s12;
    public SpriteRenderer renderer1;
    public items s1 = new items();
    public float tic;
    public Texture2D[] txt = new Texture2D[5];
    public GameObject hoe_oterra;
    public GameObject[] items;
    public GameObject bmp;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject == GameObject.FindObjectOfType<reys>().gameObject)
        {


            Instantiate(Resources.Load<GameObject>("er"), transform.position, Quaternion.identity);
        }
        if (File.Exists(@"res/big_pistol.png") && File.Exists(@"res/big_pistol_active.png"))
        {


            WWW www = new WWW("file:///res/big_pistol.png");
            WWW www2 = new WWW("file:///res/big_pistol_active.png");
            txt[0] = www.texture;
            txt[1] = www2.texture;
            txt[0].filterMode = FilterMode.Point;
            txt[1].filterMode = FilterMode.Point;

            s11[1] = Sprite.Create(txt[0], new Rect(0, 0, txt[0].width, txt[0].height), Vector2.one / 2, 1);
            s12[1] = Sprite.Create(txt[1], new Rect(0, 0, txt[1].width, txt[1].height), new Vector2(0.9999f, 0.5f), 1);
        }
        if (File.Exists(@"res/hoe_oterra.png") && File.Exists(@"res/hoe_oterra_active.png"))
        {


            WWW www = new WWW("file:///res/hoe_oterra.png");
            WWW www2 = new WWW("file:///res/hoe_oterra_active.png");
            txt[2] = www.texture;
            txt[3] = www2.texture;
            txt[2].filterMode = FilterMode.Point;
            txt[3].filterMode = FilterMode.Point;

            s11[3] = Sprite.Create(txt[2], new Rect(0, 0, txt[2].width, txt[2].height), Vector2.one / 2, 1);
            s12[3] = Sprite.Create(txt[3], new Rect(0, 0, txt[3].width, txt[3].height), new Vector2(0.9999f, 0.5f), 1);
        }

        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
        {
            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));




        }
        if (PlayerPrefs.GetInt("gunr", -1) != -1)
        {
            if (s11.Length < PlayerPrefs.GetInt("gunr", 0) -1)
            {
                if (s11[PlayerPrefs.GetInt("gunr", 0)] != null)
                {
                    renderer1.sprite = s11[PlayerPrefs.GetInt("gunr", 0)];

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

        if (PlayerPrefs.GetInt("gunr", -1) == 3)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (s1.patrons[3] > 0)
                {


                    Instantiate(hoe_oterra, transform);
                }
            }
        }
        if (PlayerPrefs.GetInt("gunr", -1) == 2 && PlayerPrefs.GetInt("soul_error", -1) == 1)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (s1.patrons[2] > 0)
                {


                    Instantiate(Resources.Load<GameObject>("error_pet"), transform.position,Quaternion.identity);
                }
            }
        }
        if (PlayerPrefs.GetInt("gunr", -1) != -1)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (items.Length > PlayerPrefs.GetInt("gunr", -1))
                {
                    if (items[PlayerPrefs.GetInt("gunr", -1)] != null)
                    {

                       
                        Instantiate(items[PlayerPrefs.GetInt("gunr", -1)], new Vector3(transform.position.x, transform.position.y+50, transform.position.z), Quaternion.identity);
                        s1.itemid.RemoveAt(PlayerPrefs.GetInt("gunrset", -1));
                        Directory.CreateDirectory(@"DELTAFATE/" + "henry");
                        File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                    }
                }
            }
        }
        if (PlayerPrefs.GetInt("gunr", -1) == 24)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (s1.patrons[24] > 0)
                {

                    Vector3 difference = Camera.main.ViewportToScreenPoint(new Vector3(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2, 0)) - transform.position;
                    float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                    
                    GameObject g = Instantiate(bmp, transform.position, Quaternion.Euler(0f, 0f, rotZ + 0)).gameObject;
                    
                    
                }
            }
        }

        if (PlayerPrefs.GetInt("gunr", -1) != -1)
        {
            if (tic >= 2)
            {
                if (s11.Length > PlayerPrefs.GetInt("gunr", 0) -1)
                {
                    if (s11[PlayerPrefs.GetInt("gunr", 0)] != null)
                    {


                        renderer1.sprite = s11[PlayerPrefs.GetInt("gunr", 0)];
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
        if (PlayerPrefs.GetInt("gunr", -1) != -1)
        {



            if (Input.GetKeyDown(KeyCode.Mouse0))
            {





                if (s12.Length > PlayerPrefs.GetInt("gunr", 0) -1)
                {
                    if (s12[PlayerPrefs.GetInt("gunr", 0)] != null)
                    {
                        renderer1.sprite = s12[PlayerPrefs.GetInt("gunr", 0)];

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
            if (PlayerPrefs.GetInt("gunr", 0) == 6)
            {


                if (Input.GetKey(KeyCode.Mouse0))
                {


                    if (s12.Length > PlayerPrefs.GetInt("gunr", 0) -1)
                    {
                        if (s12[PlayerPrefs.GetInt("gunr", 0)] != null)
                        {
                            renderer1.sprite = s12[PlayerPrefs.GetInt("gunr", 0)];


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
        if (Camera.main.orthographic == false)
        {


            Vector3 difference = Camera.main.ViewportToScreenPoint (new Vector3(Input.mousePosition.x - Screen.width / 2,Input.mousePosition.y - Screen.height / 2,0)) - transform.position;
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
