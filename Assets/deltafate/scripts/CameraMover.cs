using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform character;
    public float camdist;
    public float offset;
    public Vector3 pos;
    public ActiveBehaiver posledovatel;
    void Update()
    {
        float dist = Vector3.Distance(transform.position, character.position);
        if (dist > camdist)
        {
            Vector3 t = transform.position - character.position;
            t /= 300 / dist;
            transform.position -= t;
            transform.position = new Vector3(transform.position.x, transform.position.y, -offset);

        }
        if (dist < camdist)
        {
            Vector3 t = transform.position - character.position;
            t /= 1000 / dist;
            transform.position -= t;
            transform.position = new Vector3(transform.position.x, transform.position.y, -offset);

        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (posledovatel)
            {
                if (pos.x != 0 && pos.y != 0)
                {
                    posledovatel.traget = pos;



                    pos = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
                    pos = new Vector3(pos.x, pos.y, 0);
                    pos = new Vector3(0, 0, 0);
                }
                else
                {
                    


                        pos = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
                        pos = new Vector3(pos.x, pos.y, 0);
                    
                }
                
            }
            else
            {
                pos = new Vector3(0, 0, 0);
            }
        }
    }
}

