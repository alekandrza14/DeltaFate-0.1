using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testing1 : MonoBehaviour
{
    public string varible;
    public int voule;
    public igrok2 i;
    public int i2;
    
    public void Start()
    {
        i = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)].GetComponent<igrok2>();

    }
    public void buttton()
    {
       
        if (i.fight != true)
        {
            
                
            

                PlayerPrefs.SetInt(varible, voule);
        }
        i2++;
        
        if (i2 > GameObject.FindGameObjectsWithTag("Player").Length -1)
        {
            i2 = 0;
        }
        i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();

        i.fight = true;
        



    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {


            if (i2 > GameObject.FindGameObjectsWithTag("Player").Length - 1)
            {
                i2 = 0;
            }
            i = GameObject.FindGameObjectsWithTag("Player")[i2].GetComponent<igrok2>();

            i.fight = true;
        }
    }
}
