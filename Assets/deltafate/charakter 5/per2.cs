using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class per2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.Rotate(new Vector3(0,0,Random.Range(-10,10)));
        transform.Translate(0,1,0);
    }
    public void delete()
    {
        Destroy(gameObject);
    }
    
}
