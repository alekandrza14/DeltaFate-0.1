using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform character;
    public float camdist;
    public float offset;
    void Update()
    {
        float dist = Vector3.Distance(transform.position,character.position);
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
    }
}
