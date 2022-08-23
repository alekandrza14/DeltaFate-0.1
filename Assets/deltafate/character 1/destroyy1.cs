using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyy1 : MonoBehaviour
{
    public float tic;
    void Update()
    {
        tic += 1 * 20 * Time.deltaTime;
        if (tic > 500)
        {
            Destroy(gameObject);
            tic = 0;
        }
    }
}
