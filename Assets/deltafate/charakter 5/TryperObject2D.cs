using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryperObject2D : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 hpos; public Vector3 hwpos; public float hzpos; public float hypos; public float hxpos;
    public float scaleW;
    Vector3 Pos;  float wscale = 1; float wpos = 0f; Vector3 mwpos = new Vector3(111111,11111,1457834);
    public Vector3 Pos2; public Vector3 WPos;
    Vector3 EPos;
    Vector3 Es;
    public AnimationCurve s;
    scrollbareditWpos Wposplayer;
    bool ed;
    void Start()
    {
        Wposplayer = GameObject.FindObjectOfType<scrollbareditWpos>();
        Vector3 Pos1 = Vector3.zero;
        Vector3 s1 = Vector3.zero;
        if (ed)
        {
            Pos1 = EPos;
            s1 = Es;
            transform.localScale = s1;
            transform.position = Pos1;
            ed = false;
        }
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (mwpos.x != s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale))
        {

            transform.localScale = HT(Camera.main, transform);

            float w = 0;
            w = wscale + wpos;
            w /= 2;
            float wh = 0;
            wh = wscale + wpos;


            transform.localScale -= new Vector3(s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale), s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale), s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale));transform.localScale -= new Vector3(s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale), s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale), s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale));

        }
        else
        {
            transform.localScale = HT(Camera.main, transform);
            transform.localScale -= new Vector3(mwpos.x, mwpos.x, mwpos.x);

        }
        mwpos.x = s.Evaluate(-Wposplayer.Wpos.value + wpos + wscale);


        transform.position = HT2(Camera.main, transform);
    }
    
    public Vector3 HT(Camera c, Transform g)
    {
        Vector3 v3 = new Vector3(1,1,1);
        if (Vector3.Distance(c.transform.position, g.position) / 400 / scaleW > 1)
        {
            v3= new Vector3(Vector3.Distance(c.transform.position, g.position) / 400 / scaleW, Vector3.Distance(c.transform.position, g.position) / 400 / scaleW, Vector3.Distance(c.transform.position, g.position) / 400 / scaleW);
        }
        return v3;
    }
    public Vector3 HT2(Camera c, Transform g)
    {
        float x = 0;
        float y = 0;
        float z = 0;
        x = c.transform.position.x / 2 - Pos.x / 2 + Pos2.x + Pos.x + Pos2.x + WPos.x * c.gameObject.GetComponent<TryperPlayer>().hpos;
        y = c.transform.position.y / 2 - Pos.y / 2 + Pos2.x + Pos.y + Pos2.y + WPos.y * c.gameObject.GetComponent<TryperPlayer>().hpos;
        z = c.transform.position.z / 2 - Pos.z / 2 + Pos2.x + Pos.z + Pos2.z + WPos.z * c.gameObject.GetComponent<TryperPlayer>().hpos;
      
        if (hwpos.x != c.gameObject.GetComponent<TryperPlayer>().hwpos / 2)
        {
            x *= c.gameObject.GetComponent<TryperPlayer>().hwpos / 2 ;
            y *= c.gameObject.GetComponent<TryperPlayer>().hwpos / 2;
            z *= c.gameObject.GetComponent<TryperPlayer>().hwpos / 2;
        }
        else 
        {
            x *= hwpos.x;
            y *= hwpos.x;
            z *= hwpos.x;
        }


        hwpos.x = c.gameObject.GetComponent<TryperPlayer>().hwpos / 2;

        if (hwpos.z != c.gameObject.GetComponent<TryperPlayer>().hzpos / 2)
        {
            
            z *= c.gameObject.GetComponent<TryperPlayer>().hzpos / 2;
        }
        else
        {
            
            z *= hwpos.z;
        }
        hwpos.z = c.gameObject.GetComponent<TryperPlayer>().hwpos / 2;

        if (hwpos.y != c.gameObject.GetComponent<TryperPlayer>().hypos / 2)
        {

            z *= c.gameObject.GetComponent<TryperPlayer>().hypos / 2;
        }
        else
        {

            y *= hwpos.y;
        }
        hwpos.y = c.gameObject.GetComponent<TryperPlayer>().hypos / 2;

        if (hpos.x != c.gameObject.GetComponent<TryperPlayer>().hxpos / 2)
        {

            x *= c.gameObject.GetComponent<TryperPlayer>().hxpos / 2;
        }
        else
        {

            x *= hpos.x;
        }
        hpos.x = c.gameObject.GetComponent<TryperPlayer>().hxpos / 2;

        return new Vector3(x,y,z);
    }
}
