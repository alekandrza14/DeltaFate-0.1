using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OnlyEditor : MonoBehaviour
{
    bool render;
#if !UNITY_EDITOR
    private void Awake()
    {
        if (GetComponent<Renderer>())
        {
            Renderer r = GetComponent<Renderer>();
            r.enabled = false;
        }
    }
#endif
#if UNITY_EDITOR
    private void Awake()
    {
        Debug.Log("Object : "+ gameObject.name+" - hide");
        if (GetComponent<Renderer>())
        {
            Renderer r = GetComponent<Renderer>();
            r.enabled = false;
        }
        
    }
    private void LateUpdate()
    {
        if (GetComponent<Renderer>())
        {
            Renderer r = GetComponent<Renderer>();
            TilemapRenderer r3;
            SpriteRenderer r2;
            if (GetComponent<SpriteRenderer>())
            {


                r2 = GetComponent<SpriteRenderer>();
                r2.enabled = render;
            }
            if (GetComponent<TilemapRenderer>())
            {
                r3 = GetComponent<TilemapRenderer>();
                r3.enabled = render;
            }
            r.enabled = render;
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            render = !render;
        }
    }
#endif
}
