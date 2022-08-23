using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Vector5
{

    public double x, y, z, w, h;

};
public class v5json
{
    
    public double[] v5es = new double[5];
    public static string v5tostring(Vector5 v5s)
    {
        v5json b5 = new v5json();
        string s = "";
        b5.v5es[0] = v5s.x;
        b5.v5es[1] = v5s.y;
        b5.v5es[2] = v5s.z;
        b5.v5es[3] = v5s.w;
        b5.v5es[4] = v5s.h;
        s += JsonUtility.ToJson(b5);
        return s;
    }
    public static Vector5 stringtov5(string v5s)
    {
        v5json b5 = new v5json();
        Vector5 s = new Vector5();
        b5 = JsonUtility.FromJson<v5json>(v5s);
        s.x = b5.v5es[0];
        s.y = b5.v5es[1];
        s.z = b5.v5es[2];
        s.w = b5.v5es[3];
        s.h = b5.v5es[4];


        return s;

    }
}
public class gran1 : MonoBehaviour
{
    public float scale; 
    public float scalew;
   public bool catz;
    public int type;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }
    public bool iscol(bool catz)
    {
        bool col = false;
        for (int i = 0; i < GameObject.FindObjectsOfType<Collider2D>().Length && !catz; i++)
        {
            if (gameObject.transform.position.y - GameObject.FindObjectsOfType<Collider2D>()[i].offset.y -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y + scale / 2 >= 0 && gameObject.transform.position.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].offset.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.x + scalew / 2 <= scalew * 2 &&
                gameObject.transform.position.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].offset.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.x + scalew / 2 >= -scalew)
            {

                if (type == 0)
                    GameObject.FindObjectsOfType<Collider2D>()[i].transform.position += Vector3.up + new Vector3(0, gameObject.transform.position.y -
                       GameObject.FindObjectsOfType<Collider2D>()[i].offset.y - GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y + scale / 2, 0);
                if (type >= 1)
                GameObject.FindObjectsOfType<Collider2D>()[i].transform.position += Vector3.up + new Vector3(0, gameObject.transform.position.y -
                   GameObject.FindObjectsOfType<Collider2D>()[i].offset.y - GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y + scale / 2 + type, 0);



                col = true;

            }
        }
        for (int i = 0; i < GameObject.FindObjectsOfType<Collider2D>().Length && catz; i++)
        {
            if (gameObject.transform.position.y - GameObject.FindObjectsOfType<Collider2D>()[i].offset.y -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y - scale / 2 <= 0 && gameObject.transform.position.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].offset.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.x + scalew / 2 <= scalew * 2 &&
                gameObject.transform.position.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].offset.x -
                GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.x + scalew / 2 >= -scalew)
            {
                if (type == 0)
                    GameObject.FindObjectsOfType<Collider2D>()[i].transform.position += Vector3.down + new Vector3(0, gameObject.transform.position.y +
                   GameObject.FindObjectsOfType<Collider2D>()[i].offset.y - GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y - scale / 2, 0);

                if (type >= 1)
                    GameObject.FindObjectsOfType<Collider2D>()[i].transform.position += Vector3.down + new Vector3(0, gameObject.transform.position.y +
                   GameObject.FindObjectsOfType<Collider2D>()[i].offset.y - GameObject.FindObjectsOfType<Collider2D>()[i].gameObject.transform.position.y - scale / 2 - type, 0);




                col = true;
            }
        }
        return col;
    }

        // Update is called once per frame
    void Update()
    {
        iscol(catz);


       


    }
}
