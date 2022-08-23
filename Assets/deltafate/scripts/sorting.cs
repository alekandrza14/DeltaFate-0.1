using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorting : MonoBehaviour
{
    public int sortingOrderBase;
    Renderer render;
    Sprite sp;
    SpriteRenderer sr;
    float order;
    void Start()
    {
        if (GetComponent<Renderer>())
        {
            render = GetComponent<Renderer>();
        }
        if (GetComponent<SpriteRenderer>())
        {
            sr = GetComponent<SpriteRenderer>();
            order = sr.sprite.pivot.y;
        }
        if (GetComponent<ActiveBehaiver>())
        {
            render.sortingOrder = (int)(sortingOrderBase - transform.position.y + order / 100);
        }
        else
        {
            render.sortingOrder = (int)(sortingOrderBase - transform.position.y + order / 100);
            Destroy(this);
        }
    }

    
    void Update()
    {
        if (GetComponent<ActiveBehaiver>())
        {
            render.sortingOrder = (int)(sortingOrderBase - transform.position.y + order / 100);
        }
    }
}
