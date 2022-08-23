using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class surv : MonoBehaviour
{
    public GameObject[] zombie;
    public float tic;
    public float time;
    public float timemin;

    private void OnDestroy()
    {
        
            Directory.CreateDirectory("records");
        DirectoryInfo di = new DirectoryInfo("records");
        
        if (timemin >= 0.01f && di.GetFiles().Length < 100)
        {


            File.WriteAllText("records/" + "00" + di.GetFiles().Length, timemin.ToString());
        }
        if (timemin >= 0.01f && di.GetFiles().Length < 1000 && di.GetFiles().Length > 99)
        {


            File.WriteAllText("records/" + "0" + di.GetFiles().Length, timemin.ToString());
        }
        if (timemin >= 0.01f && di.GetFiles().Length > 999)
        {


            File.WriteAllText("records/" + "" + di.GetFiles().Length, timemin.ToString());
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tic += 1 * Time.fixedDeltaTime;
        timemin += 1 * Time.fixedDeltaTime / 60;
        if (tic >= time)
        {


            int i = 0;
            for (int x = -10; x < 10; x += Random.Range(0, 10))
            {
                for (int y = -10; y < 10; y += Random.Range(0, 10))
                {
                    if (x < -9 || x >= 9 || y < -9 || y >= 9 && i < 3)
                    {

                        i++;
                        Instantiate(zombie[Random.Range(0,zombie.Length)], transform.position + new Vector3(x * 100, y * 100, 0), Quaternion.identity);
                    }
                }
            }
            tic = 0;
            if (time > 0.8f)
            {


                time /= 1.1f;
            }
        }
    }
}

