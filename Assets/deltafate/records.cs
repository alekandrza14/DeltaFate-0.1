using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class records : MonoBehaviour
{
    
    public Texture2D s;
    public string namesprite = "rescord";
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"res/" + namesprite + ".png"))
        {


            WWW www = new WWW("file:///res/"+namesprite+".png");
            s = www.texture;
            s.filterMode = FilterMode.Point;
            var s6 = Sprite.Create(s, new Rect(0, 0, s.width, s.height), Vector2.one /2,1);
            
            gameObject.GetComponent<SpriteRenderer>().sprite = s6;
                
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
