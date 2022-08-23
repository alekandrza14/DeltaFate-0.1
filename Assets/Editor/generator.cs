using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(rtt2))]
public class generator : Editor
{
    private rtt2 gm;
    public Texture2D s2;
    public Texture2D s3;
    public int list;
    
    public void OnEnable()
    {
        gm = (rtt2)target;
        
    }
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("dalishe") && list == 0)
        {
            list++;
        }
        if (GUILayout.Button("out") && list == 1)
        {
            list--;
        }
        if (list == 0)
        {


            if (GUILayout.Button("generate rand points"))
            {
                for (int x = -10000; x < 10000; x += Random.Range(0, 2000))
                {
                    for (int y = -10000; y < 10000; y += Random.Range(0, 2000))
                    {
                        var i = new GameObject("t" + x.ToString() + y.ToString());
                        i.transform.position = new Vector3(x, y, 0);
                    }
                }
            }
            if (GUILayout.Button("generate room"))
            {
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -10; x < 10; x += 1)
                {
                    for (int y = -10; y < 10; y += 1)
                    {
                        if (x < -9 || x >= 9 || y < -9 || y >= 9)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                            i.AddComponent<SpriteRenderer>().sprite = s;
                            i.AddComponent<BoxCollider2D>();
                        }
                    }
                }
            }
            if (GUILayout.Button("generate room small"))
            {
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -3; x < 3; x += 1)
                {
                    for (int y = -3; y < 3; y += 1)
                    {
                        if (x < -2 || x >= 2 || y < -2 || y >= 2)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                            i.AddComponent<SpriteRenderer>().sprite = s;
                            i.AddComponent<BoxCollider2D>();
                        }
                    }
                }
            }
            if (GUILayout.Button("generate room normal"))
            {
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -5; x < 5; x += 1)
                {
                    for (int y = -5; y < 5; y += 1)
                    {
                        if (x < -4 || x >= 4 || y < -4 || y >= 4)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                            i.AddComponent<SpriteRenderer>().sprite = s;
                            i.AddComponent<BoxCollider2D>();
                        }
                    }
                }
            }
            if (GUILayout.Button("generate room sin"))
            {
                int ss = 0;
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -5; x < 5; x += 1)
                {

                    for (int y = -5; y < 5; y += 1)
                    {


                        if (x < -4 || x >= 4 || y < -4 || y >= 4)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x + y * 100, y * 100 + gm.gameObject.transform.position.y, 0);
                            i.AddComponent<SpriteRenderer>().sprite = s;
                            i.AddComponent<BoxCollider2D>();
                        }
                    }

                }
            }



        }
        if (list == 1)
        {

            if (GUILayout.Button("generate room as fool"))
            {
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one/2, 1);
                Sprite s33 = Sprite.Create(s3, new Rect(0, 0, s3.width, s3.height), Vector3.one /2, 1);
                for (int x = -3; x < 3; x += 1)
                {
                    for (int y = -3; y < 3; y += 1)
                    {
                        if (x < -2 || x >= 2 || y < -2 || y >= 2)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                            


                                i.AddComponent<SpriteRenderer>().sprite = s;
                                i.AddComponent<BoxCollider2D>();
                            
                        }
                        else
                        {
                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);



                            i.AddComponent<SpriteRenderer>().sprite = s33;
                            i.GetComponent<SpriteRenderer>().sortingOrder = -1;
                        }
                    }
                }
            }
            if (GUILayout.Button("generate room cos"))
            {
                int ss = 0;
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -5; x < 5; x += 1)
                {

                    for (int y = -5; y < 5; y += 1)
                    {


                        if (x < -4 || x >= 4 || y < -4 || y >= 4)
                        {


                            var i = new GameObject("t" + x.ToString() + y.ToString());
                            i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x - y * 100, y * 100 + gm.gameObject.transform.position.y, 0);
                            i.AddComponent<SpriteRenderer>().sprite = s;
                            i.AddComponent<BoxCollider2D>();
                        }
                    }

                }
            }
            if (GUILayout.Button("random wall"))
            {
                int ss = 0;
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -2; x < 2; x += 1)
                {

                    for (int y = -2; y < 2; y += 1)
                    {





                        var i = new GameObject("t" + x.ToString() + y.ToString());
                        i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                        i.AddComponent<SpriteRenderer>().sprite = s;
                        i.AddComponent<ExampleClass>().xOrg = 444;
                        i.GetComponent<ExampleClass>().yOrg = 444;
                        i.GetComponent<ExampleClass>().pixWidth = 100;
                        i.GetComponent<ExampleClass>().pixHeight = 100;
                        i.GetComponent<ExampleClass>().scale = 40;

                        i.AddComponent<BoxCollider2D>();

                    }

                }
            }
            if (GUILayout.Button("random foor"))
            {
                int ss = 0;
                Sprite s = Sprite.Create(s2, new Rect(0, 0, s2.width, s2.height), Vector3.one / 2, 1);
                for (int x = -2; x < 2; x += 1)
                {

                    for (int y = -2; y < 2; y += 1)
                    {





                        var i = new GameObject("t" + x.ToString() + y.ToString());
                        i.transform.position = new Vector3(x * 100 + gm.gameObject.transform.position.x, y * 100 + gm.gameObject.transform.position.y, 0);
                        i.AddComponent<SpriteRenderer>().sprite = s;
                        i.AddComponent<ExampleClass>().xOrg = 444;
                        i.GetComponent<ExampleClass>().yOrg = 444;
                        i.GetComponent<ExampleClass>().pixWidth = 100;
                        i.GetComponent<ExampleClass>().pixHeight = 100;
                        i.GetComponent<ExampleClass>().scale = 40;

                        

                    }

                }
            }

        }

    }
}
