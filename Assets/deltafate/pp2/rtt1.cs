using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class rtt1 : MonoBehaviour
{
    public int id;
    public items s1 = new items();
    public int r1 = 1;
    public bool spawner;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (r1 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        }
    }

    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            if (r1 == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;

            }
            if (r1 == 1)
            {


                for (int i = 0; i < GameObject.FindObjectsOfType<rtt1>().Length; i++)
                {
                    if (GameObject.FindObjectsOfType<rtt1>()[i].gameObject == gameObject)
                    {
                        if (File.Exists(@"DELTAFATE/" + "siji" + @"/inventory.un"))
                        {
                            s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + "siji" + @"/inventory.un"));

                            s1.itemid.Add(id);
                            File.WriteAllText(@"DELTAFATE/" + "siji" + @"/inventory.un", JsonUtility.ToJson(s1));
                        }
                        if (!spawner)
                        {


                            PlayerPrefs.SetInt("gun1", i);
                        }
                        
                    }
                }

            }
        }
    }
}
