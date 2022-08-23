using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mat : MonoBehaviour
{
    public float s;

    public float day = 1;

    public float dayend = 20;
    public float tic;
    [Range(0, 24)]
    public float day1 = 1;
    public Material m;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        tic += 1 * 60 * Time.deltaTime;
        
            day += 1 / day1 * Time.fixedDeltaTime * Random.Range(1,3);



        m.SetColor("s",new Color(day / 50, day / 50, day / 50));
            if (day > dayend)
            {

                day = 0;

            }

        
        


    }
}
