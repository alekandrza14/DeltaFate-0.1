using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pprs : MonoBehaviour
{
    public void deathpprs()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        for (int i =0;i< GameObject.FindObjectsOfType<pprs>().Length;i++)
        {
            if (i != 0)
            {
                GameObject.FindObjectsOfType<pprs>()[i].deathpprs();
            }
        } 
    }
}
