using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public GameObject player;
    public GameObject player3;
    public GameObject player2;
    void Update()
    {
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length != 0 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length != 0)
        {
            if (player.GetComponent<igrok>().fight == true)
            {
                transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, -10);
            }

            if (player.GetComponent<igrok>().fight == false)
            {
                transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
            }
        }
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length != 0 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length != 1)
        {
            if (player.GetComponent<igrok>().fight == true)
            {
                transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y, -10);
            }

            if (player.GetComponent<igrok>().fight == false)
            {
                transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
            }
        }
        if (GameObject.FindObjectsOfType<Sanc_soul_move>().Length != 1 && GameObject.FindObjectsOfType<Sanc_soul_move1>().Length != 0)
        {
            if (player.GetComponent<igrok>().fight == true)
            {
                transform.position = new Vector3(player3.transform.position.x, player3.transform.position.y, -10);
            }

            if (player.GetComponent<igrok>().fight == false)
            {
                transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
            }
        }
    }
}
