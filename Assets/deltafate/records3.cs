using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class records3 : MonoBehaviour
{
    public int size = 1;
    public Texture2D s;
    public string namespriteui = "rescord";
    public sps sp = new sps();
    public int index;

    
    // Start is called before the first frame update
    void Start()
    {
        
        if (File.Exists(@"res/" + namespriteui + ".png"))
        {
            if (File.Exists(@"res/" + namespriteui + "_" + index + ".sprite"))
            {
                sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/" + namespriteui+"_" + index + ".sprite"));

                WWW www = new WWW("file:///res/" + namespriteui + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                if (sp.rect == new Rect(0,0,0,0))
                {


                    var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, size);
                    gameObject.GetComponent<Image>().sprite = s6;
                }
                else
                {
                    var s6 = Sprite.Create(s, sp.rect, sp.privot, size);
                    gameObject.GetComponent<Image>().sprite = s6;
                }
                if (Directory.Exists("debug"))
                {
                    File.WriteAllText("debug/log1" + namespriteui + ".un", JsonUtility.ToJson(sp));
                }





            }
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

