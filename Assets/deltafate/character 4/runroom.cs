using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class brokengeometry
{
    public List<Vector4> v31 = new List<Vector4>();
    public bool geometry;
}
public class runroom : MonoBehaviour
{
    public static List<Vector4> v3 = new List<Vector4>();
    public List<Vector4> v31 = new List<Vector4>();
    public static Texture2D[] s = new Texture2D[5]; public Texture2D[] s1;
    public GameObject pp;
    public GameObject exit;
    public int room;
    void Start()
    {
        v3 = JsonUtility.FromJson<brokengeometry>(File.ReadAllText("res/chapter_4/room"+room+"/geometry.json")).v31;
        WWW www = new WWW("file:///" + "res/chapter_4/room" + room + "/none.png");
        WWW www1 = new WWW("file:///" + "res/chapter_4/room" + room + "/none1.png");
        WWW www2 = new WWW("file:///" + "res/chapter_4/room" + room + "/none2.png");
        WWW www3 = new WWW("file:///" + "res/chapter_4/room" + room + "/none3.png");
        
        s[0] = www.texture; s[1] = www1.texture; s[2] = www2.texture; s[3] = www3.texture;
        s[0].filterMode = FilterMode.Point; s[1].filterMode = FilterMode.Point; s[2].filterMode = FilterMode.Point; s[3].filterMode = FilterMode.Point;
        for (int i = 0; i < v3.Count; i++)
        {
            if (Mathf.FloorToInt(v3[i].w) == 0)
            {
                var g = new GameObject("none" + 0);
                g.AddComponent<SpriteRenderer>().sprite = Sprite.Create(s[0], new Rect(0, 0, 100, 100), Vector2.one / 2, 1);
                g.transform.position = new Vector3(v3[i].x * 20, v3[i].y * 20, v3[i].z * 20);


                g.AddComponent<BoxCollider2D>().isTrigger = false;
            }
            if (Mathf.FloorToInt(v3[i].w) == 1)
            {
                var g = new GameObject("none" + 1);
                g.AddComponent<SpriteRenderer>().sprite = Sprite.Create(s[1], new Rect(0, 0, 100, 100), Vector2.one / 2, 1);
                g.transform.position = new Vector3(v3[i].x * 20, v3[i].y * 20, v3[i].z * 20);


                g.AddComponent<BoxCollider2D>().isTrigger = false;
            }
            if (Mathf.FloorToInt(v3[i].w) == 2)
            {
                var g = new GameObject("none" + 2);
                g.AddComponent<SpriteRenderer>().sprite = Sprite.Create(s[2], new Rect(0, 0, 100, 100), Vector2.one / 2, 1);
                g.transform.position = new Vector3(v3[i].x * 20, v3[i].y * 20, v3[i].z * 20);
                g.AddComponent<npc>().hp = 200;
                g.layer = LayerMask.NameToLayer("enemy");
                g.AddComponent<BoxCollider2D>().isTrigger = false;
            }
            if (Mathf.FloorToInt(v3[i].w) == 3)
            {
                Instantiate(exit, new Vector3(v3[i].x * 20, v3[i].y * 20, v3[i].z * 20), Quaternion.identity);
            }
            if (Mathf.FloorToInt(v3[i].w) == 100)
            {
                Instantiate(pp, new Vector3(v3[i].x * 20, v3[i].y * 20, v3[i].z*20), Quaternion.identity);
            }
        }
    }
}
