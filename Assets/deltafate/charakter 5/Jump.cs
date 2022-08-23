using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Sprite sp;
    public Sprite sp2;
    public float anim;
    public float start;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        start = sp.pivot.y;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyImmediate(sp2);
        Vector2 v2 = new Vector2(0, start);
        v2+= new Vector2(0, -anim);
       sp2 =  Sprite.Create(sp.texture,sp.rect,v2 /100,1);
        sr.sprite = sp2;

    }
}
