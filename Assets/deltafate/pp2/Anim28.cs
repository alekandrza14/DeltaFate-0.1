using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Anim28 : MonoBehaviour
{


    public Text txt3;
    public Text txt4;
    public Text txt5;
    public bool load1;
    public int[] id;
    public string[] idname;
    public string[] idnameenglish;
    public string[] idnameUnatcicha;
    public modefikatoritems mods = new modefikatoritems();
   
    public items s77 = new items();
    public string namey = "henry";
    public GameObject character;
    public int cur = 1;
    public int cur2;
    public Sprite[] icon; 
    public Image ic;
    public GameObject[] sound;
    public int beg = 5;
    public float tic;

    // Start is called before the first frame update
    private void Start()
    {
        cur = savevartous.usvar(@"DELTAFATE/var/cur.int",cur); cur2 = savevartous.usvar(@"DELTAFATE/var/cur2.int",cur2);
        if (File.Exists(@"DELTAFATE/" + namey + @"/inventory.un"))
        {
            s77 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + namey + @"/inventory.un"));



        }
        if (namey == "siji")
        {
            if (File.Exists(@"mods/item2.un"))
            {
                mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item2.un"));
                for (int x = 0; x < mods.itemname.Count; x++)
                {


                    idname[x] = mods.itemname[x];


                }
            }
        }
        if (namey == "henry")
        {

            if (File.Exists(@"mods/item.un"))
            {
                mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item.un"));
                for (int x = 0; x < mods.itemname.Count; x++)
                {


                    idname[x] = mods.itemname[x];


                }
            }
        }
        if (namey == "reynor")
        {

            if (File.Exists(@"mods/item3.un"))
            {
                mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item3.un"));
                for (int x = 0; x < mods.itemname.Count; x++)
                {


                    idname[x] = mods.itemname[x];


                }
            }
        }
        if (namey == "artifact")
        {

           character = GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject;
        }
        if (s77.itemid.Count < cur && s77.itemid.Count != 0 || s77.itemid.Count < cur2 && s77.itemid.Count != 0)
        {


            cur = s77.itemid.Count;
            cur2 = cur-1;
        }
        else if (s77.itemid.Count == 0)
        {
            cur = 1;
            cur2 = 0;
        }

    }

    void Update()
    {
        
        if (namey == "artifact")
        {

            character = GameObject.FindObjectsOfType<PlayerAnime>()[PlayerPrefs.GetInt("idcharactaer", 0)].gameObject;
        }
        if (PlayerPrefs.GetInt("ling", 0) == 1)
        {


            idname = idnameenglish;
        }
        if (PlayerPrefs.GetInt("ling", 0) == 2)
        {


            idname = idnameUnatcicha;
        }
        savevartous.setusvar(@"DELTAFATE/var/cur.int", false, cur);
        savevartous.setusvar(@"DELTAFATE/var/cur2.int", false, cur2);
        if (Input.GetKeyDown(KeyCode.X))
        {
            File.WriteAllText(@"mods/item2.un", JsonUtility.ToJson(mods));
            File.WriteAllText(@"mods/item3.un", JsonUtility.ToJson(mods));
            File.WriteAllText(@"mods/item.un", JsonUtility.ToJson(mods));

        }
        if (cur2 < s77.itemid.Count)
        {
            PlayerPrefs.SetInt("gunrset", cur2);

        }
        if (namey == "henry")
        {
            if (cur2 < s77.itemid.Count)
            {
                PlayerPrefs.SetInt("gunr", s77.itemid[cur2]);

            }
            else
            {
                
                PlayerPrefs.DeleteKey("gunr");
            }
        }
        if (namey == "reynor")
        {
            if (cur2 < s77.itemid.Count)
            {
                PlayerPrefs.SetInt("gunr3", s77.itemid[cur2]);

            }
            else
            {
                
                PlayerPrefs.DeleteKey("gunr3");
            }
        }
        if (namey == "siji")
        {
            if (cur2 < s77.itemid.Count)
            {
                PlayerPrefs.SetInt("gunr1", s77.itemid[cur2]);

            }
            else
            {
                
                PlayerPrefs.DeleteKey("gunr1");
            }
           
        }
        if (File.Exists(@"DELTAFATE/" + namey + @"/inventory.un"))
        {
            s77 = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + namey + @"/inventory.un"));
            


        }
        if (namey == "siji")
        {
            if (cur2 < s77.itemid.Count)
            {
                if (Input.GetKey(KeyCode.Mouse0) && sound[s77.itemid[cur2]] != null && s77.itemid[cur2] == 7)
                {
                    tic += 60 * Time.fixedDeltaTime;
                    if (guns33.idtic[s77.itemid[cur2]].x < tic)
                    {


                        Instantiate(sound[s77.itemid[cur2]], transform);
                        tic = 0;
                    }
                }
                if (Mathf.FloorToInt(guns33.IDeffect[s77.itemid[cur2]].x) != 0)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[1]))
                    {
                        modefikatoreffects effect = new modefikatoreffects();
                        if (File.Exists(@"DELTAFATE/mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

                        }
                        if (File.Exists(@"mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

                        }

                        if (guns33.IDeffect[s77.itemid[cur2]].x == 2)
                        {


                            effect.ideffect.Add("hill");
                            effect.power.Add(Mathf.FloorToInt(guns33.IDeffect[s77.itemid[cur2]].y));
                        }
                        if (guns33.IDeffect[s77.itemid[cur2]].x == 1)
                        {


                            effect.ideffect.Add("damage");
                            effect.power.Add(Mathf.FloorToInt(guns33.IDeffect[s77.itemid[cur2]].y));
                        }

                        s77.itemid.RemoveAt(cur2);
                        Directory.CreateDirectory(@"DELTAFATE/mods");
                        File.WriteAllText(@"DELTAFATE/mods/effect.un", JsonUtility.ToJson(effect));
                    }
                }
            }
        }
        while (s77.itemid.Count > beg)
        {
            s77.itemid.RemoveRange(beg, s77.itemid.Count - beg);
        }
        if (namey == "henry")
        {
            
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Alpha5) && Input.GetKeyDown(KeyCode.Alpha9) && Directory.Exists("debug"))
            {
                s77.itemid.Add(1); s77.itemid.Add(0); s77.itemid.Add(4); PlayerPrefs.SetString("text2", "кавбой");
                s77.patrons[1] += 1000; s77.patrons[0] += 2000; s77.patrons[4] += 0;
            }
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Alpha2) && Input.GetKeyDown(KeyCode.Alpha9) && Directory.Exists("debug"))
            {
                s77.itemid.Add(10); s77.itemid.Add(0); s77.itemid.Add(4); PlayerPrefs.SetString("text2", "штурмовик");
                s77.patrons[10] += 1000; s77.patrons[0] += 200; s77.patrons[4] += 0;
            }
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Alpha3) && Input.GetKeyDown(KeyCode.Alpha9) && Directory.Exists("debug"))
            {
                s77.itemid.Add(17); s77.itemid.Add(0); s77.itemid.Add(14); PlayerPrefs.SetString("text2", "убийца");
                s77.patrons[17] += 1000; s77.patrons[0] += 20000; s77.patrons[14] += 0;
            }
            if (cur2 < s77.itemid.Count)
            {

                if (Input.GetKey(KeyCode.Mouse0) && sound[s77.itemid[cur2]] != null && guns.IDcountdamage[s77.itemid[cur2]] > 1 && s77.patrons[s77.itemid[cur2]] > 1)
                {
                    tic += 60 * Time.fixedDeltaTime;
                    if (guns.idtic[s77.itemid[cur2]].x < tic)
                    {


                        Instantiate(sound[s77.itemid[cur2]], transform);
                        tic = 0;
                    }
                }
                
                if (Input.GetKeyDown(KeyCode.Mouse0) && sound[s77.itemid[cur2]] != null && guns.IDcountdamage[s77.itemid[cur2]] <= 1 && s77.patrons[s77.itemid[cur2]] > 1)
                {
                    Instantiate(sound[s77.itemid[cur2]], transform);
                }
                if (Mathf.FloorToInt(guns.ideffect[s77.itemid[cur2]].x) != 0)
                {
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[1]))
                    {
                        modefikatoreffects effect = new modefikatoreffects();
                        if (File.Exists(@"DELTAFATE/mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

                        }
                        if (File.Exists(@"mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

                        }
                        
                        if (guns.ideffect[s77.itemid[cur2]].x == 2)
                        {


                            effect.ideffect.Add("hill");
                            effect.power.Add(Mathf.FloorToInt(guns.ideffect[s77.itemid[cur2]].y));
                        }
                        if (guns.ideffect[s77.itemid[cur2]].x == 1)
                        {


                            effect.ideffect.Add("damage");
                            effect.power.Add(Mathf.FloorToInt(guns.ideffect[s77.itemid[cur2]].y));
                        }

                        s77.itemid.RemoveAt(cur2);
                        Directory.CreateDirectory(@"DELTAFATE/mods");
                        File.WriteAllText(@"DELTAFATE/mods/effect.un", JsonUtility.ToJson(effect));
                    }
                }

            }
        }
        if (namey == "artifact")
        {
            if (cur2 < s77.itemid.Count)
            {
                if (Mathf.FloorToInt(artif.ideffect[s77.itemid[cur2]].x) != 0)
                {
                    ic.sprite = icon[s77.itemid[cur2]];
                    if (artif.ideffect[s77.itemid[cur2]].x == 2)
                    {


                        ic.color = Color.gray;
                    }
                    if (artif.ideffect[s77.itemid[cur2]].x == 1)
                    {


                        ic.color = Color.red;
                    }
                    if (Input.GetKeyDown(deltacontrols.getcontrols.s12[1]))
                    {
                        modefikatoreffects effect = new modefikatoreffects();
                        if (File.Exists(@"DELTAFATE/mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"DELTAFATE/mods/effect.un"));

                        }
                        if (File.Exists(@"mods/effect.un"))
                        {
                            effect = JsonUtility.FromJson<modefikatoreffects>(File.ReadAllText(@"mods/effect.un"));

                        }
                        if (artif.ideffect[s77.itemid[cur2]].x == 3)
                        {


                            effect.ideffect.Add("speed");
                            effect.power.Add(Mathf.FloorToInt(artif.ideffect[s77.itemid[cur2]].y));
                        }
                        if (artif.ideffect[s77.itemid[cur2]].x == 2)
                        {


                            effect.ideffect.Add("hill");
                            effect.power.Add(Mathf.FloorToInt(artif.ideffect[s77.itemid[cur2]].y));
                        }
                        if (artif.ideffect[s77.itemid[cur2]].x == 1)
                        {


                            effect.ideffect.Add("damage");
                            effect.power.Add(Mathf.FloorToInt(artif.ideffect[s77.itemid[cur2]].y));
                        }

                        s77.itemid.RemoveAt(cur2);
                        Directory.CreateDirectory(@"DELTAFATE/mods");
                        File.WriteAllText(@"DELTAFATE/mods/effect.un", JsonUtility.ToJson(effect));
                    }
                }

            }
        }

        if (load1 == true)
        {

            txt4.text = "--";
            txt3.text = "--";
            txt5.text = "--";

            if (cur + 2 <= s77.itemid.Count)
            {
                txt4.color = Color.black;
            }
            if (cur + 1 <= s77.itemid.Count)
            {
                txt5.color = Color.black;
            }
            if (cur <= s77.itemid.Count)
            {
                txt3.color = Color.black;


            }
            if (cur + 2 > s77.itemid.Count)
            {
                txt4.color = Color.red;
            }
            if (cur + 1 > s77.itemid.Count)
            {
                txt5.color = Color.red;
            }
            if (cur > s77.itemid.Count)
            {
                txt3.color = Color.red;

            }

            if (cur2 == cur + 1)
            {
                txt4.color = Color.yellow;
            }
            if (cur2 == cur)
            {
                txt5.color = Color.yellow;
            }
            if (cur2 == cur - 1)
            {
                txt3.color = Color.yellow;

            }
            if (s77.itemid.Count != 0)
            {
                if (cur + 1 < s77.itemid.Count)
                {
                    txt4.text = "предмет" + s77.itemid[cur + 1].ToString();

                }

                if (cur < s77.itemid.Count)
                {
                    txt5.text = "предмет" + s77.itemid[cur].ToString();

                }
                if (cur > 0)
                {
                    txt3.text = "предмет" + s77.itemid[cur - 1].ToString();

                }
            }
            for (int i = 0; i < id.Length; i++)
            {

                if (s77.itemid.Count != 0)
                {

                    if (cur + 1 < s77.itemid.Count)
                    {
                        if (s77.itemid[cur + 1] == id[i])
                        {
                            txt4.text = idname[i];
                        }
                    }
                    if (cur < s77.itemid.Count)
                    {
                        if (s77.itemid[cur] == id[i])
                        {
                            txt5.text = idname[i];
                        }
                    }

                    if (cur >= 0)
                    {
                        if (s77.itemid[cur - 1] == id[i])
                        {
                            txt3.text = idname[i];

                        }
                    }
                }
            }





            if (cur < s77.itemid.Count - 2)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    cur++;
                    cur2++;
                }
            }
            
            if (cur >= 2)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    cur--;
                    cur2--;
                }

            }
            if (cur2 >= cur)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                    cur2--;
                }
            }
            if (cur2 <= cur)
            {
                if (Input.GetKeyDown(KeyCode.V))
                {
                    cur2++;

                }

            }
        }
        if (character)
        {

            if (character.GetComponent<PlayerAnime>().t2.enabled == true)
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    
                    s77.itemid.RemoveAt(cur2);


                    File.WriteAllText(@"DELTAFATE/" + namey + @"/inventory.un", JsonUtility.ToJson(s77));
                }
                if (Input.GetKey(deltacontrols.getcontrols.s12[4]))
                {

                    s77.itemid.Clear();
                }
            }
        }
        

        if (!character)
        {

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                
                s77.itemid.RemoveAt(cur2);


                File.WriteAllText(@"DELTAFATE/" + namey + @"/inventory.un", JsonUtility.ToJson(s77));
            }
            if (Input.GetKey(deltacontrols.getcontrols.s12[4]))
            {

                s77.itemid.Clear();
            }

        }
        


        
        Directory.CreateDirectory(@"DELTAFATE/" + namey);
        File.WriteAllText(@"DELTAFATE /" + namey + @"/inventory.un", JsonUtility.ToJson(s77));

        if (character.gameObject != null)
        {

            if (character.GetComponent<PlayerAnime>().t2.enabled == false)
            {
                txt4.color = new Color(0, 0, 0, 0);
                txt3.color = new Color(0, 0, 0, 0);
                txt5.color = new Color(0, 0, 0, 0);
            }
                
        }


    }

}
[SerializeField]
public class items
{
    public List<int> itemid = new List<int>();
    public int[] patrons = new int[25] 
    { 
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        1

    }
    ;
}
public class modefikatoritems
{
    public List<string> itemname = new List<string>();
    public List<int> itemdamage = new List<int>();
}
public class modefikatoreffects
{
    public List<string> ideffect = new List<string>();
    public List<int> power = new List<int>();
}






