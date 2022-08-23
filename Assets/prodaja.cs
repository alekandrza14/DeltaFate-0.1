using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class prodaja : MonoBehaviour
{
    public battlesave bs = new battlesave(); public items iv;
    public string heroObject; 
    public string heroObjectname;
    public int level;
    public int produkt;
    public string produktname;
    public bigdigital.infint count = new bigdigital.infint();
    public int inf; public int mininf;
    public Text st;

    // Start is called before the first frame update
    void Start()
    {
        count.digital2 = inf;
        count.digital1 = mininf;
        if (File.Exists("DELTAFATE/var/cur" + produktname + ".ii"))
        {


            count = bigdigital.infint.stringtov5(File.ReadAllText("DELTAFATE/var/cur" + produktname + ".ii"));

        }
    }

        // Update is called once per frame
    public void traid()
    {
        if (File.Exists("DELTAFATE/"+heroObjectname+"/bposition.un") && File.Exists("DELTAFATE/" + heroObject + "/inventory.un"))
        {


            bs = JsonUtility.FromJson<battlesave>(File.ReadAllText("DELTAFATE/" + heroObjectname + "/bposition.un"));
            iv = JsonUtility.FromJson<items>(File.ReadAllText("DELTAFATE/" + heroObject + "/inventory.un"));
            if (bs.level >= level)
            {
                iv.itemid.Add(produkt);
                bs.level -= level;
                PlayerPrefs.SetInt("upxp",-level);
                count = bigdigital.infint.addint(count,-1);
            }
            File.WriteAllText("DELTAFATE/var/cur"+produktname+".ii", bigdigital.infint.v5tostring(count));
            File.WriteAllText("DELTAFATE/" + heroObject + "/inventory.un", JsonUtility.ToJson(iv));
        }
    }
    private void Update()
    {
        st.text = bigdigital.infint.getstring(count);
    }
}
