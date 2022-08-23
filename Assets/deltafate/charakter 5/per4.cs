using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class per4 : MonoBehaviour
{
    GameObject player;
    public float offset;
    public float spped;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("soul")[Random.Range(0, GameObject.FindGameObjectsWithTag("soul").Length)];
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
            transform.Translate(0, spped * Time.fixedDeltaTime,0);
            
        
       
            Vector3 difference = player.transform.position - transform.position;
            float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotz / 2 - offset);
        
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
