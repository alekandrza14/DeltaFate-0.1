using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hillzone : MonoBehaviour
{
    public int hill;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (collision.collider.GetComponent<ActiveBehaiver>().mhp > hill)
            {
                collision.collider.GetComponent<ActiveBehaiver>().hp += hill;
            }
            
            if (collision.collider.GetComponent<ActiveBehaiver>().mhp <= hill)
            {
                collision.collider.GetComponent<ActiveBehaiver>().hp = collision.collider.GetComponent<ActiveBehaiver>().mhp;
            }
        }
    }
}
