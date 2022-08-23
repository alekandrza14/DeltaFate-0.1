using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class whilepath : MonoBehaviour
{
    public pathin path = new pathin();
    public bool ifwhilepath;
    public PlayerAnime p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {


            ifwhilepath = !ifwhilepath;
        }
        if (ifwhilepath)
        {


            path.v4.Add(new Vector4(p.gameObject.transform.position.x, p.gameObject.transform.position.y, p.gameObject.transform.position.z, p.rotation));
        }
        if (Input.GetKeyDown(KeyCode.P))
        {


            File.WriteAllText(@"debug/path.un",JsonUtility.ToJson(path));
        }
    }
    private void OnGUI()
    {
        if (ifwhilepath)
        {
            GUI.Button(new Rect(0, 0, Screen.width/20, Screen.height/20),"запись");
        }
    }
}
public class pathin
{
    public List<Vector4> v4 = new List<Vector4>();
}
