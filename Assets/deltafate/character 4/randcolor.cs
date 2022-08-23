using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randcolor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0, 2),Random.Range(0, 2),Random.Range(0, 2),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
