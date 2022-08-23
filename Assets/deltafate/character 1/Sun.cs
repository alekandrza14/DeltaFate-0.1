using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float s;
    
    public float day = 1;
    
    public float dayend = 20;
    public float tic;
    [Range(0, 24)]
    public float day1 = 1;
    public GameObject i;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        tic += 1 * 60 * Time.deltaTime;
        if (tic >= 30)
        {
            day += 1 / day1 * Time.fixedDeltaTime;



            i.gameObject.transform.rotation = Quaternion.Euler(day * 5, day / 2, day);
            if (day > dayend)
            {

                day = -dayend;

            }

        }
        else
        {
            i.gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
        }


    }
}
