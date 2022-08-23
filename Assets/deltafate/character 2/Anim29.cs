using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Anim29 : MonoBehaviour
{


    public Text txt3;
    public Text txt4;
    public Text txt5;
    public bool load1;
    public int[] id;
    public string[] idname;
    public modefikatoritems mods = new modefikatoritems();

    public items s = new items();
    public string namey = "henry";
    public GameObject character;
    int cur = 1;
    public int cur2;

    // Start is called before the first frame update
    private void Start()
    {
        if (File.Exists(@"DELTAFATE/" + namey + @"/inventory.un"))
        {
            s = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + namey + @"/inventory.un"));



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

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            File.WriteAllText(@"mods/item2.un", JsonUtility.ToJson(mods));
            File.WriteAllText(@"mods/item.un", JsonUtility.ToJson(mods));
        }
        if (cur2 < s.itemid.Count)
        {
            PlayerPrefs.SetInt("gunr1", s.itemid[cur2]);

        }
        else
        {
            PlayerPrefs.DeleteKey("gunr1");
        }
        if (File.Exists(@"DELTAFATE/" + namey + @"/inventory.un"))
        {
            s = JsonUtility.FromJson<items>(File.ReadAllText(@"DELTAFATE/" + namey + @"/inventory.un"));



        }
        if (load1 == true)
        {

            txt4.text = "--";
            txt3.text = "--";
            txt5.text = "--";

            if (cur + 2 <= s.itemid.Count)
            {
                txt4.color = Color.black;
            }
            if (cur + 1 <= s.itemid.Count)
            {
                txt5.color = Color.black;
            }
            if (cur <= s.itemid.Count)
            {
                txt3.color = Color.black;


            }
            if (cur + 2 > s.itemid.Count)
            {
                txt4.color = Color.red;
            }
            if (cur + 1 > s.itemid.Count)
            {
                txt5.color = Color.red;
            }
            if (cur > s.itemid.Count)
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
            if (s.itemid.Count != 0)
            {
                if (cur + 1 < s.itemid.Count)
                {
                    txt4.text = "предмет" + s.itemid[cur + 1].ToString();

                }

                if (cur < s.itemid.Count)
                {
                    txt5.text = "предмет" + s.itemid[cur].ToString();

                }
                if (cur > 0)
                {
                    txt3.text = "предмет" + s.itemid[cur - 1].ToString();

                }
            }
            for (int i = 0; i < id.Length; i++)
            {

                if (s.itemid.Count != 0)
                {

                    if (cur + 1 < s.itemid.Count)
                    {
                        if (s.itemid[cur + 1] == id[i])
                        {
                            txt4.text = idname[i];
                        }
                    }
                    if (cur < s.itemid.Count)
                    {
                        if (s.itemid[cur] == id[i])
                        {
                            txt5.text = idname[i];
                        }
                    }

                    if (cur >= 0)
                    {
                        if (s.itemid[cur - 1] == id[i])
                        {
                            txt3.text = idname[i];

                        }
                    }
                }
            }





            if (cur < s.itemid.Count - 2)
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
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (s.itemid[cur2] == 1)
                {

                }
                s.itemid.RemoveAt(cur2);


                File.WriteAllText(@"DELTAFATE/" + namey + @"/inventory.un", JsonUtility.ToJson(s));
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {

                s.itemid.Clear();
            }
            if (s.itemid.Count > 5)
            {
                s.itemid.Remove(5);
            }

        }
        Directory.CreateDirectory(@"DELTAFATE/" + namey);
        File.WriteAllText(@"DELTAFATE /" + namey + @"/inventory.un", JsonUtility.ToJson(s));

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


    
    




