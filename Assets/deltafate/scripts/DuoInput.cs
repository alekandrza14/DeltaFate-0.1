using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuoInput : MonoBehaviour
{
   static public bool left()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            f = true;
        }
        return f;
    }
    static public bool right()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            f = true;
        }
        return f;
    }
    static public bool up()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            f = true;
        }
        return f;
    }
    static public bool down()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            f = true;
        }
        return f;
    }
    static public bool Enter()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            f = true;
        }
        return f;
    }
    static public bool Ñancellation()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            f = true;
        }
        return f;
    }
    static public bool ÑancellationS()
    {
        bool f = false;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            f = true;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            f = true;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            f = true;
        }
        if (Input.GetKey(KeyCode.X))
        {
            f = true;
        }
        return f;
    }
    static public bool Act()
    {
        bool f = false;
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            f = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            f = true;
        }
        return f;
    }
}
