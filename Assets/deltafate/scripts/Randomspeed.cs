using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspeed : MonoBehaviour
{
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        anim.speed = Random.Range(0.5f,2);
    }
}
