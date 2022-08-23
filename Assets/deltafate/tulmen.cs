using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class tulmen : MonoBehaviour
{
    public double goingbytulmen;
    private void Update()
    {
        Directory.CreateDirectory(@"DELTAFATE/unauticna");
        File.WriteAllText(@"DELTAFATE/unauticna/goingbytulmen", goingbytulmen.ToString());
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.tag == "Player")
        {
            goingbytulmen += 1 * 0.1f * Time.deltaTime;
        }
    }
    private void Start()
    {
        if (File.Exists(@"DELTAFATE/unauticna/goingbytulmen"))
        {
            goingbytulmen = double.Parse(File.ReadAllText(@"DELTAFATE/unauticna/goingbytulmen"));
        }
    }
}
