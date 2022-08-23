using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim222 : MonoBehaviour
{
    public ParticleSystem t;
    private void Start()
    {
        var t1 = t.main;
        t1.loop = false;
    }
}
