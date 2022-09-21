using System;
using System.Collections.Generic;
using UnityEngine;


public class autodelete : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject);
    }
    
    public void plussdel()
    {
        Destroy(gameObject);
    }
}

