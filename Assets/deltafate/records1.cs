using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class records1 : MonoBehaviour
{
    
    public Texture2D s;
    public string namesprite = "rescord";
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"res/characters/" + namesprite + "s23" + ".png") && PlayerPrefs.GetInt("gender", 0) == 0)
        {


            WWW www = new WWW("file:///res/characters/" + namesprite +"s23"+ ".png");
            s = www.texture;
            s.filterMode = FilterMode.Point;
            var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), new Vector2(0.5f,0), 1);

            gameObject.GetComponent<SpriteRenderer>().sprite = s6;



        }
        if (File.Exists(@"res/characters/WOMAN/" + namesprite + "Xs" + ".png") && PlayerPrefs.GetInt("gender", 0) == 1)
        {


            WWW www = new WWW("file:///res/characters/WOMAN/" + namesprite +"Xs"+ ".png");
            s = www.texture;
            s.filterMode = FilterMode.Point;
            var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), new Vector2(0.5f, 0), 1);

            gameObject.GetComponent<SpriteRenderer>().sprite = s6;



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
