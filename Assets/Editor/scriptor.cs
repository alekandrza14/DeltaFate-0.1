using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

using UnityEngine.Tilemaps;

[CustomEditor(typeof(Anim28))]
public class inventory : Editor
{
    public int[] item;
    public string[] itemname;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("additem"))
        {
            Anim28 inv = (Anim28)target;
            item = inv.id;
            itemname = inv.idname;
            inv.id = new int[inv.id.Length + 1];
            inv.idname = new string[inv.idname.Length + 1];
            for (int i = 0; i < inv.id.Length; i++)
            {
                if (i < item.Length)
                {


                    inv.id[i] = item[i];
                }
                else
                {
                    inv.id[i] = i;
                }
            }
            for (int i = 0; i < inv.idname.Length; i++)
            {
                if (i < itemname.Length)
                {


                    inv.idname[i] = itemname[i];
                }
                else
                {
                    inv.idname[i] = "предмет" + i;
                }
            }

        }
    }
}


[CustomEditor(typeof(Transform))]
public class spripter : Editor
{

        
        
        
    public override void OnInspectorGUI()
    {


        base.OnInspectorGUI();
        if (GUILayout.Button("addscriptEC"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<ExampleClass>();
            g.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;
        }
        if (GUILayout.Button("addscriptexit"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<button6>().id = SceneManager.GetActiveScene().buildIndex - 1;
            g.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;

        }
        if (GUILayout.Button("addscriptenter"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<button6>().id = SceneManager.GetActiveScene().buildIndex + 1;
            g.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;

        }
        if (GUILayout.Button("addscriptrtt2"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<rtt2>();


        }
        if (GUILayout.Button("addgrid"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<Grid>();
            g.gameObject.GetComponent<Grid>().cellSize = new Vector3(91.7f, 118.4f, 0);
            var g1 = new GameObject();

            g1.AddComponent<Tilemap>().tileAnchor = Vector3.zero;
            g1.AddComponent<TilemapRenderer>();


        }
        if (GUILayout.Button("addrescords"))
        {
            Transform g = (Transform)target;
            g.gameObject.AddComponent<records2>();
            


        }

    }
}

public class playerspawners : EditorWindow
{
    public static int startspeed;
    public static byte s;
    public static float Spos;
    public static bool eneableui = true;
    public static bool hyperrenderer = false;

    [MenuItem("GameObject/2D Object/setpayler")]
    public static void ShowWindow()
    {
        GetWindow<playerspawners>("Example");
    }
    private void OnInspectorUpdate()
    {
        if (hyperrenderer)
        {
            for (int i = 0; i < GameObject.FindObjectsOfType<HyperObject2D>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<HyperObject2D>().Length != 0)
                {




                    HyperObject2D.startrender(GameObject.FindObjectsOfType<HyperObject2D>()[i].transform, GameObject.FindObjectsOfType<HyperObject2D>()[i]);

                }

            }

        }
        
    }

    private void OnGUI()
    {
        if (File.Exists("res/speed"))
        {


            startspeed = int.Parse(File.ReadAllText("res/speed"));
        }
        
        startspeed = EditorGUILayout.IntField("speed", startspeed);
        del.delux = byte.Parse(EditorGUILayout.TextArea(del.delux.ToString()));
        del.delux2 = byte.Parse(EditorGUILayout.TextArea(del.delux2.ToString()));

        if (EditorGUILayout.LinkButton("byteset"))
        {
            File.WriteAllBytes("license.t", new byte[20]
            {1,1,1,1,1,1,1,1,1,del.delux,del.delux2,1,1,1,1,1,1,1,1,1
            }); File.WriteAllBytes("res/list", new byte[20]
             {1,1,1,1,1,1,1,1,byte.Parse(Random.Range(0,254).ToString()),del.delux,byte.Parse(Random.Range(0,254).ToString()),del.delux2,byte.Parse(Random.Range(0,254).ToString()),1,1,1,1,1,1,1
             });

        }
        if (EditorGUILayout.LinkButton("HyperRender"))
        {
            for (int i = 0; i < GameObject.FindObjectsOfType<HyperObject2D>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<HyperObject2D>().Length != 0)
                {




                    HyperObject2D.startrender(GameObject.FindObjectsOfType<HyperObject2D>()[i].transform, GameObject.FindObjectsOfType<HyperObject2D>()[i]);

                }

            }

        }
        if (EditorGUILayout.LinkButton("rescordsall"))
        {
            for (int i = 0; i < GameObject.FindObjectsOfType<SpriteRenderer>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<SpriteRenderer>().Length != 0)
                {
                    if (GameObject.FindObjectsOfType<SpriteRenderer>()[i].GetComponent<records2>() == null)
                    {




                        GameObject.FindObjectsOfType<SpriteRenderer>()[i].gameObject.AddComponent<records2>();
                        GameObject.FindObjectsOfType<SpriteRenderer>()[i].gameObject.GetComponent<records2>().namesprite = "";

                    }
                }

            }

        }
        if (EditorGUILayout.LinkButton("HyperRenderstop"))
        {
            hyperrenderer = false;
            for (int i = 0; i < GameObject.FindObjectsOfType<HyperObject2D>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<HyperObject2D>().Length != 0)
                {




                    HyperObject2D.stoprender(GameObject.FindObjectsOfType<HyperObject2D>()[i].transform, GameObject.FindObjectsOfType<HyperObject2D>()[i]);

                }

            }

        }

        if (EditorGUILayout.LinkButton("light"))
        {
            for (int i = 0; i < GameObject.FindObjectsOfType<TilemapRenderer>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<Tilemap>().Length != 0)
                {
                    if (!FindObjectsOfType<Tilemap>()[i].gameObject.GetComponent<datatic2>())
                    {



                        GameObject.FindObjectsOfType<Tilemap>()[i].gameObject.AddComponent<datatic2>();
                    }
                }

            }
            for (int i = 0; i < GameObject.FindObjectsOfType<HardLight2D>().Length; i++)
            {
                if (GameObject.FindObjectsOfType<HardLight2D>().Length != 0)
                {
                    if (!FindObjectsOfType<HardLight2D>()[i].gameObject.GetComponent<datatic2>())
                    {



                        GameObject.FindObjectsOfType<HardLight2D>()[i].gameObject.AddComponent<datatic2>();
                    }
                }

            }
        }

        Spos = EditorGUILayout.FloatField("Wpos", Spos);
        
        for (int i = 0; i < GameObject.FindObjectsOfType<Object2DShadow>().Length; i++)
        {
                if (GameObject.FindObjectsOfType<Object2DShadow>().Length != 0)
                {




                    GameObject.FindObjectsOfType<Object2DShadow>()[i].chek_w(Spos);
                    
                }

        }

        eneableui = EditorGUILayout.Toggle("ui", eneableui);
        hyperrenderer = EditorGUILayout.Toggle("hyperrenderer", hyperrenderer);
        for (int i = 0; i < GameObject.FindObjectsOfType<Image>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<Image>().Length != 0)
            {




                GameObject.FindObjectsOfType<Image>()[i].enabled = eneableui;

            }

        }
        for (int i = 0; i < GameObject.FindObjectsOfType<Scrollbar>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<Scrollbar>().Length != 0)
            {




                GameObject.FindObjectsOfType<Scrollbar>()[i].enabled = eneableui;

            }

        }
        for (int i = 0; i < GameObject.FindObjectsOfType<RawImage>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<RawImage>().Length != 0)
            {




                GameObject.FindObjectsOfType<RawImage>()[i].enabled = eneableui;

            }

        }
        
        for (int i = 0; i < GameObject.FindObjectsOfType<Text>().Length; i++)
        {
            if (GameObject.FindObjectsOfType<Text>().Length != 0)
            {




                GameObject.FindObjectsOfType<Text>()[i].enabled = eneableui;

            }

        }
        
        File.WriteAllText("res/speed", startspeed.ToString());
    }
}
public class uispawn : EditorWindow
{
    public static string startspeed;
    public static byte s;
    [MenuItem("GameObject/UI/Example")]
    public static void ShowWindow()
    {
        GetWindow<uispawn>("Example");
    }
    private void OnGUI()
    {
        if (EditorGUILayout.LinkButton("dialog window spawn"))
        {
          Instantiate(Resources.Load<GameObject>("window/dialog"));
        }

    }
}
public class morze : EditorWindow
{
    public static string startspeed;
    public static byte s;
    [MenuItem("GameObject/2D Object/morze")]
    public static void ShowWindow()
    {
        GetWindow<morze>("Example");
    }

