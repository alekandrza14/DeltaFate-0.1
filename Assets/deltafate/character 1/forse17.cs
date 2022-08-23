using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse17 : MonoBehaviour
{
    
   
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "2")
        {
            Destroy(gameObject);
        }
        
    }
   
}
