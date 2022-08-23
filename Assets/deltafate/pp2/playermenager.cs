using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class battlesave
{
    public int[] idscene = new int[1]
    {
        1
    };
    public Vector3 pos;
    public bool isdead;
    public int level;
}
public class teamsave
{
    public List<string> team = new List<string>();
    
}
public class playermenager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void p1save(Player player, string patch, save ssave)
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }







        ssave.level = player.level;
        ssave.v3[SceneManager.GetActiveScene().buildIndex] = player.transform.position;
        ssave.enter[SceneManager.GetActiveScene().buildIndex] = true;
        ssave.idscene = SceneManager.GetActiveScene().buildIndex;
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/henry");
        if (PlayerPrefs.GetInt("delete", 0) != 1)
        {


            File.WriteAllText(patch, JsonUtility.ToJson(ssave));

        }
        else
        {
            PlayerPrefs.SetInt("delete", 0);
        }
    }
    public static void p1shot(items s1, GameObject gameObject, int type)
    {
        if(PlayerPrefs.GetInt("dif", 0) == 4)
        {
            PlayerPrefs.SetString("text2", "жертва");
        }
        if (type == 0)
        {


            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                if (hit.collider != null)
                {
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<zombie>() != null)
                        {
                            hit.collider.gameObject.GetComponent<zombie>().hp -= 8;
                        }
                    }
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<zombie1>() != null)
                        {
                            hit.collider.gameObject.GetComponent<zombie1>().hp -= 8;
                        }
                    }
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<npc>() != null)
                        {
                            hit.collider.gameObject.GetComponent<npc>().hp -= 8;
                        }
                    }


                }
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("ligtingenemy"));
                if (hit.collider != null)
                {
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<zombie>() != null)
                        {
                            hit.collider.gameObject.GetComponent<zombie>().hp -= 400;
                        }
                    }
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<npc>() != null)
                        {
                            hit.collider.gameObject.GetComponent<npc>().hp -= 400;
                        }
                    }


                }
            }
            if (PlayerPrefs.GetInt("gunr", -1) != -1 && PlayerPrefs.GetInt("gunr", -1) != 22)
            {
                if (s1 != null)
                {
                    if (s1.patrons[PlayerPrefs.GetInt("gunr", -1)] >= 1)
                    {
                        if (File.Exists(@"DELTAFATE/" + "henry" + @"/inventory.un"))
                        {
                            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



                        }


                        if (PlayerPrefs.GetInt("gunr", -1) != -1)
                        {
                            if (guns.IDcountdamage[PlayerPrefs.GetInt("gunr", -1)] < 2)
                            {



                                if (Input.GetKeyDown(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie1>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie1>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }
                            }





                        }
                        if (PlayerPrefs.GetInt("gunr", -1) != -1)
                        {
                            if (guns.IDlessdamade[PlayerPrefs.GetInt("gunr", -1)] > 2)
                            {



                                if (Input.GetKeyDown(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 60)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 60)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie1>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie1>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 60)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }
                            }





                        }
                        if (PlayerPrefs.GetInt("gunr", -1) != -1)
                        {
                            if (guns.IDcountdamage[PlayerPrefs.GetInt("gunr", -1)] > 1)
                            {


                                if (Input.GetKey(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie1>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie1>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= guns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }


                            }


                        }



                    }
                }
            }

        }
        if (type == 3)
        {


            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f,LayerMask.GetMask("Ignore Raycast"));
                if (hit.collider != null)
                {
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<PlayerAnime>() != null)
                        {
                            if (hit.collider.gameObject.GetComponent<PlayerAnime>().ishenry != false)
                            {
                                hit.collider.gameObject.GetComponent<PlayerAnime>().level -= 800;
                            }
                        }
                    }
                    


                }
            }
            

        }
        if (type == 1)
        {

            if (PlayerPrefs.GetInt("gunr1", -1) != -1)
            {



                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                    if (hit.collider != null)
                    {
                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                        {
                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                            {
                                hit.collider.gameObject.GetComponent<zombie>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)] * 20;
                            }
                        }
                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                        {
                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                            {
                                hit.collider.gameObject.GetComponent<npc>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)] * 20;
                            }
                        }


                    }
                }





            }
            if (PlayerPrefs.GetInt("gunr1", -1) == 5 || PlayerPrefs.GetInt("gunr1", -1) == 7)
            {
                if (PlayerPrefs.GetInt("gunr1", -1) == 7 && Input.GetKeyDown(KeyCode.Mouse0))
                {
                    for (int i = 0; i < GameObject.FindObjectsOfType<SpriteRenderer>().Length; i++)
                    {
                        GameObject.FindObjectsOfType<SpriteRenderer>()[i].material.shader = Resources.Load<Shader>("NewImageEffectShader");
                    }
                    for (int i = 0; i < GameObject.FindObjectsOfType<TilemapRenderer>().Length; i++)
                    {
                        GameObject.FindObjectsOfType<TilemapRenderer>()[i].material.shader = Resources.Load<Shader>("NewImageEffectShader");
                    }
                }
                if (PlayerPrefs.GetInt("gunr1", -1) == 7 && Input.GetKeyUp(KeyCode.Mouse0))
                {
                    for (int i = 0; i < GameObject.FindObjectsOfType<SpriteRenderer>().Length; i++)
                    {
                        GameObject.FindObjectsOfType<SpriteRenderer>()[i].material.shader = Resources.Load<Shader>("NewImageEffectShader 1");
                    }
                    for (int i = 0; i < GameObject.FindObjectsOfType<TilemapRenderer>().Length; i++)
                    {
                        GameObject.FindObjectsOfType<TilemapRenderer>()[i].material.shader = Resources.Load<Shader>("NewImageEffectShader 1");
                    }
                }

                for (int i=0;i<10&& PlayerPrefs.GetInt("gunr1", -1) == 7;i++)
                {


                    if (Input.GetKey(KeyCode.Mouse0))
                    {
                        RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                        if (hit.collider != null)
                        {
                            if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                            {
                                if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                {
                                    hit.collider.gameObject.GetComponent<zombie>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)];
                                }
                            }
                            if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                            {
                                if (hit.collider.gameObject.GetComponent<npc>() != null)
                                {
                                    hit.collider.gameObject.GetComponent<npc>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)];
                                }
                            }


                        }
                    }
                }
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                    if (hit.collider != null)
                    {
                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                        {
                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                            {
                                hit.collider.gameObject.GetComponent<zombie>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)];
                            }
                        }
                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                        {
                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                            {
                                hit.collider.gameObject.GetComponent<npc>().hp -= guns33.IDdamage[PlayerPrefs.GetInt("gunr1", 0)];
                            }
                        }


                    }
                }





            }
                if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                if (hit.collider != null)
                {
                    if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 200)
                    {
                        if (hit.collider.gameObject.GetComponent<zombie>() != null)
                        {
                            hit.collider.gameObject.GetComponent<zombie>().hp -= 20;
                        }
                    }
                    if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 200)
                    {
                        if (hit.collider.gameObject.GetComponent<npc>() != null)
                        {
                            hit.collider.gameObject.GetComponent<npc>().hp -= 20;
                        }
                    }


                }
            }

        }
        if (type == 2)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               
                RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                if (hit.collider != null)
                {
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<zombie>() != null)
                        {
                            hit.collider.gameObject.GetComponent<zombie>().hp -= 8;
                        }
                    }
                    if (Vector3.Distance(hit.collider.transform.position, gameObject.transform.position) < 400)
                    {
                        if (hit.collider.gameObject.GetComponent<npc>() != null)
                        {
                            hit.collider.gameObject.GetComponent<npc>().hp -= 8;
                        }
                    }


                }
            }
            if (s1 != null)
            {
                if (PlayerPrefs.GetInt("gunr3", -1) > -1 )
                {
                    if (s1.patrons[PlayerPrefs.GetInt("gunr3", -1)] >= 1)
                    {
                        if (File.Exists(@"DELTAFATE/" + "reynor" + @"/inventory.un"))
                        {
                            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "henry" + @"/inventory.un"));



                        }


                        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
                        {
                            if (reynorguns.IDcountdamage[PlayerPrefs.GetInt("gunr3", -1)] < 2)
                            {



                                if (Input.GetKeyDown(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr3", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "henry" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }
                            }





                        }
                        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
                        {
                            if (reynorguns.IDlessdamade[PlayerPrefs.GetInt("gunr3", -1)] > 2)
                            {



                                if (Input.GetKeyDown(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr3", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "reynor" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 60)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 60)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }
                            }





                        }
                        if (PlayerPrefs.GetInt("gunr3", -1) != -1)
                        {
                            if (reynorguns.IDcountdamage[PlayerPrefs.GetInt("gunr3", -1)] > 1)
                            {


                                if (Input.GetKey(KeyCode.Mouse0))
                                {
                                    s1.patrons[PlayerPrefs.GetInt("gunr3", -1)]--;
                                    File.WriteAllText(@"DELTAFATE /" + "reynor" + @"/inventory.un", JsonUtility.ToJson(s1));
                                    RaycastHit2D hit = Physics2D.Linecast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + Vector2.up * 19.47f, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y) + Vector2.up * 19.47f, LayerMask.GetMask("enemy"));
                                    if (hit.collider != null)
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<zombie>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<zombie>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, gameObject.transform.position) < 400)
                                        {
                                            if (hit.collider.gameObject.GetComponent<npc>() != null)
                                            {
                                                hit.collider.gameObject.GetComponent<npc>().hp -= reynorguns.IDdamage[PlayerPrefs.GetInt("gunr", 0)];
                                            }
                                        }


                                    }
                                }


                            }


                        }



                    }
                }
            }

        }


    }
       
    public static void p2save(Player1 player, string patch, save2 ssave)
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }







        ssave.level = player.level;
        ssave.v3[SceneManager.GetActiveScene().buildIndex] = player.transform.position;
        ssave.enter[SceneManager.GetActiveScene().buildIndex] = true;
        ssave.idscene = SceneManager.GetActiveScene().buildIndex;
        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/reynor");
        if (PlayerPrefs.GetInt("delete", 0) != 1)
        {


            File.WriteAllText(patch, JsonUtility.ToJson(ssave));

        }
        else
        {
            PlayerPrefs.SetInt("delete", 0);
        }
    }
    public static void pAsave(PlayerAnime player, string patch, string tech, save ssave)
    {
        teamsave ts = new teamsave();
        character c = new character();
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].gameObject == GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject)
            {
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry)
                {
                    c.curent = "henry";
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].isreynor)
                {
                    c.curent = "reynor";
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issarux)
                {
                    c.curent = "sarux";
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji)
                {
                    c.curent = "siji";
                }
            }
        }
        Directory.CreateDirectory("DELTAFATE/var");
        File.WriteAllText("DELTAFATE/var/curretchar.string",c.curent);
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
        {


            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry)
            {
                ts.team.Add("henry");
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji)
            {
                ts.team.Add("siji");
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].isreynor)
            {
                ts.team.Add("reynor");
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issarux)
            {
                ts.team.Add("sarux");
            }

        }
        Directory.CreateDirectory(Path.GetDirectoryName("DELTAFATE/var/team.json"));
        File.WriteAllText("DELTAFATE/var/team.json", JsonUtility.ToJson(ts));
        player.scenevi = Mathf.FloorToInt(SceneManager.GetActiveScene().buildIndex / 150);
        if (File.Exists(patch + tech + "/position" + player.scenevi + ".un"))
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));
        battlesave bs = new battlesave();
        bs.idscene[0] = SceneManager.GetActiveScene().buildIndex;
        bs.pos = player.transform.position;
        bs.isdead = false;
        bs.level = player.level;
        //deltacontrols.getcontrols.s12[3]
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






        if (player.level == 0)
        {


            ssave.level = player.level;
        }
        if (player.hp == 0)
        {
            ssave.hp = player.hp;
        }
        ssave.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] = player.transform.position;
        ssave.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] = true;
        ssave.idscene = SceneManager.GetActiveScene().buildIndex;
        Vector5 n = new Vector5();
        n.h = 43;
        ssave.v5 = v5json.v5tostring(n);
        Directory.CreateDirectory(patch);
        if (PlayerPrefs.GetInt("delete", 0) != 1)
        {

            Directory.CreateDirectory(patch + tech);

            File.WriteAllText(patch + tech + "/position" + player.scenevi + ".un", JsonUtility.ToJson(ssave));

        }
        else if (PlayerPrefs.GetInt("delete", 0) == 1)
        {
            PlayerPrefs.SetInt("delete", 0);
        }

        File.WriteAllText(patch + tech + "/bposition.un", JsonUtility.ToJson(bs));
        File.WriteAllText("DELTAFATE/position.un", JsonUtility.ToJson(bs));


    }
    public static void p3save(player3d player, string patch, string tech, save ssave)
    {
        
        
        player.scenevi = Mathf.FloorToInt(SceneManager.GetActiveScene().buildIndex / 150);
        if (File.Exists(patch + tech + "/position" + player.scenevi + ".un"))
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));
        battlesave bs = new battlesave();
        bs.idscene[0] = SceneManager.GetActiveScene().buildIndex;
        bs.pos = player.transform.position;
        bs.isdead = false;
        bs.level = player.level;
        //deltacontrols.getcontrols.s12[3]
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

        if (player.level == 0)
        {


            ssave.level = player.level;
        }




        ssave.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] = player.transform.position;
        ssave.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] = true;
        ssave.idscene = SceneManager.GetActiveScene().buildIndex;
        Vector5 n = new Vector5();
        n.h = 43;
        ssave.v5 = v5json.v5tostring(n);
        Directory.CreateDirectory(patch);
        if (PlayerPrefs.GetInt("delete", 0) != 1)
        {

            Directory.CreateDirectory(patch + tech);

            File.WriteAllText(patch + tech + "/position" + player.scenevi + ".un", JsonUtility.ToJson(ssave));

        }
        else if (PlayerPrefs.GetInt("delete", 0) == 1)
        {
            PlayerPrefs.SetInt("delete", 0);
        }

        File.WriteAllText(patch + tech + "/bposition.un", JsonUtility.ToJson(bs));
        File.WriteAllText("DELTAFATE/position.un", JsonUtility.ToJson(bs));


    }
    public static void pAload(PlayerAnime player, string patch, string tech)
    {
        battlesave bs = new battlesave();
        teamsave ts = new teamsave();
        
        int sr = 0;
        int sr2 = 0;
        int sr21 = 0;
        int sr22 = 0;
        int sr23 = 0;
        if (File.Exists("DELTAFATE/var/team.json") && GameObject.FindObjectsOfType<PlayerAnime>()[0] == player)
        {


            ts = JsonUtility.FromJson<teamsave>(File.ReadAllText("DELTAFATE/var/team.json"));

            for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length; i++)
            {


                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry)
                {
                    sr = 1; sr2 += 1;
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji)
                {
                    sr = 4; sr21 += 1;
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].isreynor)
                {
                    sr = 3; sr22 += 1;
                }
                if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issarux)
                {
                    sr = 2; sr23 += 1;
                }

            }
            if (sr == 1)
            {
                for (int x = 0; x < ts.team.Count && sr21 == 0 && sr22 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }

                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 2)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr22 == 0 && sr21 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 3)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr21 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 4)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr22 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }


        }
        for (int i = 0; i < GameObject.FindObjectsOfType<PlayerAnime>().Length && File.Exists("DELTAFATE/var/curretchar.string"); i++)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issiji && File.ReadAllText("DELTAFATE/var/curretchar.string") == "siji")
            {
                PlayerPrefs.GetInt("idcharactaer", i);
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].issarux && File.ReadAllText("DELTAFATE/var/curretchar.string") == "sarux")
            {
                PlayerPrefs.GetInt("idcharactaer", i);
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].isreynor && File.ReadAllText("DELTAFATE/var/curretchar.string") == "reynor")
            {
                PlayerPrefs.GetInt("idcharactaer", i);
            }
            if (GameObject.FindObjectsOfType<PlayerAnime>()[i].ishenry && File.ReadAllText("DELTAFATE/var/curretchar.string") == "henry")
            {
                PlayerPrefs.GetInt("idcharactaer", i);
            }
        }
        player.scenevi = Mathf.FloorToInt(SceneManager.GetActiveScene().buildIndex / 150);
        if (File.Exists(patch + tech + "/position" + player.scenevi + ".un") && PlayerPrefs.GetInt("loadstart", 0) != 1)
        {

            save ssave = new save();
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));

            player.hp = ssave.hp;
            if (File.Exists("DELTAFATE/position.un"))
            {

                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText("DELTAFATE/position.un"));

                if (!bs.isdead)
                {
                    if (ssave.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] == true)
                    {


                        player.transform.position = ssave.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150];
                    }


                }

            }

        }
        else if (PlayerPrefs.GetInt("loadstart", 0) == 1)
        {
            save ssave = new save();
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));
            saveload ssave2 = new saveload();
            ssave2 = JsonUtility.FromJson<saveload>(File.ReadAllText("DELTAFATE/unauticna/position" + player.scenevi + ".un"));
            if (ssave2.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] == true)
            {


                player.transform.position = ssave2.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150];
                player.level = ssave2.level; player.hp = ssave2.hp;
                ssave.enter = ssave2.enter;
                ssave.idscene = ssave2.idscene;
                ssave.hp = ssave2.hp;
                ssave.v3 = ssave2.v3;
                ssave.level = ssave2.level;

            }
            PlayerPrefs.SetInt("loadstart", 0);
        }
        if (File.Exists(patch + tech + "/bposition.un"))
        {


            bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(patch + tech + "/bposition.un"));
            player.level = bs.level;
        }


    }
    public static void p3load(player3d player, string patch, string tech)
    {
        battlesave bs = new battlesave();
        
       


         
        player.scenevi = Mathf.FloorToInt(SceneManager.GetActiveScene().buildIndex / 150);
        if (File.Exists(patch + tech + "/position" + player.scenevi + ".un") && PlayerPrefs.GetInt("loadstart", 0) != 1)
        {

            save ssave = new save();
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));

          
            if (File.Exists("DELTAFATE/position.un"))
            {

                bs = JsonUtility.FromJson<battlesave>(File.ReadAllText("DELTAFATE/position.un"));

                if (!bs.isdead)
                {
                    if (ssave.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] == true)
                    {


                        player.transform.position = ssave.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150];
                    }


                }

            }

        }
        else if (PlayerPrefs.GetInt("loadstart", 0) == 1)
        {
            save ssave = new save();
            ssave = JsonUtility.FromJson<save>(File.ReadAllText(patch + tech + "/position" + player.scenevi + ".un"));
            saveload ssave2 = new saveload();
            ssave2 = JsonUtility.FromJson<saveload>(File.ReadAllText("DELTAFATE/unauticna/position" + player.scenevi + ".un"));
            if (ssave2.enter[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150] == true)
            {


                player.transform.position = ssave2.v3[SceneManager.GetActiveScene().buildIndex - player.scenevi * 150];
                
                ssave.enter = ssave2.enter;
                ssave.idscene = ssave2.idscene;
                ssave.hp = ssave2.hp;
                ssave.v3 = ssave2.v3;
                ssave.level = ssave2.level;

            }
            PlayerPrefs.SetInt("loadstart", 0);
        }
        if (File.Exists(patch + tech + "/bposition.un"))
        {


            bs = JsonUtility.FromJson<battlesave>(File.ReadAllText(patch + tech + "/bposition.un"));
       
        }


    }
    public static void inst(Player23 player)
    {
        teamsave ts = new teamsave();
        int sr = 0;
        int sr2 = 0;
        int sr21 = 0;
        int sr22 = 0;
        int sr23 = 0;
        if (File.Exists("DELTAFATE/var/team.json") && GameObject.FindObjectsOfType<Player23>()[0] == player)
        {


            ts = JsonUtility.FromJson<teamsave>(File.ReadAllText("DELTAFATE/var/team.json"));

            for (int i = 0; i < GameObject.FindObjectsOfType<Player23>().Length; i++)
            {


                if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "henry")
                {
                    sr = 1; sr2 += 1;
                }
                if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "siji")
                {
                    sr = 4; sr21 += 1;
                }
                if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "reynor")
                {
                    sr = 3; sr22 += 1;
                }
                if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "sarux")
                {
                    sr = 2; sr23 += 1;
                }

            }
            if (sr == 1)
            {
                for (int x = 0; x < ts.team.Count && sr21 == 0 && sr22 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }

                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 2)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr22 == 0 && sr21 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 3)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr21 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "siji" && player.siji != null)
                    {
                        Instantiate(player.siji, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }
            if (sr == 4)
            {
                for (int x = 0; x < ts.team.Count && sr2 == 0 && sr22 == 0 && sr23 == 0; x++)
                {


                    if (ts.team[x] == "henry" && player.henry != null)
                    {
                        Instantiate(player.henry, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "reynor" && player.reynor != null)
                    {
                        Instantiate(player.reynor, player.transform.position, Quaternion.identity);
                    }
                    if (ts.team[x] == "sarux" && player.sarux != null)
                    {
                        Instantiate(player.sarux, player.transform.position, Quaternion.identity);
                    }
                }
            }


        }
    }
    public static void setteamplayer23(Player23 player) {
        teamsave ts = new teamsave();
        for (int i = 0; i < GameObject.FindObjectsOfType<Player23>().Length; i++)
        {


            if (GameObject.FindObjectsOfType<Player23>()[i].name1 =="henry")
            {
                ts.team.Add("henry");
            }
            if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "siji")
            {
                ts.team.Add("siji");
            }
            if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "reynor")
            {
                ts.team.Add("reynor");
            }
            if (GameObject.FindObjectsOfType<Player23>()[i].name1 == "sarux")
            {
                ts.team.Add("sarux");
            }

        }
        Directory.CreateDirectory(Path.GetDirectoryName("DELTAFATE/var/team.json"));
    }
    public static void pAmove(PlayerAnime player)
    {
        player.isMove = false;
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].path.v4.Count >= 99)
        {
            if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != player.gameObject)
            {
                if (Vector3.Distance(GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject.transform.position, player.gameObject.transform.position) > 40)
                {

                    player.isMove = true;

                    player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
                    
                }
            }
        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject == player.gameObject)
        {
            
            if (Input.GetKey(KeyCode.Mouse1))
            {
                if (player.cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x - player.dist >= player.transform.position.x)
                {

                    player.velosity += new Vector2(player.i / player.size, 0);
                    player.isMove = true;
                    player.rotation = 1;
                    player.Move(player.rigidbody2, player.velosity, player.isMove);
                    player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
                }
                if (player.cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x + player.dist <= player.transform.position.x)
                {
                    player.velosity += new Vector2(-player.i / player.size, 0);
                    player.isMove = true;
                    player.rotation = 3;
                    player.Move(player.rigidbody2, player.velosity, player.isMove);
                    player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
                }
                if (player.cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y - player.dist >= player.transform.position.y)
                {
                    player.velosity += new Vector2(0,player.i / player.size);
                    player.isMove = true;
                    player.rotation = 0;
                    player.Move(player.rigidbody2, player.velosity, player.isMove);
                    player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
                }
                if (player.cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y + player.dist <= player.transform.position.y)
                {
                    player.velosity += new Vector2(0,-player.i / player.size);
                    player.isMove = true;
                    player.rotation = 2;
                    player.Move(player.rigidbody2, player.velosity, player.isMove);
                    player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
                }
            }
            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(0,player.i / player.size);
                player.isMove = true;
                player.rotation = 0;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // d
            if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(player.i / player.size, 0);
                player.isMove = true;
                player.rotation = 1;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // s
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(0,-player.i / player.size);
                player.isMove = true;
                player.rotation = 2;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // a
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(-player.i / player.size, 0);
                player.isMove = true;
                player.rotation = 3;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // sa
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(-player.i / player.size, -player.i / player.size);
                player.isMove = true;
                player.rotation = 4;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // sd
            if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(player.i / player.size, -player.i / player.size);
                player.isMove = true;
                player.rotation = 5;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // wa
            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(-player.i / player.size, player.i / player.size);
                player.isMove = true;
                player.rotation = 6;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // wd
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A))
            {
                player.velosity = new Vector2(player.i / player.size, player.i / player.size);
                player.isMove = true;
                player.rotation = 7;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // none

        }
        if (GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject != player.gameObject)
        {

            if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(0,player.i / player.size);
                player.isMove = true;
                player.rotation = 0;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // d
            if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(player.i / player.size, 0);
                player.isMove = true;
                player.rotation = 1;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // s
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(0,-player.i / player.size);
                player.isMove = true;
                player.rotation = 2;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // a
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(-player.i / player.size, 0);
                player.isMove = true;
                player.rotation = 3;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // sa
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(-player.i / player.size, -player.i / player.size);
                player.isMove = true;
                player.rotation = 4;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // sd
            if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(player.i / player.size, -player.i / player.size);
                player.isMove = true;
                player.rotation = 5;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // wa
            if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(-player.i / player.size, player.i / player.size);
                player.isMove = true;
                player.rotation = 6;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // wd
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                player.velosity = new Vector2(player.i / player.size, player.i / player.size);
                player.isMove = true;
                player.rotation = 7;
                player.Move(player.rigidbody2, player.velosity, player.isMove);
                player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);
            }
            // none

        }
        player.AnimationMove(player.spriteRenderer, player.rotation, player.isMove, player.time, player.time2);

    }
    
}
