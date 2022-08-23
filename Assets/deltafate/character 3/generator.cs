using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class generator : MonoBehaviour
{

    void Start()
    {
        if (File.Exists(@"res/PLATE.png"))
        {


            WWW www = new WWW("file:///res/PLATE.png");
            WWW www2 = new WWW("file:///res/PLATE2.png");


            for (int x = -10; x < 10; x++)
            {
                for (int y = -10; y < 10; y++)
                {
                    

                    if (x >= -9 && x <= 8 && y >= -9 && y <= 8)
                    {


                        var g = new GameObject("p");
                        g.AddComponent<SpriteRenderer>();

                        g.GetComponent<SpriteRenderer>().sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), Vector3.zero);
                        g.GetComponent<SpriteRenderer>().sprite.texture.filterMode = FilterMode.Point;
                        g.GetComponent<SpriteRenderer>().sortingOrder = -1;
                        g.transform.localScale = Vector3.one * 100;
                        g.transform.position = new Vector3(x * 100, y * 100, 0);
                    }
                    if (x < -9 || x >= 9 || y < -9 || y >= 9)
                    {


                        var g = new GameObject("p");
                        g.AddComponent<SpriteRenderer>();

                        g.GetComponent<SpriteRenderer>().sprite = Sprite.Create(www2.texture, new Rect(0, 0, www2.texture.width, www2.texture.height), Vector3.zero);
                        g.GetComponent<SpriteRenderer>().sprite.texture.filterMode = FilterMode.Point;
                        g.GetComponent<SpriteRenderer>().sortingOrder = -1;
                        g.transform.localScale = Vector3.one * 100;
                        g.transform.position = new Vector3(x * 100, y * 100, 0);
                        g.AddComponent<BoxCollider2D>();
                    }
                }
            }

        }
    }

}
