using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class per1 : MonoBehaviour
{
    GameObject player;
    public float offset;
    public float spped;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[Random.Range(0, GameObject.FindGameObjectsWithTag("Player").Length)];
    }

    // Update is called once per frame
    void Update()
    {
       
        RaycastHit2D hit = Physics2D.Linecast(transform.position, transform.up*1, LayerMask.GetMask("soul"));
        
            transform.Translate(0, spped * Time.fixedDeltaTime,0);
            
        
       
            Vector3 difference = player.transform.position - transform.position;
            float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotz - offset);
        
    }
    public void delete()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(31);
            delete();
        }
    }
}
