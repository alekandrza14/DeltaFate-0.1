using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class records2 : MonoBehaviour
{
    public int size = 1;
    public Texture2D s;
    public string namesprite = "rescord";
    public sps sp = new sps();
    public int index;

    
    // Start is called before the first frame update
    void Start()
    {

        if (File.Exists(@"res/" + namesprite + ".png"))
        {
            if (File.Exists(@"res/" + namesprite + "_" + index + ".sprite"))
            {
                sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/" + namesprite + "_" + index + ".sprite"));

                WWW www = new WWW("file:///res/" + namesprite + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                if (sp.rect == new Rect(0, 0, 0, 0))
                {


                    var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, size);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                else
                {
                    var s6 = Sprite.Create(s, sp.rect, sp.privot, size);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                if (Directory.Exists("debug"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName("debug/log1" + namesprite + ".un"));
                    File.WriteAllText("debug/log1" + namesprite + ".un", JsonUtility.ToJson(sp));
                }





            }
        }
        if (File.Exists(@"res/Hero soul/" + namesprite + ".png"))
        {
            if (File.Exists(@"res/Hero soul/" + namesprite + "_" + index + ".sprite"))
            {
                sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/Hero soul/" + namesprite + "_" + index + ".sprite"));

                WWW www = new WWW("file:///res/Hero soul/" + namesprite + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                if (sp.rect == new Rect(0, 0, 0, 0))
                {


                    var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, size);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                else
                {
                    var s6 = Sprite.Create(s, sp.rect, sp.privot, size);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                if (Directory.Exists("debug"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName("debug/Hero soul/log1" + namesprite + ".un"));
                    File.WriteAllText("debug/Hero soul/log1" + namesprite + ".un", JsonUtility.ToJson(sp));
                }





            }
        }
        if (namesprite == "sans_ee")
        {
            DirectoryInfo n = new DirectoryInfo("res/sans_ee");
            if (File.Exists(n.GetFiles()[Random.Range(0,n.GetFiles().Length)].FullName))
            {
                if (File.Exists(@"res/sans_ee_" + index + ".sprite"))
                {
                    sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/sans_ee_" + index + ".sprite"));

                    WWW www = new WWW("file://"+n.GetFiles()[Random.Range(0,n.GetFiles().Length)].FullName);
                    s = www.texture;
                    s.filterMode = FilterMode.Point;
                    if (sp.rect == new Rect(0, 0, 0, 0))
                    {


                        var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, size);
                        gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                    }
                    else
                    {
                        var s6 = Sprite.Create(s, sp.rect, sp.privot, size);
                        gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                    }
                    if (Directory.Exists("debug"))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName("debug/sans_ee/log1" + namesprite + ".un"));
                        File.WriteAllText("debug/sans_ee/log1" + namesprite + ".un", JsonUtility.ToJson(sp));
                    }





                }
            }
        }
    }
    public static void spritest(string namesprite, int index, GameObject gameObject)
    {
        Texture2D s;
        if (File.Exists(@"res/" + namesprite + ".png"))
        {
            if (File.Exists(@"res/" + namesprite + "_" + index + ".sprite"))
            {
                sps sp = new sps();
                sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/" + namesprite + "_" + index + ".sprite"));

                WWW www = new WWW("file:///res/" + namesprite + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                if (sp.rect == new Rect(0, 0, 0, 0))
                {


                    var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, 1);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                else
                {
                    var s6 = Sprite.Create(s, sp.rect, sp.privot, 1);
                    gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                }
                if (Directory.Exists("debug"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName("debug/log1" + namesprite + ".un"));
                    File.WriteAllText("debug/log1" + namesprite + ".un", JsonUtility.ToJson(sp));
                }
            }
        }
    }
    public static Texture2D spritest3(string namesprite, int index)
    {
        Texture2D s = new Texture2D(1,1);
        if (File.Exists(@"res/" + namesprite + ".png"))
        {
            
               
                

                WWW www = new WWW("file:///res/" + namesprite + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                
                    
                    
                
                if (Directory.Exists("debug"))
                {
                    
                    
                }
            
        }
        return s;
    }
    public static Sprite spritest2(string namesprite, int index, Sprite sprite)
    {
        Texture2D s;
        if (File.Exists(@"res/" + namesprite + ".png"))
        {
            if (File.Exists(@"res/" + namesprite + "_" + index + ".sprite"))
            {
                sps sp = new sps();
                sp = JsonUtility.FromJson<sps>(File.ReadAllText(@"res/" + namesprite + "_" + index + ".sprite"));

                WWW www = new WWW("file:///res/" + namesprite + ".png");
                s = www.texture;
                s.filterMode = FilterMode.Point;
                if (sp.rect == new Rect(0, 0, 0, 0))
                {


                    var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), sp.privot, 1);
                    sprite = s6;
                    
                }
                else
                {
                    var s6 = Sprite.Create(s, sp.rect, sp.privot, 1);
                    sprite = s6;
                    
                }
                if (Directory.Exists("debug"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName("debug/log1" + namesprite + ".un"));
                    File.WriteAllText("debug/log1" + namesprite + ".un", JsonUtility.ToJson(sp));
                    
                }
                
            }
            
        }
        return sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[SerializeField]
public class sps
{
    public Vector2 privot;
    public Rect rect;
}
