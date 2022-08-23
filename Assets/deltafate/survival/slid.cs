using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slid : MonoBehaviour
{
    public GameObject sl;
    public int sl1; public int sl2;
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("t").Length / 5 < sl.transform.position.y + sl2 / 112)
        {
            sl.transform.position += new Vector3(0, -1, 0);
        }
        if (GameObject.FindGameObjectsWithTag("t").Length / 5 > sl.transform.position.y - sl1 / 112)
        {
            sl.transform.position += new Vector3(0, 1, 0);
        }
        sl.transform.position += new Vector3(0,-Input.GetAxis("Mouse ScrollWheel") * 20,0);
    }
}
