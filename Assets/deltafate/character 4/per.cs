using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class per : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Linecast(transform.position, transform.up*1000, LayerMask.GetMask("soul"));
        if (hit.collider != null)
        {
            transform.Translate(0, 100 * Time.fixedDeltaTime,0);
        }
        else
        {
            transform.Rotate(new Vector3(0,0,50 * Time.fixedDeltaTime));
        }
    }
    public void delete()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "soul")
        {

            delete();
        }
    }
}
