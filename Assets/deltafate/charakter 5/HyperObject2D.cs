using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperObject2D : MonoBehaviour
{
    // Start is called before the first frame update
    public float scaleW;
    Vector3 Pos;
    public Vector3 Pos2;
    Vector3 EPos;
    Vector3 Es;
    bool ed;
    void Start()
    {
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
        transform.localScale = HT(Camera.main, transform);
        transform.position = HT2(Camera.main, transform);
    }
    public static void startrender(Transform transform, HyperObject2D s)
    {
        Vector3 Pos1 = Vector3.zero;
        Vector3 s1 = Vector3.one;

        if (s.ed)
        {
            Pos1 = s.EPos;
            s1 = s.Es;
            transform.localScale = s1;
            transform.position = Pos1;
            s.ed = false;
        }
        Pos1 = transform.position;
        s1 = transform.localScale;
        s.EPos = Pos1;
        s.Es = s1;
        s.Pos = s.EPos;
        s.ed = true;
        
        transform.localScale = s.HT(Camera.main, transform);
        transform.position = s.HT2(Camera.main, transform);
    }
    public static void stoprender(Transform transform, HyperObject2D s)
    {
        Vector3 Pos1 = Vector3.zero;
        Vector3 s1 = Vector3.zero;
        if (s.ed)
        {
            Pos1 = s.EPos;
            s1 = s.Es;
            transform.localScale = s1;
            transform.position = Pos1;
            s.ed = false;
        }
        s.Pos = transform.position;
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
        x = c.transform.position.x / 2 - Pos.x / 2 + Pos2.x + Pos.x + Pos2.x;
        y = c.transform.position.y / 2 - Pos.y / 2 + Pos2.x + Pos.y + Pos2.y;
        z = c.transform.position.z / 2 - Pos.z / 2 + Pos2.x + Pos.z + Pos2.z;
        return new Vector3(x,y,z);
    }
}
