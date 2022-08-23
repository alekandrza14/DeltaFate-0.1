using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBehaiver : MonoBehaviour
{
    public long hp = 100;
    public long xp;
    public long level;
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
