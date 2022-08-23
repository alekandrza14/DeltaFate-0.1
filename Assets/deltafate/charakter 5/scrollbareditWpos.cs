using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrollbareditWpos : MonoBehaviour
{
    public Scrollbar Wpos;
    void Start()
    {
        if (File.Exists("DELTAFATE/Wpos" + SceneManager.GetActiveScene().name))
        {


            Wpos.value = float.Parse(File.ReadAllText("DELTAFATE/Wpos" + SceneManager.GetActiveScene().name));
        }
    }


        void FixedUpdate()
    {
        if (Wpos.value >= 0 && Input.GetKey(KeyCode.LeftAlt))
        {
            Wpos.value += 0.02f;
        }
        if (Wpos.value <= 1 && Input.GetKey(KeyCode.LeftControl))
        {
            Wpos.value -= 0.02f;
        }
        if (Wpos.value > 1)
        {
            Wpos.value = 1;
        }
        if (Wpos.value < 0)
        {
            Wpos.value = 0;
        }
        File.WriteAllText("DELTAFATE/Wpos"+ SceneManager.GetActiveScene().name,Wpos.value.ToString());
    }
}
