using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class rtt3 : MonoBehaviour
{
    public int id;
    public items s1 = new items();
    public int r1 = 1;
    public string s44 = "henry";
    public int potrons = 40;
    public bool spawner;
    public bool privot;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
           
            
                
                            if (privot)
                            {
                s1 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + s44 + @"/inventory.un"));

                s1.itemid.Add(id);
                s1.patrons[id] += potrons;
                File.WriteAllText(@"DELTAFATE/" + s44 + @"/inventory.un", JsonUtility.ToJson(s1));
                Destroy(gameObject);
                                
                            }
                  

        }
    }
}
