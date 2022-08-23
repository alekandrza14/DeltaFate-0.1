using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse9 : MonoBehaviour
{
    public bool vc; 
    public bool vc3;
    public Vector2 vc2;
    public Vector2 vc21;
    public int dist;
    public int type = 1;
    public int forse;
    private void Start()
    {
        
        vc21 = new Vector2(transform.position.x, transform.position.y);
    }
    
    void Update()
    {
        forse += 4;
        if (type == 1)
        {

            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, 0) + new Vector2(GameObject.FindWithTag("Target").transform.up.x, GameObject.FindWithTag("Target").transform.up.y) * forse);
            
        }
        if (type == 0)
        {


            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, 0) - new Vector2(GameObject.FindWithTag("Target").transform.up.x, GameObject.FindWithTag("Target").transform.up.y) * forse);
        }


    }
}
