using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yeson : MonoBehaviour
{
    public int id;
    public void characterupenter()
    {
        SceneManager.LoadScene(id);
    }
    public void Update()
    {
        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
        {
            SceneManager.LoadScene(id);
        }
    }
}
