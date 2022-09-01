using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class souznic
{
    public ActiveBehaiver character;
    public ActiveBehaiver comandir;
    public souznic(ActiveBehaiver character, ActiveBehaiver comandir)
    {
        this.character = character;
        this.comandir = comandir;
    }
}
