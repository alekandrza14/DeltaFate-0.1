using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss53 : MonoBehaviour
{
    public GameObject EXIT;
    public int count;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.tag== "s")
            {
                count += 1;
                PlayerPrefs.SetInt("tt", count);
            }
        
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "s")
        {
            count -= 1;
            PlayerPrefs.SetInt("tt", count);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("tt", 0) == 3 &&!GameObject.FindWithTag("n"))
        {
            Instantiate(EXIT);
        }
        if (PlayerPrefs.GetInt("tt", 0) != 3)
        {
            Destroy(GameObject.FindWithTag("n"));
        }
    }
}
