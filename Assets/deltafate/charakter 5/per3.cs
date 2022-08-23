using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class per3 : MonoBehaviour
{
    GameObject player;
    public float offset;
    public float spped;
    public float tic;
    public float time = 1000;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("soul")[Random.Range(0, GameObject.FindGameObjectsWithTag("soul").Length)];
    }

    // Update is called once per frame
    void Update()
    {


        tic += Time.fixedDeltaTime;
            transform.Translate(0, spped * Time.deltaTime,0);


        if (tic<time) {
            Vector3 difference = player.transform.position - transform.position;
            float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotz - offset);
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
