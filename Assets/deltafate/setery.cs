using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setery : MonoBehaviour
{
    public Vector2 rand;
    public Texture2D s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition; 
        if (PlayerPrefs.GetInt("dif", 0) == 4)
        {
            rand.x = Random.Range(0, Screen.width);
            rand.y = Random.Range(0, Screen.height);
            Cursor.SetCursor(s,rand,CursorMode.Auto);
        }
    }
}