    private void OnGUI()
    {


        startspeed = EditorGUILayout.TextField("speed", startspeed);

        if (EditorGUILayout.LinkButton("а"))
        {

            startspeed += "*.";
        }

        if (EditorGUILayout.LinkButton("б"))
        {

            startspeed += ".***";
        }
        if (EditorGUILayout.LinkButton("в"))
        {

            startspeed += "*..";
        }
        if (EditorGUILayout.LinkButton("г"))
        {

            startspeed += "..*";
        }
        if (EditorGUILayout.LinkButton("д"))
        {

            startspeed += ".**";
        }
        if (EditorGUILayout.LinkButton("е"))
        {

            startspeed += "*";
        }
        if (EditorGUILayout.LinkButton("ж"))
        {

            startspeed += "***.";
        }
        if (EditorGUILayout.LinkButton("з"))
        {

            startspeed += "..**";
        }
        if (EditorGUILayout.LinkButton("и"))
        {

            startspeed += "**";
        }
        if (EditorGUILayout.LinkButton("й"))
        {

            startspeed += "*...";
        }
        if (EditorGUILayout.LinkButton("к"))
        {

            startspeed += ".*.";
        }
        if (EditorGUILayout.LinkButton("л"))
        {

            startspeed += "*.**";
        }
        if (EditorGUILayout.LinkButton("м"))
        {

            startspeed += "***.";
        }
        if (EditorGUILayout.LinkButton("н"))
        {

            startspeed += "..**";
        }
        if (EditorGUILayout.LinkButton("н"))
        {

            startspeed += "**";
        }
        if (EditorGUILayout.LinkButton("о"))
        {

            startspeed += "*...";
        }
        if (EditorGUILayout.LinkButton("п"))
        {

            startspeed += ".*.";
        }
        if (EditorGUILayout.LinkButton("р"))
        {

            startspeed += "*.**";
        }
        if (EditorGUILayout.LinkButton("с"))
        {

            startspeed += "***";
        }
        if (EditorGUILayout.LinkButton("т"))
        {

            startspeed += ".";
        }
        if (EditorGUILayout.LinkButton("у"))
        {

            startspeed += "**.";
        }
        if (EditorGUILayout.LinkButton("ф"))
        {

            startspeed += "**.*";
        }
        if (EditorGUILayout.LinkButton("х"))
        {

            startspeed += "****";
        }
        if (EditorGUILayout.LinkButton("ц"))
        {

            startspeed += ".*.*";
        }
        if (EditorGUILayout.LinkButton("ч"))
        {

            startspeed += "...*";
        }
        if (EditorGUILayout.LinkButton("ш"))
        {

            startspeed += "....";
        }
        if (EditorGUILayout.LinkButton("щ"))
        {

            startspeed += "..*.";
        }
        if (EditorGUILayout.LinkButton("ъ"))
        {

            startspeed += "*..*.";
        }
        if (EditorGUILayout.LinkButton("ы"))
        {

            startspeed += ".*..";
        }
        if (EditorGUILayout.LinkButton("ь"))
        {

            startspeed += ".**.";
        }
        if (EditorGUILayout.LinkButton("э"))
        {

            startspeed += "***.***";
        }
        if (EditorGUILayout.LinkButton("ю"))
        {

            startspeed += "**..";
        }
        if (EditorGUILayout.LinkButton("я"))
        {

            startspeed += "*.*.";
        }
        if (EditorGUILayout.LinkButton("└"))
        {

            startspeed += "└";
        }
        if (EditorGUILayout.LinkButton("┘"))
        {

            startspeed += "┘";
        }
        if (EditorGUILayout.LinkButton("┐"))
        {

            startspeed += "┐";
        }
        if (EditorGUILayout.LinkButton("┌"))
        {

            startspeed += "┌";
        }



    }
}
public class morze1 : EditorWindow
{
    public static string startspeed;
    public static byte s;
    [MenuItem("GameObject/2D Object/morze1")]
    public static void ShowWindow()
    {
        GetWindow<morze1>("Example");
    }

    private void OnGUI()
    {


        startspeed = EditorGUILayout.TextField("speed", startspeed);

        if (EditorGUILayout.LinkButton("♥"))
        {

            startspeed += "♥";
        }
        if (EditorGUILayout.LinkButton("█"))
        {

            startspeed += "█";
        }
        




    }
}




