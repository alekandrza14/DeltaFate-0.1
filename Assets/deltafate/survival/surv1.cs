using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class surv1 : MonoBehaviour
{
    public GameObject[] zombie;
    public float tic;
    public float time;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tic += 1 * Time.fixedDeltaTime;
        
        if (tic >= time)
        {


            
                        Instantiate(zombie[Random.Range(0,zombie.Length)], transform.position, Quaternion.identity);
                 
            tic = 0;
            
        }
    }
}

